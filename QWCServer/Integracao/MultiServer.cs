using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Data;
using System.Data.OracleClient;

namespace QWCServer.Integracao
{
    class MultiServer
    {

        public static string oradb = "";
        internal static string codProd = "";

        private static int _bufferSize = 2048; //Default buffer size
        private static int BufferSize { get => _bufferSize; set => _bufferSize = value; }

        private static int _port = 1965; //Default Port Value
        private static int Port { get => _port; set => _port = value; }

        private static List<String> _log = new List<String>();

        private static string sqlCmdTemplate = "";

        public static Array Log
        {
            get
            {
                String[] itens = _log.ToArray();
                Array.Reverse(itens);
                return itens;
            }
        }

        private static readonly List<Socket> _clientSockets = new List<Socket>();
        private static List<Socket> ClientList { get => _clientSockets;}
        public static int ClientList_Count { get => _clientSockets.Count; }

        private static readonly byte[] buffer = new byte[BufferSize];
        private static readonly Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static Socket ServerSocket { get => _serverSocket; }
        public static bool ServerSocket_Status { get => _serverSocket.Connected; }
        public static EndPoint ServerSocket_LocalEndPoint { get => _serverSocket.LocalEndPoint; }
        
        public static void Start(int _bufferSize, int _port, string _oradb)
        {
            _log.Add("Parametrizando sistema...");
            BufferSize = _bufferSize;
            Port = _port;
            oradb = _oradb;
            _log.Add("Preparando banco de dados...");
            _log.Add("Preparando servidor...");
            ServerSocket.Bind(new IPEndPoint(IPAddress.Any, Port));
            ServerSocket.Listen(0);
            ServerSocket.BeginAccept(AcceptCallback, null);
            _log.Add("Servidor pronto!");
        }

        /// <summary>
        /// Close all connected client (we do not need to shutdown the server socket as its connections
        /// are already closed with the clients).
        /// </summary>
        public static void CloseAllSockets()
        {
            foreach (Socket socket in ClientList)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            ServerSocket.Close();
        }

        private static void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;

            try
            {
                socket = ServerSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException) // I cannot seem to avoid this (on exit when properly closing sockets)
            {
                return;
            }

            ClientList.Add(socket);
            socket.BeginReceive(buffer, 0, BufferSize, SocketFlags.None, ReceiveCallback, socket);
            _log.Add("Novo equipamento conectado, aguardando requisicoes...");
            ServerSocket.BeginAccept(AcceptCallback, null);
        }

        private static bool SocketConnected(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }

        public static String[] ConsultarDB(string _codProd = "0")
        {
            string[] _linhasDisplay = new string[4];
            

            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = @"select prod.Nome1 as descricao, ean.codbarra as codigo_EAN, (CASE when (pro.precopromocao > 0) then pro.precopromocao else prec.PrecoVenda end) as valPreco, (CASE when (pro.precopromocao > 0) then '*** PROMOCAO ***' else ' ' end) as descLinha4 from produtos prod inner join EPMIX.produtos_loja prodMix on prodMix.Codigo = prod.codigo and prodMix.Loja = 845021 inner join EPMIX.produtos_precos prec on prec.codigo = prod.Codigo and prec.loja = prodMix.loja inner join EPMIX.Produtos_Ean EanCompra on EanCompra.Codigo = prod.Codigo and EanCompra.CompraPadrao = 'S' inner join EPMIX.produtos_ean ean on ean.codigo = prod.codigo left outer join EPMIX.promocao pro on pro.codigo = prod.codigo and pro.loja = prodMix.loja and ((Pro.DataInicial <= trunc(sysdate)) and ((Pro.DataFinal >= trunc(sysdate)) or (Pro.Indeterminada = 'S'))) where prod.Inativo <> 'S' and prod.Bloqueia_Impressao_Etiq = 0 and prec.PrecoVenda > 0 and  ean.codbarra = " + _codProd + " and prodMix.Loja = 845021";
            cmd.CommandType = CommandType.Text;
            OracleDataReader _dr = cmd.ExecuteReader();
            _dr.Read();
            if (_dr.HasRows)
            {
                if (_dr.GetValue(0) != null)
                    _linhasDisplay[0] = _dr.GetValue(0).ToString();
                if (_dr.GetValue(1) != null)
                    _linhasDisplay[1] = _dr.GetValue(1).ToString();
                if (_dr.GetValue(2) != null)
                    _linhasDisplay[2] = _dr.GetValue(2).ToString();
                if (_dr.GetValue(3) != null)
                    _linhasDisplay[3] = _dr.GetValue(3).ToString();
            }
            else
                _linhasDisplay[1] = "PROD NAO ENCONTRADO";

            conn.Close();
            conn.Dispose();

            return _linhasDisplay;
        }


        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                if (!SocketConnected(current)) //when client has a brutally disconnection
                {
                    _log.Add("Socket oscioso detectado!");
                    throw new SocketException();
                }



                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                _log.Add("Cliente forcado a desconectar");
                // Don't shutdown because the socket may be disposed and its disconnected anyway.
                current.Close();
                ClientList.Remove(current);
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);
            string text2 = Encoding.ASCII.GetString(buffer);
            Console.WriteLine("Texto recebido: " + text);
            if (text[0] == '1') // Client request server confirmation
            {
                byte[] data = Encoding.ASCII.GetBytes("M");
                current.Send(data);
            }
            if (text[0] == '2') // Client request codebar
            {
                //byte[] data = Encoding.ASCII.GetBytes("L" + "    PRODUTOXYZ      " + "             R$12.99" + "                    " + "**PROMOCAO ENCARTE**"); //20char

                text2 = text2.Replace("\0", string.Empty);
                string _codProd = text2.Substring(1, text2.Length-1);
                string [] linhasDisplay = ConsultarDB(_codProd);
                _log.Add("Requisicao de Produto: " + _codProd + " : " + linhasDisplay[0]);
                byte[] data = Encoding.ASCII.GetBytes("L" + AlignString.Align(true, linhasDisplay[0], 20) +
                                                            linhasDisplay[1] + 
                                                            new string(' ', 20 - linhasDisplay[1].Length) +
                                                            AlignString.Align(false, linhasDisplay[2], 20) +
                                                            AlignString.Align(true, linhasDisplay[3], 20)); //20char
                current.Send(data);
                Array.Clear(buffer, 0, buffer.Length);
            }
            else if (text[0] == 'e') // Client wants to exit
            {
                // Always Shutdown before closing
                current.Shutdown(SocketShutdown.Both);
                current.Close();
                ClientList.Remove(current);
                _log.Add("Cliente desconectou");
                return;
            }

            current.BeginReceive(buffer, 0, BufferSize, SocketFlags.None, ReceiveCallback, current);
        }

    }
}

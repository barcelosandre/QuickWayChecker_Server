using System;
using System.Data;
using System.Windows.Forms;
using QWCServer.Integracao;



namespace QWCServer

{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MultiServer.Start(1024, 1965, "Data Source=(DESCRIPTION="
            //                            + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" 
            //                            + txtDBAdd.Text.Trim() + ")(PORT=" 
            //                            + txtDBPort.Text.Trim() + ")))"
            //                            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=smartsrv)));"
            //                            + "User Id=" + txtDBLogin.Text + ";Password=" + txtDBPass.Text + ";");

            lblIPAddress.Text = MultiServer.ClientList_Count.ToString();
            timer1.Interval = 500;
            timer1.Start();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MultiServer.conn.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = MultiServer.ServerSocket_Status.ToString();
            lblClients.Text = MultiServer.ClientList_Count.ToString();
            lstLog1.DataSource = MultiServer.Log;
        }

        private void btnSrvTrig_Click(object sender, EventArgs e)
        {
            MultiServer.Start(1024, 1965, "Data Source=(DESCRIPTION="
                                        + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST="
                                        + txtDBAdd.Text.Trim() + ")(PORT="
                                        + txtDBPort.Text.Trim() + ")))"
                                        + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=smartsrv)));"
                                        + "User Id=" + txtDBLogin.Text + ";Password=" + txtDBPass.Text + ";");
        }

        private void txtDBLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSql.Text = MultiServer.ConsultarDB("675")[0];
        }

    }
}

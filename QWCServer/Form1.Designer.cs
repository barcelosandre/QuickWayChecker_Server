namespace QWCServer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstLog1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblClients = new System.Windows.Forms.Label();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDBLogin = new System.Windows.Forms.TextBox();
            this.txtDBPass = new System.Windows.Forms.TextBox();
            this.btnSrvTrig = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.txtDBAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDBPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLog1
            // 
            this.lstLog1.FormattingEnabled = true;
            this.lstLog1.ItemHeight = 15;
            this.lstLog1.Location = new System.Drawing.Point(12, 27);
            this.lstLog1.Name = "lstLog1";
            this.lstLog1.Size = new System.Drawing.Size(600, 199);
            this.lstLog1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message Log:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Port:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 242);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1965";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(148, 279);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 15);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Stopped";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of Term:";
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClients.Location = new System.Drawing.Point(148, 311);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(21, 15);
            this.lblClients.TabIndex = 7;
            this.lblClients.Text = "00";
            // 
            // txtSql
            // 
            this.txtSql.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSql.Location = new System.Drawing.Point(359, 245);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSql.Size = new System.Drawing.Size(253, 222);
            this.txtSql.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "DB Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "DB Passw";
            // 
            // txtDBLogin
            // 
            this.txtDBLogin.Location = new System.Drawing.Point(96, 389);
            this.txtDBLogin.MaxLength = 5;
            this.txtDBLogin.Name = "txtDBLogin";
            this.txtDBLogin.Size = new System.Drawing.Size(120, 21);
            this.txtDBLogin.TabIndex = 11;
            this.txtDBLogin.Text = "epmix";
            this.txtDBLogin.TextChanged += new System.EventHandler(this.txtDBLogin_TextChanged);
            // 
            // txtDBPass
            // 
            this.txtDBPass.Location = new System.Drawing.Point(96, 416);
            this.txtDBPass.MaxLength = 5;
            this.txtDBPass.Name = "txtDBPass";
            this.txtDBPass.PasswordChar = 'O';
            this.txtDBPass.Size = new System.Drawing.Size(120, 21);
            this.txtDBPass.TabIndex = 12;
            this.txtDBPass.Text = "Smart";
            // 
            // btnSrvTrig
            // 
            this.btnSrvTrig.Location = new System.Drawing.Point(278, 275);
            this.btnSrvTrig.Name = "btnSrvTrig";
            this.btnSrvTrig.Size = new System.Drawing.Size(75, 23);
            this.btnSrvTrig.TabIndex = 13;
            this.btnSrvTrig.Text = "&Start";
            this.btnSrvTrig.UseVisualStyleBackColor = true;
            this.btnSrvTrig.Click += new System.EventHandler(this.btnSrvTrig_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Server IP:";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIPAddress.Location = new System.Drawing.Point(148, 336);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(112, 15);
            this.lblIPAddress.TabIndex = 16;
            this.lblIPAddress.Text = "000.000.000.000";
            // 
            // txtDBAdd
            // 
            this.txtDBAdd.Location = new System.Drawing.Point(96, 443);
            this.txtDBAdd.MaxLength = 5;
            this.txtDBAdd.Name = "txtDBAdd";
            this.txtDBAdd.Size = new System.Drawing.Size(120, 21);
            this.txtDBAdd.TabIndex = 18;
            this.txtDBAdd.Text = "epmix.ddns-intelbras.com.br";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "DB Server";
            // 
            // txtDBPort
            // 
            this.txtDBPort.Location = new System.Drawing.Point(96, 470);
            this.txtDBPort.MaxLength = 5;
            this.txtDBPort.Name = "txtDBPort";
            this.txtDBPort.Size = new System.Drawing.Size(120, 21);
            this.txtDBPort.TabIndex = 20;
            this.txtDBPort.Text = "1521";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "DB Port";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDBPort);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDBAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSrvTrig);
            this.Controls.Add(this.txtDBPass);
            this.Controls.Add(this.txtDBLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLog1);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QWC Server - 0.01";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDBLogin;
        private System.Windows.Forms.TextBox txtDBPass;
        private System.Windows.Forms.Button btnSrvTrig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.TextBox txtDBAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDBPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}


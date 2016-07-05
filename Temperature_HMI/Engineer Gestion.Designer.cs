namespace Temperature_HMI
{
    partial class Engineer_Gestion
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsigne1 = new System.Windows.Forms.TextBox();
            this.btnValiderAutoManuel = new System.Windows.Forms.Button();
            this.rBAuto = new System.Windows.Forms.RadioButton();
            this.rBManuel = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnValiderHyster = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDeadBand = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBPID = new System.Windows.Forms.RadioButton();
            this.rBPI = new System.Windows.Forms.RadioButton();
            this.rBP = new System.Windows.Forms.RadioButton();
            this.btnValiderPID = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtKp = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtKd = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtKi = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbHysterisis = new System.Windows.Forms.RadioButton();
            this.rbTor = new System.Windows.Forms.RadioButton();
            this.btnValiderChoixReg = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controleur Parametres";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtConsigne1);
            this.groupBox6.Controls.Add(this.btnValiderAutoManuel);
            this.groupBox6.Controls.Add(this.rBAuto);
            this.groupBox6.Controls.Add(this.rBManuel);
            this.groupBox6.Location = new System.Drawing.Point(7, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(443, 91);
            this.groupBox6.TabIndex = 85;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Auto/Manual";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(67, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 86;
            this.label2.Text = "Consigne";
            // 
            // txtConsigne1
            // 
            this.txtConsigne1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtConsigne1.Location = new System.Drawing.Point(159, 42);
            this.txtConsigne1.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsigne1.Name = "txtConsigne1";
            this.txtConsigne1.Size = new System.Drawing.Size(106, 20);
            this.txtConsigne1.TabIndex = 85;
            this.txtConsigne1.Text = "50";
            this.txtConsigne1.TextChanged += new System.EventHandler(this.txtConsigne1_TextChanged);
            // 
            // btnValiderAutoManuel
            // 
            this.btnValiderAutoManuel.Location = new System.Drawing.Point(308, 19);
            this.btnValiderAutoManuel.Name = "btnValiderAutoManuel";
            this.btnValiderAutoManuel.Size = new System.Drawing.Size(87, 43);
            this.btnValiderAutoManuel.TabIndex = 84;
            this.btnValiderAutoManuel.Text = "Valider";
            this.btnValiderAutoManuel.UseVisualStyleBackColor = true;
            this.btnValiderAutoManuel.Click += new System.EventHandler(this.btnValiderAutoManuel_Click);
            // 
            // rBAuto
            // 
            this.rBAuto.AutoSize = true;
            this.rBAuto.Checked = true;
            this.rBAuto.Location = new System.Drawing.Point(68, 22);
            this.rBAuto.Name = "rBAuto";
            this.rBAuto.Size = new System.Drawing.Size(47, 17);
            this.rBAuto.TabIndex = 3;
            this.rBAuto.TabStop = true;
            this.rBAuto.Text = "Auto";
            this.rBAuto.UseVisualStyleBackColor = true;
            this.rBAuto.CheckedChanged += new System.EventHandler(this.rBAuto_CheckedChanged);
            // 
            // rBManuel
            // 
            this.rBManuel.AutoSize = true;
            this.rBManuel.Location = new System.Drawing.Point(205, 22);
            this.rBManuel.Name = "rBManuel";
            this.rBManuel.Size = new System.Drawing.Size(60, 17);
            this.rBManuel.TabIndex = 2;
            this.rBManuel.Text = "Manuel";
            this.rBManuel.UseVisualStyleBackColor = true;
            this.rBManuel.CheckedChanged += new System.EventHandler(this.rBManuel_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnValiderChoixReg);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.rbTor);
            this.groupBox5.Controls.Add(this.rbHysterisis);
            this.groupBox5.Location = new System.Drawing.Point(6, 117);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 91);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Choix de regulateur";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnValiderHyster);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtDeadBand);
            this.groupBox4.Location = new System.Drawing.Point(212, 117);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 91);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Regulateur a hysterisis";
            // 
            // btnValiderHyster
            // 
            this.btnValiderHyster.Location = new System.Drawing.Point(96, 64);
            this.btnValiderHyster.Name = "btnValiderHyster";
            this.btnValiderHyster.Size = new System.Drawing.Size(87, 23);
            this.btnValiderHyster.TabIndex = 78;
            this.btnValiderHyster.Text = "Valider";
            this.btnValiderHyster.UseVisualStyleBackColor = true;
            this.btnValiderHyster.Click += new System.EventHandler(this.btnValiderHyster_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(23, 36);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 19);
            this.label16.TabIndex = 60;
            this.label16.Text = "DeadBand";
            // 
            // txtDeadBand
            // 
            this.txtDeadBand.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDeadBand.Location = new System.Drawing.Point(96, 35);
            this.txtDeadBand.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeadBand.Name = "txtDeadBand";
            this.txtDeadBand.Size = new System.Drawing.Size(87, 20);
            this.txtDeadBand.TabIndex = 59;
            this.txtDeadBand.Text = "5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBPID);
            this.groupBox1.Controls.Add(this.rBPI);
            this.groupBox1.Controls.Add(this.rBP);
            this.groupBox1.Controls.Add(this.btnValiderPID);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtKp);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtKd);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtKi);
            this.groupBox1.Location = new System.Drawing.Point(456, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regulateur PID";
            // 
            // rBPID
            // 
            this.rBPID.AutoSize = true;
            this.rBPID.Location = new System.Drawing.Point(163, 33);
            this.rBPID.Name = "rBPID";
            this.rBPID.Size = new System.Drawing.Size(43, 17);
            this.rBPID.TabIndex = 77;
            this.rBPID.Text = "PID";
            this.rBPID.UseVisualStyleBackColor = true;
            this.rBPID.CheckedChanged += new System.EventHandler(this.rBPID_CheckedChanged);
            // 
            // rBPI
            // 
            this.rBPI.AutoSize = true;
            this.rBPI.Location = new System.Drawing.Point(94, 33);
            this.rBPI.Name = "rBPI";
            this.rBPI.Size = new System.Drawing.Size(35, 17);
            this.rBPI.TabIndex = 76;
            this.rBPI.Text = "PI";
            this.rBPI.UseVisualStyleBackColor = true;
            this.rBPI.CheckedChanged += new System.EventHandler(this.rBPI_CheckedChanged);
            // 
            // rBP
            // 
            this.rBP.AutoSize = true;
            this.rBP.Checked = true;
            this.rBP.Location = new System.Drawing.Point(40, 33);
            this.rBP.Name = "rBP";
            this.rBP.Size = new System.Drawing.Size(32, 17);
            this.rBP.TabIndex = 75;
            this.rBP.TabStop = true;
            this.rBP.Text = "P";
            this.rBP.UseVisualStyleBackColor = true;
            this.rBP.CheckedChanged += new System.EventHandler(this.rBP_CheckedChanged);
            // 
            // btnValiderPID
            // 
            this.btnValiderPID.Location = new System.Drawing.Point(108, 160);
            this.btnValiderPID.Name = "btnValiderPID";
            this.btnValiderPID.Size = new System.Drawing.Size(87, 23);
            this.btnValiderPID.TabIndex = 74;
            this.btnValiderPID.Text = "Valider";
            this.btnValiderPID.UseVisualStyleBackColor = true;
            this.btnValiderPID.Click += new System.EventHandler(this.btnValiderPID_Click);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label21.Location = new System.Drawing.Point(37, 72);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 19);
            this.label21.TabIndex = 73;
            this.label21.Text = "Kp";
            // 
            // txtKp
            // 
            this.txtKp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtKp.Location = new System.Drawing.Point(108, 72);
            this.txtKp.Margin = new System.Windows.Forms.Padding(2);
            this.txtKp.Name = "txtKp";
            this.txtKp.Size = new System.Drawing.Size(87, 20);
            this.txtKp.TabIndex = 72;
            this.txtKp.Text = "5";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label20.Location = new System.Drawing.Point(37, 134);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 19);
            this.label20.TabIndex = 71;
            this.label20.Text = "Kd";
            // 
            // txtKd
            // 
            this.txtKd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtKd.Location = new System.Drawing.Point(108, 134);
            this.txtKd.Margin = new System.Windows.Forms.Padding(2);
            this.txtKd.Name = "txtKd";
            this.txtKd.Size = new System.Drawing.Size(87, 20);
            this.txtKd.TabIndex = 70;
            this.txtKd.Text = "5";
            this.txtKd.TextChanged += new System.EventHandler(this.txtKd_TextChanged);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label19.Location = new System.Drawing.Point(37, 101);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 19);
            this.label19.TabIndex = 69;
            this.label19.Text = "Ki";
            // 
            // txtKi
            // 
            this.txtKi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtKi.Location = new System.Drawing.Point(108, 101);
            this.txtKi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKi.Name = "txtKi";
            this.txtKi.Size = new System.Drawing.Size(87, 20);
            this.txtKi.TabIndex = 68;
            this.txtKi.Text = "5";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBackup);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtServer);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtDataBase);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Controls.Add(this.txtUsername);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(683, 169);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DataBase Configuration";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(469, 60);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(116, 46);
            this.btnBackup.TabIndex = 94;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(422, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 21);
            this.label7.TabIndex = 93;
            this.label7.Text = "Backup";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(62, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 21);
            this.label6.TabIndex = 92;
            this.label6.Text = "Parametres  de connexion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 79;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtServer.Location = new System.Drawing.Point(127, 117);
            this.txtServer.Margin = new System.Windows.Forms.Padding(2);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(145, 20);
            this.txtServer.TabIndex = 91;
            this.txtServer.Text = "localhost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "Server";
            // 
            // txtDataBase
            // 
            this.txtDataBase.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDataBase.Location = new System.Drawing.Point(127, 94);
            this.txtDataBase.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(145, 20);
            this.txtDataBase.TabIndex = 89;
            this.txtDataBase.Text = "MFE_database";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPassword.Location = new System.Drawing.Point(127, 70);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(145, 20);
            this.txtPassword.TabIndex = 88;
            this.txtPassword.Text = "Admin";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUsername.Location = new System.Drawing.Point(127, 44);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(145, 20);
            this.txtUsername.TabIndex = 87;
            this.txtUsername.Text = "Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "DataBase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 62);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 80;
            this.radioButton1.Text = "PID";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbHysterisis
            // 
            this.rbHysterisis.AutoSize = true;
            this.rbHysterisis.Location = new System.Drawing.Point(21, 40);
            this.rbHysterisis.Margin = new System.Windows.Forms.Padding(2);
            this.rbHysterisis.Name = "rbHysterisis";
            this.rbHysterisis.Size = new System.Drawing.Size(76, 17);
            this.rbHysterisis.TabIndex = 79;
            this.rbHysterisis.Text = "a hysterisis";
            this.rbHysterisis.UseVisualStyleBackColor = true;
            // 
            // rbTor
            // 
            this.rbTor.AutoSize = true;
            this.rbTor.Checked = true;
            this.rbTor.Location = new System.Drawing.Point(21, 18);
            this.rbTor.Margin = new System.Windows.Forms.Padding(2);
            this.rbTor.Name = "rbTor";
            this.rbTor.Size = new System.Drawing.Size(48, 17);
            this.rbTor.TabIndex = 78;
            this.rbTor.TabStop = true;
            this.rbTor.Text = "TOR";
            this.rbTor.UseVisualStyleBackColor = true;
            // 
            // btnValiderChoixReg
            // 
            this.btnValiderChoixReg.Location = new System.Drawing.Point(121, 56);
            this.btnValiderChoixReg.Name = "btnValiderChoixReg";
            this.btnValiderChoixReg.Size = new System.Drawing.Size(68, 23);
            this.btnValiderChoixReg.TabIndex = 79;
            this.btnValiderChoixReg.Text = "Valider";
            this.btnValiderChoixReg.UseVisualStyleBackColor = true;
            this.btnValiderChoixReg.Click += new System.EventHandler(this.btnValiderChoixReg_Click);
            // 
            // Engineer_Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 405);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Engineer_Gestion";
            this.Text = "Gestion des parametres";
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtKp;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtKd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtKi;
        private System.Windows.Forms.RadioButton rBPID;
        private System.Windows.Forms.RadioButton rBPI;
        private System.Windows.Forms.RadioButton rBP;
        private System.Windows.Forms.Button btnValiderPID;
        private System.Windows.Forms.Button btnValiderHyster;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDeadBand;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsigne1;
        private System.Windows.Forms.Button btnValiderAutoManuel;
        private System.Windows.Forms.RadioButton rBAuto;
        private System.Windows.Forms.RadioButton rBManuel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnValiderChoixReg;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbTor;
        private System.Windows.Forms.RadioButton rbHysterisis;
    }
}
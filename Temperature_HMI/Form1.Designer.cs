namespace Temperature_HMI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblTypeReg = new System.Windows.Forms.Label();
            this.txtCommande = new System.Windows.Forms.TextBox();
            this.grpHystersis = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDeadBand = new System.Windows.Forms.TextBox();
            this.grpPID = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtKp = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtKd = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtKi = new System.Windows.Forms.TextBox();
            this.lblTypeController = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAlarmeStat = new Temperature_HMI.roundButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.vPbcapt = new Temperature_HMI.VerticalProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnStartProcess = new Temperature_HMI.roundButton();
            this.lblResStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTempMoy = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtT3 = new System.Windows.Forms.TextBox();
            this.txtT2 = new System.Windows.Forms.TextBox();
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSetPointShow = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.laToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputasfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveinputasfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmeSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controllerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLowLimit = new System.Windows.Forms.TextBox();
            this.txtHighLimit = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnShowAlarm = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnGestionParametres = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnGraphs = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPortName = new System.Windows.Forms.TextBox();
            this.rbDisconnect = new System.Windows.Forms.RadioButton();
            this.rbConnect = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbPID = new System.Windows.Forms.RadioButton();
            this.rbHysterisis = new System.Windows.Forms.RadioButton();
            this.rbTor = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbActionPID = new System.Windows.Forms.RadioButton();
            this.rbActionPI = new System.Windows.Forms.RadioButton();
            this.rbActionP = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.grpHystersis.SuspendLayout();
            this.grpPID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.lblTypeReg);
            this.groupBox1.Controls.Add(this.txtCommande);
            this.groupBox1.Controls.Add(this.grpHystersis);
            this.groupBox1.Controls.Add(this.grpPID);
            this.groupBox1.Controls.Add(this.lblTypeController);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.btnAlarmeStat);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.vPbcapt);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.BtnStartProcess);
            this.groupBox1.Controls.Add(this.lblResStatus);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTempMoy);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtT3);
            this.groupBox1.Controls.Add(this.txtT2);
            this.groupBox1.Controls.Add(this.txtT1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSetPointShow);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtError);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label22.Location = new System.Drawing.Point(47, 145);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 20);
            this.label22.TabIndex = 74;
            this.label22.Text = "°C";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTypeReg
            // 
            this.lblTypeReg.BackColor = System.Drawing.Color.Plum;
            this.lblTypeReg.Location = new System.Drawing.Point(199, 143);
            this.lblTypeReg.Name = "lblTypeReg";
            this.lblTypeReg.Size = new System.Drawing.Size(66, 22);
            this.lblTypeReg.TabIndex = 73;
            this.lblTypeReg.Text = "TOR";
            this.lblTypeReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCommande
            // 
            this.txtCommande.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCommande.Location = new System.Drawing.Point(323, 136);
            this.txtCommande.Name = "txtCommande";
            this.txtCommande.Size = new System.Drawing.Size(61, 20);
            this.txtCommande.TabIndex = 71;
            // 
            // grpHystersis
            // 
            this.grpHystersis.Controls.Add(this.label16);
            this.grpHystersis.Controls.Add(this.txtDeadBand);
            this.grpHystersis.Location = new System.Drawing.Point(182, 168);
            this.grpHystersis.Name = "grpHystersis";
            this.grpHystersis.Size = new System.Drawing.Size(118, 39);
            this.grpHystersis.TabIndex = 69;
            this.grpHystersis.TabStop = false;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(2, 16);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 19);
            this.label16.TabIndex = 58;
            this.label16.Text = "DeadBand";
            // 
            // txtDeadBand
            // 
            this.txtDeadBand.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDeadBand.Location = new System.Drawing.Point(73, 15);
            this.txtDeadBand.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeadBand.Name = "txtDeadBand";
            this.txtDeadBand.Size = new System.Drawing.Size(42, 20);
            this.txtDeadBand.TabIndex = 57;
            this.txtDeadBand.Text = "5";
            this.txtDeadBand.TextChanged += new System.EventHandler(this.txtDeadBand_TextChanged);
            // 
            // grpPID
            // 
            this.grpPID.Controls.Add(this.label21);
            this.grpPID.Controls.Add(this.txtKp);
            this.grpPID.Controls.Add(this.label20);
            this.grpPID.Controls.Add(this.txtKd);
            this.grpPID.Controls.Add(this.label19);
            this.grpPID.Controls.Add(this.txtKi);
            this.grpPID.Location = new System.Drawing.Point(178, 37);
            this.grpPID.Name = "grpPID";
            this.grpPID.Size = new System.Drawing.Size(129, 85);
            this.grpPID.TabIndex = 68;
            this.grpPID.TabStop = false;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label21.Location = new System.Drawing.Point(5, 16);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 19);
            this.label21.TabIndex = 67;
            this.label21.Text = "Kp";
            // 
            // txtKp
            // 
            this.txtKp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtKp.Location = new System.Drawing.Point(76, 15);
            this.txtKp.Margin = new System.Windows.Forms.Padding(2);
            this.txtKp.Name = "txtKp";
            this.txtKp.Size = new System.Drawing.Size(49, 20);
            this.txtKp.TabIndex = 66;
            this.txtKp.Text = "5";
            this.txtKp.TextChanged += new System.EventHandler(this.txtKp_TextChanged);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label20.Location = new System.Drawing.Point(4, 55);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 19);
            this.label20.TabIndex = 65;
            this.label20.Text = "Kd";
            // 
            // txtKd
            // 
            this.txtKd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtKd.Location = new System.Drawing.Point(75, 54);
            this.txtKd.Margin = new System.Windows.Forms.Padding(2);
            this.txtKd.Name = "txtKd";
            this.txtKd.Size = new System.Drawing.Size(50, 20);
            this.txtKd.TabIndex = 64;
            this.txtKd.Text = "5";
            this.txtKd.TextChanged += new System.EventHandler(this.txtKd_TextChanged);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label19.Location = new System.Drawing.Point(5, 35);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 19);
            this.label19.TabIndex = 63;
            this.label19.Text = "Ki";
            // 
            // txtKi
            // 
            this.txtKi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtKi.Location = new System.Drawing.Point(76, 34);
            this.txtKi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKi.Name = "txtKi";
            this.txtKi.Size = new System.Drawing.Size(49, 20);
            this.txtKi.TabIndex = 62;
            this.txtKi.Text = "5";
            this.txtKi.TextChanged += new System.EventHandler(this.txtKi_TextChanged);
            // 
            // lblTypeController
            // 
            this.lblTypeController.BackColor = System.Drawing.Color.Plum;
            this.lblTypeController.Location = new System.Drawing.Point(199, 125);
            this.lblTypeController.Name = "lblTypeController";
            this.lblTypeController.Size = new System.Drawing.Size(66, 18);
            this.lblTypeController.TabIndex = 61;
            this.lblTypeController.Text = "Controller";
            this.lblTypeController.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(408, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 60;
            this.label18.Text = "ALARME Status";
            // 
            // btnAlarmeStat
            // 
            this.btnAlarmeStat.BackColor = System.Drawing.Color.Red;
            this.btnAlarmeStat.FlatAppearance.BorderSize = 0;
            this.btnAlarmeStat.Location = new System.Drawing.Point(421, 32);
            this.btnAlarmeStat.Name = "btnAlarmeStat";
            this.btnAlarmeStat.Size = new System.Drawing.Size(57, 48);
            this.btnAlarmeStat.TabIndex = 59;
            this.btnAlarmeStat.Text = "OFF";
            this.btnAlarmeStat.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Temperature_HMI.Properties.Resources.thermometering_page;
            this.pictureBox3.Location = new System.Drawing.Point(630, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // vPbcapt
            // 
            this.vPbcapt.Location = new System.Drawing.Point(579, 19);
            this.vPbcapt.Name = "vPbcapt";
            this.vPbcapt.Size = new System.Drawing.Size(48, 102);
            this.vPbcapt.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(569, 60);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(8, 61);
            this.label14.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Start/Stop Process";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(569, 20);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(8, 40);
            this.label15.TabIndex = 30;
            // 
            // BtnStartProcess
            // 
            this.BtnStartProcess.BackColor = System.Drawing.Color.Lime;
            this.BtnStartProcess.FlatAppearance.BorderSize = 0;
            this.BtnStartProcess.Location = new System.Drawing.Point(63, 37);
            this.BtnStartProcess.Name = "BtnStartProcess";
            this.BtnStartProcess.Size = new System.Drawing.Size(57, 48);
            this.BtnStartProcess.TabIndex = 53;
            this.BtnStartProcess.Text = "Start";
            this.BtnStartProcess.UseVisualStyleBackColor = false;
            this.BtnStartProcess.Click += new System.EventHandler(this.BtnStartProcess_Click);
            // 
            // lblResStatus
            // 
            this.lblResStatus.BackColor = System.Drawing.Color.Red;
            this.lblResStatus.Location = new System.Drawing.Point(320, 103);
            this.lblResStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResStatus.Name = "lblResStatus";
            this.lblResStatus.Size = new System.Drawing.Size(66, 19);
            this.lblResStatus.TabIndex = 52;
            this.lblResStatus.Text = "OFF";
            this.lblResStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(320, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 51;
            this.label9.Text = "RESISTANCE ";
            // 
            // txtTempMoy
            // 
            this.txtTempMoy.Location = new System.Drawing.Point(569, 145);
            this.txtTempMoy.Margin = new System.Windows.Forms.Padding(2);
            this.txtTempMoy.Name = "txtTempMoy";
            this.txtTempMoy.Size = new System.Drawing.Size(81, 20);
            this.txtTempMoy.TabIndex = 50;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label17.Location = new System.Drawing.Point(569, 125);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 19);
            this.label17.TabIndex = 49;
            this.label17.Text = "Temp Moy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Capt 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Capt 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Capt 3";
            // 
            // txtT3
            // 
            this.txtT3.BackColor = System.Drawing.Color.Aqua;
            this.txtT3.Location = new System.Drawing.Point(608, 208);
            this.txtT3.Name = "txtT3";
            this.txtT3.Size = new System.Drawing.Size(43, 20);
            this.txtT3.TabIndex = 45;
            // 
            // txtT2
            // 
            this.txtT2.BackColor = System.Drawing.Color.Aqua;
            this.txtT2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtT2.Location = new System.Drawing.Point(608, 188);
            this.txtT2.Name = "txtT2";
            this.txtT2.Size = new System.Drawing.Size(43, 20);
            this.txtT2.TabIndex = 44;
            // 
            // txtT1
            // 
            this.txtT1.BackColor = System.Drawing.Color.Aqua;
            this.txtT1.Location = new System.Drawing.Point(608, 169);
            this.txtT1.Name = "txtT1";
            this.txtT1.Size = new System.Drawing.Size(44, 20);
            this.txtT1.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(225, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Temp value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(408, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "AD590";
            // 
            // txtSetPointShow
            // 
            this.txtSetPointShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSetPointShow.Location = new System.Drawing.Point(9, 145);
            this.txtSetPointShow.Margin = new System.Windows.Forms.Padding(2);
            this.txtSetPointShow.Name = "txtSetPointShow";
            this.txtSetPointShow.Size = new System.Drawing.Size(34, 20);
            this.txtSetPointShow.TabIndex = 38;
            this.txtSetPointShow.Text = "50";
            this.txtSetPointShow.TextChanged += new System.EventHandler(this.txtSetPointShow_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(9, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "CONSIGNE";
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtError.Location = new System.Drawing.Point(121, 103);
            this.txtError.Margin = new System.Windows.Forms.Padding(2);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(42, 20);
            this.txtError.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(120, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "Error";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Temperature_HMI.Properties.Resources.Process_control_loop;
            this.pictureBox1.Location = new System.Drawing.Point(72, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.chart2);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Location = new System.Drawing.Point(703, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 473);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(16, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Process Output";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Controler Output";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(4, 267);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "PT";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(303, 186);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 37);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "CO";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(293, 166);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // laToolStripMenuItem
            // 
            this.laToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.saveOutputasfileToolStripMenuItem,
            this.saveinputasfileToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.laToolStripMenuItem.Name = "laToolStripMenuItem";
            this.laToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.laToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // saveOutputasfileToolStripMenuItem
            // 
            this.saveOutputasfileToolStripMenuItem.Name = "saveOutputasfileToolStripMenuItem";
            this.saveOutputasfileToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveOutputasfileToolStripMenuItem.Text = "save_Output_as_file";
            this.saveOutputasfileToolStripMenuItem.Click += new System.EventHandler(this.saveOutputasfileToolStripMenuItem_Click);
            // 
            // saveinputasfileToolStripMenuItem
            // 
            this.saveinputasfileToolStripMenuItem.Name = "saveinputasfileToolStripMenuItem";
            this.saveinputasfileToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveinputasfileToolStripMenuItem.Text = "Save_input_as_file";
            this.saveinputasfileToolStripMenuItem.Click += new System.EventHandler(this.saveinputasfileToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portToolStripMenuItem,
            this.alarmeSettingToolStripMenuItem,
            this.controllerSettingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.portToolStripMenuItem.Text = "Port Configuration";
            // 
            // alarmeSettingToolStripMenuItem
            // 
            this.alarmeSettingToolStripMenuItem.Name = "alarmeSettingToolStripMenuItem";
            this.alarmeSettingToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.alarmeSettingToolStripMenuItem.Text = "Alarme Settings";
            // 
            // controllerSettingsToolStripMenuItem
            // 
            this.controllerSettingsToolStripMenuItem.Name = "controllerSettingsToolStripMenuItem";
            this.controllerSettingsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.controllerSettingsToolStripMenuItem.Text = "Controller Settings";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh Alarme Settings";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtLowLimit);
            this.groupBox3.Controls.Add(this.txtHighLimit);
            this.groupBox3.Location = new System.Drawing.Point(12, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 96);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alarme";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Temperature_HMI.Properties.Resources.enzar_logo4;
            this.pictureBox2.Location = new System.Drawing.Point(12, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "High Limit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Low Limit";
            // 
            // txtLowLimit
            // 
            this.txtLowLimit.BackColor = System.Drawing.Color.Aqua;
            this.txtLowLimit.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtLowLimit.Location = new System.Drawing.Point(64, 70);
            this.txtLowLimit.Name = "txtLowLimit";
            this.txtLowLimit.Size = new System.Drawing.Size(83, 20);
            this.txtLowLimit.TabIndex = 50;
            this.txtLowLimit.Text = "30";
            this.txtLowLimit.TextChanged += new System.EventHandler(this.txtLowLimit_TextChanged);
            // 
            // txtHighLimit
            // 
            this.txtHighLimit.BackColor = System.Drawing.Color.Aqua;
            this.txtHighLimit.Location = new System.Drawing.Point(63, 50);
            this.txtHighLimit.Name = "txtHighLimit";
            this.txtHighLimit.Size = new System.Drawing.Size(84, 20);
            this.txtHighLimit.TabIndex = 49;
            this.txtHighLimit.Text = "70";
            this.txtHighLimit.TextChanged += new System.EventHandler(this.txtHighLimit_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnShowAlarm);
            this.groupBox4.Controls.Add(this.btnGestion);
            this.groupBox4.Controls.Add(this.btnGestionParametres);
            this.groupBox4.Controls.Add(this.btnHistory);
            this.groupBox4.Controls.Add(this.btnGraphs);
            this.groupBox4.Location = new System.Drawing.Point(12, 351);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(685, 60);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "bare d\'outils";
            // 
            // btnShowAlarm
            // 
            this.btnShowAlarm.Location = new System.Drawing.Point(530, 18);
            this.btnShowAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAlarm.Name = "btnShowAlarm";
            this.btnShowAlarm.Size = new System.Drawing.Size(89, 29);
            this.btnShowAlarm.TabIndex = 11;
            this.btnShowAlarm.Text = "ALARMES";
            this.btnShowAlarm.UseVisualStyleBackColor = true;
            this.btnShowAlarm.Click += new System.EventHandler(this.btnShowAlarm_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.Location = new System.Drawing.Point(368, 18);
            this.btnGestion.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(158, 29);
            this.btnGestion.TabIndex = 10;
            this.btnGestion.Text = "Gestion de base des données";
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // btnGestionParametres
            // 
            this.btnGestionParametres.Location = new System.Drawing.Point(230, 18);
            this.btnGestionParametres.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionParametres.Name = "btnGestionParametres";
            this.btnGestionParametres.Size = new System.Drawing.Size(134, 29);
            this.btnGestionParametres.TabIndex = 8;
            this.btnGestionParametres.Text = "Gestion des parametres";
            this.btnGestionParametres.UseVisualStyleBackColor = true;
            this.btnGestionParametres.Click += new System.EventHandler(this.btnGestionParametres_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(137, 18);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(89, 29);
            this.btnHistory.TabIndex = 7;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnGraphs
            // 
            this.btnGraphs.Location = new System.Drawing.Point(44, 18);
            this.btnGraphs.Margin = new System.Windows.Forms.Padding(2);
            this.btnGraphs.Name = "btnGraphs";
            this.btnGraphs.Size = new System.Drawing.Size(89, 29);
            this.btnGraphs.TabIndex = 6;
            this.btnGraphs.Text = "GRAPHES";
            this.btnGraphs.UseVisualStyleBackColor = true;
            this.btnGraphs.Click += new System.EventHandler(this.btnGraphs_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPortName);
            this.groupBox6.Controls.Add(this.rbDisconnect);
            this.groupBox6.Controls.Add(this.rbConnect);
            this.groupBox6.Location = new System.Drawing.Point(180, 416);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(154, 90);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "COM Port";
            // 
            // txtPortName
            // 
            this.txtPortName.Location = new System.Drawing.Point(14, 18);
            this.txtPortName.Name = "txtPortName";
            this.txtPortName.Size = new System.Drawing.Size(125, 20);
            this.txtPortName.TabIndex = 17;
            // 
            // rbDisconnect
            // 
            this.rbDisconnect.AutoSize = true;
            this.rbDisconnect.Checked = true;
            this.rbDisconnect.Location = new System.Drawing.Point(18, 63);
            this.rbDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.rbDisconnect.Name = "rbDisconnect";
            this.rbDisconnect.Size = new System.Drawing.Size(79, 17);
            this.rbDisconnect.TabIndex = 16;
            this.rbDisconnect.TabStop = true;
            this.rbDisconnect.Text = "Disconnect";
            this.rbDisconnect.UseVisualStyleBackColor = true;
            this.rbDisconnect.CheckedChanged += new System.EventHandler(this.rbDisconnect_CheckedChanged);
            // 
            // rbConnect
            // 
            this.rbConnect.AutoSize = true;
            this.rbConnect.Location = new System.Drawing.Point(18, 41);
            this.rbConnect.Margin = new System.Windows.Forms.Padding(2);
            this.rbConnect.Name = "rbConnect";
            this.rbConnect.Size = new System.Drawing.Size(65, 17);
            this.rbConnect.TabIndex = 15;
            this.rbConnect.Text = "Connect";
            this.rbConnect.UseVisualStyleBackColor = true;
            this.rbConnect.CheckedChanged += new System.EventHandler(this.rbConnect_CheckedChanged_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbPID);
            this.groupBox5.Controls.Add(this.rbHysterisis);
            this.groupBox5.Controls.Add(this.rbTor);
            this.groupBox5.Location = new System.Drawing.Point(350, 416);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(154, 90);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Choix de regulator";
            // 
            // rbPID
            // 
            this.rbPID.AutoSize = true;
            this.rbPID.Location = new System.Drawing.Point(14, 65);
            this.rbPID.Margin = new System.Windows.Forms.Padding(2);
            this.rbPID.Name = "rbPID";
            this.rbPID.Size = new System.Drawing.Size(43, 17);
            this.rbPID.TabIndex = 17;
            this.rbPID.Text = "PID";
            this.rbPID.UseVisualStyleBackColor = true;
            this.rbPID.CheckedChanged += new System.EventHandler(this.rbPID_CheckedChanged);
            // 
            // rbHysterisis
            // 
            this.rbHysterisis.AutoSize = true;
            this.rbHysterisis.Location = new System.Drawing.Point(14, 43);
            this.rbHysterisis.Margin = new System.Windows.Forms.Padding(2);
            this.rbHysterisis.Name = "rbHysterisis";
            this.rbHysterisis.Size = new System.Drawing.Size(76, 17);
            this.rbHysterisis.TabIndex = 16;
            this.rbHysterisis.Text = "a hysterisis";
            this.rbHysterisis.UseVisualStyleBackColor = true;
            this.rbHysterisis.CheckedChanged += new System.EventHandler(this.rbHysterisis_CheckedChanged);
            // 
            // rbTor
            // 
            this.rbTor.AutoSize = true;
            this.rbTor.Checked = true;
            this.rbTor.Location = new System.Drawing.Point(14, 21);
            this.rbTor.Margin = new System.Windows.Forms.Padding(2);
            this.rbTor.Name = "rbTor";
            this.rbTor.Size = new System.Drawing.Size(48, 17);
            this.rbTor.TabIndex = 15;
            this.rbTor.TabStop = true;
            this.rbTor.Text = "TOR";
            this.rbTor.UseVisualStyleBackColor = true;
            this.rbTor.CheckedChanged += new System.EventHandler(this.rbTor_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbActionPID);
            this.groupBox7.Controls.Add(this.rbActionPI);
            this.groupBox7.Controls.Add(this.rbActionP);
            this.groupBox7.Location = new System.Drawing.Point(510, 416);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(154, 90);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Selectionner les parametres";
            // 
            // rbActionPID
            // 
            this.rbActionPID.AutoSize = true;
            this.rbActionPID.Location = new System.Drawing.Point(14, 65);
            this.rbActionPID.Margin = new System.Windows.Forms.Padding(2);
            this.rbActionPID.Name = "rbActionPID";
            this.rbActionPID.Size = new System.Drawing.Size(43, 17);
            this.rbActionPID.TabIndex = 17;
            this.rbActionPID.Text = "PID";
            this.rbActionPID.UseVisualStyleBackColor = true;
            this.rbActionPID.CheckedChanged += new System.EventHandler(this.rbActionPID_CheckedChanged);
            // 
            // rbActionPI
            // 
            this.rbActionPI.AutoSize = true;
            this.rbActionPI.Location = new System.Drawing.Point(14, 43);
            this.rbActionPI.Margin = new System.Windows.Forms.Padding(2);
            this.rbActionPI.Name = "rbActionPI";
            this.rbActionPI.Size = new System.Drawing.Size(35, 17);
            this.rbActionPI.TabIndex = 16;
            this.rbActionPI.Text = "PI";
            this.rbActionPI.UseVisualStyleBackColor = true;
            this.rbActionPI.CheckedChanged += new System.EventHandler(this.rbActionPI_CheckedChanged);
            // 
            // rbActionP
            // 
            this.rbActionP.AutoSize = true;
            this.rbActionP.Checked = true;
            this.rbActionP.Location = new System.Drawing.Point(14, 21);
            this.rbActionP.Margin = new System.Windows.Forms.Padding(2);
            this.rbActionP.Name = "rbActionP";
            this.rbActionP.Size = new System.Drawing.Size(32, 17);
            this.rbActionP.TabIndex = 15;
            this.rbActionP.TabStop = true;
            this.rbActionP.Text = "P";
            this.rbActionP.UseVisualStyleBackColor = true;
            this.rbActionP.CheckedChanged += new System.EventHandler(this.rbActionP_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 514);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpHystersis.ResumeLayout(false);
            this.grpHystersis.PerformLayout();
            this.grpPID.ResumeLayout(false);
            this.grpPID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTempMoy;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtT3;
        private System.Windows.Forms.TextBox txtT2;
        private System.Windows.Forms.TextBox txtT1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSetPointShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private roundButton BtnStartProcess;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLowLimit;
        private System.Windows.Forms.TextBox txtHighLimit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnShowAlarm;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnGestionParametres;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnGraphs;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtPortName;
        private System.Windows.Forms.RadioButton rbDisconnect;
        private System.Windows.Forms.RadioButton rbConnect;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox3;
        private VerticalProgressBar vPbcapt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbHysterisis;
        private System.Windows.Forms.RadioButton rbTor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDeadBand;
        private System.Windows.Forms.RadioButton rbPID;
        private System.Windows.Forms.Label label18;
        private roundButton btnAlarmeStat;
        private System.Windows.Forms.GroupBox grpHystersis;
        private System.Windows.Forms.GroupBox grpPID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtKp;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtKd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtKi;
        private System.Windows.Forms.Label lblTypeController;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbActionPID;
        private System.Windows.Forms.RadioButton rbActionPI;
        private System.Windows.Forms.RadioButton rbActionP;
        private System.Windows.Forms.TextBox txtCommande;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTypeReg;
        private System.Windows.Forms.ToolStripMenuItem saveOutputasfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveinputasfileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alarmeSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controllerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
    }
}


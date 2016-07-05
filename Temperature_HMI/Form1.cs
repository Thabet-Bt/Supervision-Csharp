using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace Temperature_HMI
{
    public partial class Form1 : Form
    {
        #region  //Declaration
        PortConfig portConf = new PortConfig();
        Engineer_Gestion param_Gestion = new Engineer_Gestion();
        Courbes graphes = new Courbes();
        Alarm alarme = new Alarm();
        SqlOp SqlMethod = new SqlOp();
        //Regulation reg = new Regulation();
        delegate void SetTextCallback(string text, string text2, string text3);
        //private Thread readThread = null;
        //global variable
        double moyTemp;
        double Error;
        double Td = 50;
        double HighLimit = 70;
        double LowLimit = 30;
        //string to store data  
        public string rx1, rx2, rx3;
        public List<string> port_name = new List<string>();
        //creat variable state to indicate which controller is used
        //0  ====  TOR
        //1  ====  hysterisis
        //2  ====  PID
        private int state_Reg = 0;
        string state_Reg_str="Tor";
        private double Deadband = 5;
        //creat feilds for methods that calculate PID parametre
        double Kp = 0;
        double Ki = 0;
        double Kd = 0;
        double prevError = 0;
        double Ucommande = 0;
        bool action_I = false;
        bool action_D = false;
        private double int_e = 0;
        private double d_e = 0;

        string data = string.Empty;
        //bool read_in_use = false;
        string signal_com;
        private bool process_state=false;
        #endregion

        SerialClient port;
        int storedResponses;
        string received_data;
        string path_file_output;
        string path_file_input;
        
      
        public Form1()
        {
            InitializeComponent();
            //port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            //port.ReadBufferSize = 1024;
            //port.ReceivedBytesThreshold = 14;
        }

        public void Read_Data(string data)
        {
           
            try
            {
               bool done = false;
                while (!done)
                {
                    // check for a complete message.
                    int start = data.IndexOf(":");
                    int end = data.IndexOf(";");
                    if (start > -1 && end > -1 && start < end)
                    {
                        // A complete packet is in the buffer.
                        string packet = data.Substring(start + 1, (end - start) - 1);
                        // remove the packet from the buffer.                    
                        data = data.Remove(start, (end - start) + 1);
                        // split the packet up in to it's parameters.
                        string[] parameters = packet.Split('*');
                        
                            rx1 = parameters[0];
                       
                            rx2 = parameters[1];
                       
                            rx3 = parameters[2];
                        
                        ////Show value of each temperature sensor on TextBox
                        SetText(rx1, rx2, rx3);
                           
                    }
                    else
                        done = true;
                }

            }
            catch (Exception)
            {
                
            }
        }
       //receive data from serialPort
        private void receiveHandler(object sender, DataStreamEventArgs e)
        {
            storedResponses++;
            received_data=e.Response.ToString();
            
        }
        //Connect Method
        public void Connect(string NamePort, int baudrate)
        {
            try
            {
                port = new SerialClient(NamePort, baudrate);
                port.OnReceiving += new EventHandler<DataStreamEventArgs>(receiveHandler);
                if (!port.OpenConn())
                {
                    MessageBox.Show(this, "The Port Cannot Be Opened", "Serial Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    timer1.Enabled = true;
                    //port is opened
                    //button1.Text = "Connected";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                port.CloseConn();
                port.OnReceiving -= new EventHandler<DataStreamEventArgs>(receiveHandler);
                port.Dispose();
            }
            catch
            {
                //MessageBox.Show("Disconnected  Failed");
            }
            
        }

        public void Find_portName()
        {
            //Find All alvaible port names on the computer
            string[] portNames = SerialPort.GetPortNames();
            for (int i = 0; i <= portNames.Length - 1; i++)
            {
                port_name.Add(portNames[i]);
            }

        }
       
        private void SetText(string text, string text2, string text3)
        {

            if (text != string.Empty && text2 != string.Empty && text3 != string.Empty)
            {

                double t1 = Convert.ToDouble(text);
                double t2 = Convert.ToDouble(text2);
                double t3 = Convert.ToDouble(text3);
                moyTemp = (t1 + t2 + t3) / 3;
                moyTemp = (moyTemp * 100) / 255;
                Error = Math.Abs(Td - moyTemp);

                //method to show 3 value of temperature on the diffrent control (textboxs chart).
                Affichage_Parametres(Error, moyTemp, text, text2, text3);
                insert_dataToDb(moyTemp);

            }  
               
                if (state_Reg == 0)
                {
                    //SendCommand(reg.Reg_Tor(moyTemp, Td));
                    Reg_Tor();
                }
                else if (state_Reg == 1)
                {
                    //SendCommand(reg.Reg_hysterisis(moyTemp,Deadband,Td));
                    Reg_hysterisis();
                }
                else if (state_Reg == 2)
                {
                    Reg_PID(action_I, action_D, Error);
                }
        }

        private void Affichage_Parametres(double Error, double moyTemp, string text, string text2, string text3)
        {
            GestionAlarm();
            this.txtT1.Text = text;
            this.txtT2.Text = text2;
            this.txtT3.Text = text3;
            this.txtError.Text = Error.ToString();
            this.txtTempMoy.Text = moyTemp.ToString();
            this.vPbcapt.Value = (int)moyTemp;
            this.chart2.Series["PT"].Points.AddY(moyTemp);
            graphes.temperature_courbe_trace(moyTemp);
            
        }

        private void GestionAlarm()
        {
            if (moyTemp < LowLimit || moyTemp > HighLimit) 
            {
                btnAlarmeStat.Text = "On";
                btnAlarmeStat.BackColor = Color.Orange;
                alarme.lblAlarmeStatus.Text = "On";
                alarme.lblAlarmeStatus.BackColor = Color.Orange;
                SqlMethod.AddEvent("Alarme", "Alarm", "Admin", "Alarme is On");
            }
            else
            {
                btnAlarmeStat.Text = "Off";
                btnAlarmeStat.BackColor = Color.Red;
                alarme.lblAlarmeStatus.Text = "Off";
                alarme.lblAlarmeStatus.BackColor = Color.Red;
                SqlMethod.AddEvent("Alarme", "Alarm", "Admin", "Alarme is Off");
            }
        }

        private void Reg_hysterisis()
        {
            if (moyTemp < (Td - Deadband))
            {
                //send_Data("o");
                SendCommand("*255:;");
                txtCommande.Text = "5V";
                lblResStatus.Text = "ON";
                lblResStatus.BackColor = Color.Green;
                this.chart1.Series["CO"].Points.AddY(50);
                graphes.Control_courbe_trace(50);
                SqlMethod.AddParam(Td.ToString(), Error.ToString(), "5");
            }
            else if (moyTemp > (Td + Deadband))
            {
                SendCommand("*000:;");
                txtCommande.Text = "0V";
                lblResStatus.Text = "OFF";
                lblResStatus.BackColor = Color.Red;
                //send_Data("f");
                this.chart1.Series["CO"].Points.AddY(0);
                graphes.Control_courbe_trace(0);
                SqlMethod.AddParam(Td.ToString(), Error.ToString(), "0");

            }
        }

        public void Reg_Tor()
        {
            if (moyTemp < Td)
            {

                SendCommand("*255:;");
                txtCommande.Text = "10V";
                //File.WriteAllText(path_file_input, "10");
                SqlMethod.AddParam(Td.ToString(), Error.ToString(), "5");
                this.chart1.Series["CO"].Points.AddY(50);
                graphes.Control_courbe_trace(50);
            }
            else
            {
               SendCommand("*000:;");
               txtCommande.Text = "0V";
               //File.WriteAllText(path_file_input, "0");
                this.chart1.Series["CO"].Points.AddY(0);
                graphes.Control_courbe_trace(0);
                SqlMethod.AddParam(Td.ToString(), Error.ToString(), "0");


            }
        }
 

        public void Reg_Param_Reset()
        {
            int_e = 0;
            d_e = 0;
            prevError = 0;
        }

        public void Reg_PID(bool actionI, bool actionD, double error)
        {
            if (actionI)
            {
                int_e = int_e + error;     // calcul de l'intégrale sur l'écart
            }
            else int_e = 0;

            if (actionD)
            {
                // calcul de la dérivée de l'écart
                d_e = error - prevError;
            }
            else d_e = 0;

            if (actionD)            // PID
            {
                Ucommande = Kp * error + Ki * int_e + Kd * d_e;
            }
            else if (actionI)   //PI
            {
                Ucommande = Kp * error + Ki * int_e;
            }
            else                    // P seul
            {
                Ucommande = Kp * error;
            }

            if (Ucommande > 100) Ucommande = 100;     // écrètage +
            if (Ucommande < 0) Ucommande = 0;       // écrètage -
            prevError = error;     // pour le prochain cycle
            this.chart1.Series["CO"].Points.AddY(Ucommande);
            graphes.Control_courbe_trace(Ucommande);
            //send_Data("a");
            //Thread.Sleep(1000);
            Ucommande = Math.Ceiling(Ucommande);
            double Ucommande2 = Ucommande / 10;
            Ucommande = (Ucommande * 255) / 100;
            if ((Ucommande < 100) && (Ucommande > 10))
            {
                signal_com = "*0" + Ucommande + ":;";
                //label22.Text = signal_com;
            }
            else if (Ucommande < 10)
            {
                signal_com = "*00" + Ucommande + ":;";
            }
            else
            {
                signal_com = "*" + Ucommande + ":;";
            }
            //string signal_com =Ucommande + "OK";
            
            SendCommand(signal_com);
            
            SqlMethod.AddParam(Td.ToString(), Error.ToString(), Ucommande2.ToString());
           
        }
        public void SendCommand(string commande)
        {
            port.Transmit(commande);
        }

        public void show_HistoryFrm()
        {
            History history = new History();
            history.ShowDialog();
        }

        #region //Connect /disconnect SerialPort
        private void rbConnect_CheckedChanged_1(object sender, EventArgs e)
        {
            Connect(portConf.port_Name, portConf.baud);
            SqlMethod.AddEvent("Connect", "SerialCom", "Admin", "Connect Process with PC");

        }

        private void rbDisconnect_CheckedChanged(object sender, EventArgs e)
        {
            Disconnect();
            SqlMethod.AddEvent("DisConnect", "SerialCom", "Admin", "DisConnect Process from PC");

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            portConf.ShowDialog();
            txtPortName.Text = portConf.port_Name;
        }

        private void txtDeadBand_TextChanged(object sender, EventArgs e)
        {
            if (!(txtDeadBand.Text == string.Empty))
            {
                Deadband = Convert.ToDouble(txtDeadBand.Text);
            }
        }

        #region   //Select Controller
        private void rbHysterisis_CheckedChanged(object sender, EventArgs e)
        {
            //changer Regulateur a l'etat de l'hysterisis
            state_Reg = 1;
            grpHystersis.Visible = true;
            grpPID.Visible = false;
            lblTypeReg.Text = "a hysterisis";
            SqlMethod.AddEvent("Regulateur a hysterisis", "Regulateur", "Admin", "choix du regulateur ON-OFF  a hysterisis");

        }

        private void rbTor_CheckedChanged(object sender, EventArgs e)
        {
            //set the controller at TOR
            state_Reg = 0;
            grpHystersis.Visible = false;
            grpPID.Visible = false;
            lblTypeReg.Text = "TOR";
            SqlMethod.AddEvent("Regulateur TOR", "Regulateur", "Admin", "choix du regulateur ON-OFF");

        }

        private void rbPID_CheckedChanged(object sender, EventArgs e)
        {
            //set the PID Controller
            state_Reg = 2;
            Reg_Param_Reset();
            grpHystersis.Visible = false;
            grpPID.Visible = true;
            lblTypeReg.Text = "PI";
            SqlMethod.AddEvent("Regulateur PI", "Regulateur", "Admin", "choix du regulateur PI");

        }
        #endregion

        private void txtSetPointShow_TextChanged(object sender, EventArgs e)
        {
            if (!(txtSetPointShow.Text == string.Empty))
            {
                Td = Convert.ToDouble(txtSetPointShow.Text);
                SqlMethod.AddEvent("Set Point Changed", "SetPoint", "Admin", "Set point changed to Td= "+Td.ToString()+"");
            }
        }

        #region   //Select type of PID controller
        private void rbActionP_CheckedChanged(object sender, EventArgs e)
        {
            //Set PID controller as Proportionnel P
            action_D = false;
            action_I = false;
        }

        private void rbActionPI_CheckedChanged(object sender, EventArgs e)
        {
            //set the controller as Proportionnel Integrale PI
            action_I = true;
            action_D = false;
        }

        private void rbActionPID_CheckedChanged(object sender, EventArgs e)
        {
            //Set the controller as Proportionnel Integrale Derivate PID
            action_D = true;
            action_I = true;
        }
        #endregion

        private void txtKp_TextChanged(object sender, EventArgs e)
        {
            if (!(txtKp.Text == string.Empty))
            {
                Kp = Convert.ToDouble(txtKp.Text);
            }
        }

        private void txtKi_TextChanged(object sender, EventArgs e)
        {
            if (!(txtKi.Text == string.Empty))
            {
                Ki = Convert.ToDouble(txtKi.Text);
            }
        }

        private void txtKd_TextChanged(object sender, EventArgs e)
        {
            if (!(txtKd.Text == string.Empty))
            {
                Kd = Convert.ToDouble(txtKd.Text);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.ShowDialog();
        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
            
            graphes.ShowDialog();
        }

        private void btnShowAlarm_Click(object sender, EventArgs e)
        {
            
            alarme.Show();
        }

        private void txtHighLimit_TextChanged(object sender, EventArgs e)
        {
            if(txtHighLimit.Text!=null || txtHighLimit.Text!=string.Empty)
            {
                HighLimit = Convert.ToDouble(txtHighLimit.Text);
            }
        }

        private void txtLowLimit_TextChanged(object sender, EventArgs e)
        {
            if (txtLowLimit.Text != null || txtLowLimit.Text != string.Empty)
            {
                LowLimit = Convert.ToDouble(txtLowLimit.Text);
            }
        }

        private void BtnStartProcess_Click(object sender, EventArgs e)
        {
            if (process_state == false)
            {
                process_state = true;
                timer1.Enabled = true;
                BtnStartProcess.Text = "Stop";
                BtnStartProcess.BackColor = Color.Red;
                SqlMethod.AddEvent("Start Process", "Process", "Admin", "Process is Started");
            }
            else if (process_state == true)
            {
                process_state = false;
                timer1.Enabled = false;
                BtnStartProcess.Text = "Start";
                BtnStartProcess.BackColor = Color.Green;
                SqlMethod.AddEvent("Stop Process", "Process", "Admin", "Process is Stoped");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Read_Data(received_data);
        }

        private void saveOutputasfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files | *.txt;";
            openFileDialog1.InitialDirectory = @"C:\Users\madricano\Desktop\FileMFE";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path_file_output = openFileDialog1.FileName;
                
            }
        }

        private void saveinputasfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files | *.txt;";
            openFileDialog1.InitialDirectory = @"C:\Users\madricano\Desktop\FileMFE";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path_file_input = openFileDialog1.FileName;
                
            }
        }

        private void btnGestionParametres_Click(object sender, EventArgs e)
        {
            param_Gestion.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Td = param_Gestion.setPoint;
            txtSetPointShow.Text = Td.ToString();
            state_Reg = param_Gestion.controller_type;
            if (state_Reg == 0)
            {
                rbTor.Checked=true;
            }
            else if (state_Reg == 1)
            {
                rbHysterisis.Checked = true;
            }
            else
            {
                rbPID.Checked = true;
            }
            if (param_Gestion.PIDControllerType == 0)
            {
                rbActionP.Checked = true;
            }
            else if (param_Gestion.PIDControllerType == 1)
            {
                rbActionPI.Checked = true;
            }
            else if (param_Gestion.PIDControllerType == 2)
            {
                rbActionPID.Checked = true;
            }
            Deadband = param_Gestion.dead_band;
            txtDeadBand.Text = Deadband.ToString();
       }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            param_Gestion.Show();
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HighLimit = alarme.highLimit;
            LowLimit = alarme.lowLimit;
            
        }

        private void insert_dataToDb(double TempActual)
        {
            DateTime dt=DateTime.Now;
            string Query;
            if (state_Reg == 0)
            {
                state_Reg_str="Tor";
            }
            else if (state_Reg == 1)
            {
                state_Reg_str="A hysterisis";
            }
            else
            {
                state_Reg_str="PI";
            }
            //"INSERT into Events(ID,Event,Date,Place) values('" + TxteventID.Text + "','" + TxtEvent.Text + "','" + dptevent.Value + "','" + TxtEventPlace.Text + "')";
            //set time to dateTime variable
            //dt = DateTime.Now;
            //Added 3Temp value to Database
            Query = "INSERT into TempValue(Temp,RegType) values('" + TempActual.ToString() + "','"+  state_Reg_str +"')";

            SqlMethod.Insert(Query);

        }

    }
}

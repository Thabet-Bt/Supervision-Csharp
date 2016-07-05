using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_HMI
{
    public partial class Engineer_Gestion : Form
    {
        SqlConnection sc = new SqlConnection(@"Server=.\SQLEXPRESS;DataBase=MfeDB;Integrated Security=true;");
        public SqlCommand cmd;
        public bool controller_state=false;
        public double setPoint;
        public int PIDControllerType=0;
        public double kp = 0;
        public double ki = 0;
        public double kd = 0;
        public double dead_band = 5;
        public int controller_type=0;

        public Engineer_Gestion()
        {
            InitializeComponent();
        }

        private void txtKd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Backup Files (*.Bak) |*.bak";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                cmd = new SqlCommand("Backup DataBase MyDatabase To Disk='" + sf.FileName + "'", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                sc.Close();

            }
        }

        private void rBAuto_CheckedChanged(object sender, EventArgs e)
        {
            controller_state = true;//true===auto
        }

        private void rBManuel_CheckedChanged(object sender, EventArgs e)
        {
            controller_state = false;//false===manuel
        }

        private void txtConsigne1_TextChanged(object sender, EventArgs e)
        {
            if (txtConsigne1.Text != string.Empty)
            {
                setPoint = Convert.ToDouble(txtConsigne1.Text);
            }
        }

        private void rBP_CheckedChanged(object sender, EventArgs e)
        {
            PIDControllerType = 0;    //0 ==== P
        }

        private void rBPI_CheckedChanged(object sender, EventArgs e)
        {
            PIDControllerType = 1;   //1 ==== PI
        }

        private void rBPID_CheckedChanged(object sender, EventArgs e)
        {
            PIDControllerType = 2;  //2 ==== PID
        }

        private void btnValiderPID_Click(object sender, EventArgs e)
        {
            if (txtKd.Text != string.Empty && txtKp.Text != string.Empty && txtKi.Text != string.Empty)
            {
                kp = Convert.ToDouble(txtKp.Text);
                ki = Convert.ToDouble(txtKi.Text);
                kd = Convert.ToDouble(txtKd.Text);
            }
        }

        private void btnValiderHyster_Click(object sender, EventArgs e)
        {
            if (txtDeadBand.Text != string.Empty)
            {
                dead_band = Convert.ToDouble(txtDeadBand.Text);
            }
        }

        private void btnValiderAutoManuel_Click(object sender, EventArgs e)
        {
            if (txtConsigne1.Text != string.Empty)
            {
                setPoint = Convert.ToDouble(txtConsigne1.Text);
                if (rBAuto.Checked == true)
                {
                    //Automatic Mode
                    controller_state = true;
                }
                else
                {
                    //Manuel Mode
                    controller_state = false;
                }
            }
        }

        private void btnValiderChoixReg_Click(object sender, EventArgs e)
        {
            if (rbTor.Checked == true)
            {
                //ON-OFF Controller
                controller_type = 0;
            }
            else if(rbHysterisis.Checked==true)
            {
                //ON-OFF a hysterisis
                controller_type = 1;
            }
            else
            {
                //PID Controller
                controller_type = 2;
            }
        }
    }
}

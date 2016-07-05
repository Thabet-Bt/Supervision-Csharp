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
    public partial class LoginFrm : Form
    {
        SqlConnection sc = new SqlConnection(@"Server=.\SQLEXPRESS;DataBase=MfeDB;Integrated Security=true;");
        SqlDataReader dr;
        SqlDataAdapter Da = new SqlDataAdapter();
        SqlCommand cmd;
        SqlCommand cmd2;
        DataTable dt = new DataTable();
        private bool state_return=true;
        public LoginFrm()
        {
            InitializeComponent();
        }

       

        public void AddEvent(string Event, string Type, string Operator, string Description)
        {
            try
            {
                DateTime dt = DateTime.Now;
                cmd2 = new SqlCommand("INSERT into Events(Event,Type,Operator,Description,Time,Date) values('" + Event + "','" + Type + "','" + Operator + "','" + Description + "', '" + dt.ToString("HH:mm:ss") + "','" + dt.Date + "')", sc);
                if (sc.State == ConnectionState.Closed)
                {
                    sc.Open();
                }
                 dr.Close();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("add succesful");
                sc.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Some errors affected ! " + ex.Message);
            }
            finally
            {
                sc.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String query = "select * from login_tb where Username = '" + txtUsername.Text + "'and Password = '" + txtPassword.Text + "'";
            if (!(txtUsername.Text == string.Empty) && !(txtPassword.Text == string.Empty))
            {
                cmd = new SqlCommand(query, sc);

                sc.Open();
                dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("username and password is correct");
                    MessageBox.Show("login succesfully");
                    
                    AddEvent("login succesfully", "login", txtUsername.Text, "username and password is correct");
                    state_return = true;
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate username and password", "login page");
                   AddEvent("login Failed", "login", txtUsername.Text, "Duplicate username and password");
                   state_return = false;
                }
                else
                {
                    MessageBox.Show(" username and password incorrect", "login page");
                   AddEvent("login Failed", "login", txtUsername.Text, "username and password is incorrect");
                   state_return = false;
                }
                sc.Close();

            }
            else
            {
                MessageBox.Show("username or password not correct");
                AddEvent("login Failed", "login", txtUsername.Text, "username and password is incorrect");
                state_return = false;
            }
            if (state_return == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }
    }
}

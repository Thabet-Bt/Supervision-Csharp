using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_HMI
{
    class SqlOp
    {
        public SqlOp()
        {
            dt = new DataTable();
        }

        //Methods
        public void BackupMethod(string filename)
        {
                cmd = new SqlCommand("Backup DataBase MyDatabase To Disk='" + filename + "'", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                sc.Close();
        }
        //Select Method
        public void SelectFromDB(string query,bool State)
        {
            try
            {
                cmd = new SqlCommand(query, sc);
                Da = new SqlDataAdapter(cmd);
                if (dt != null)
                {
                    dt.Clear();
                }
                Da.Fill(dt);
                if (dt != null && State==true)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        type.Add(row["Type"].ToString());
                        Operator.Add(row["Operator"].ToString());
                    }
                    //remove duplicate items
                    type = type.Distinct().ToList();
                    Operator = Operator.Distinct().ToList();
                }
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
        //load Data from database
        public void load_Data()
        {
            try
            {
                sc.Open();
                cmd = new SqlCommand("SELECT Temp FROM TempValue", sc);
                dr2 = cmd.ExecuteReader();
                while (dr2.Read())
                {
                    //temp.Add(dr2.GetInt32(0).ToString());
                    temp.Add(dr2.GetString(0));
                    //chart1.Series["Temperature"].Points.AddY(dr2.GetDouble(0));
                }
                sc.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sc.Close();
            }
        }

        public void Insert(string query)
        {
            try
            {
                //Insert Query
                //cmd = new SqlCommand("INSERT into "+Table+"(id,Value,Time,Date) values('" + TxtmemID.Text + "', '" + TxtMemName.Text + "','" + TxtMemTel.Text + "','" + TxtMemGrd.Text + "')", sc);
                // cmd = new SqlCommand("INSERT into temp(Value1,Value2,Value3,Time,Date) values(123,123,124,1120,11/02/2015)", sc);


                cmd = new SqlCommand(query, sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("added succesful");

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

        public void AddEvent(string Event, string Type, string Operator, string Description)
        {
            try
            {
                DateTime dt = DateTime.Now;
                string Query="INSERT into Events(Event,Type,Operator,Description) values('" + Event + "','" + Type + "','" + Operator + "','" + Description + "')";
                Insert(Query);
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

        public void AddParam(string SetPoint, string Error, string Commande)
        {
            try
            {
                DateTime dt = DateTime.Now;
                string Query = "INSERT into Process_parametres(SetPoint,Error,Commande) values('" + SetPoint + "','" + Error + "','" + Commande + "')";
                Insert(Query);
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
   
        
        //global variable
        public  List<string> type = new List<string>();
        public  List<string> Operator = new List<string>();
        public List<string> temp = new List<string>();
        //creat object from sqlcommand
        SqlCommand cmd;
        //creat connection 
        SqlConnection sc = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=MfeDB;Integrated Security=true");
        public DataTable dt;
        SqlDataAdapter Da;
        SqlDataReader dr2;
        //creat dataSource binding
        //public BindingSource bSource;



    }
}

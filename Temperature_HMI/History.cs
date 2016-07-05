using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_HMI
{
    public partial class History : Form
    {
        SqlOp sqlOperation;
        
        private string path_file;
        public History()
        {
            InitializeComponent();
            sqlOperation = new SqlOp();
            string Query = "SELECT * FROM Events";
            //true=====select data from database and assign it in 2 lists: type & operator
            sqlOperation.SelectFromDB(Query,true);
            cbType.DataSource = sqlOperation.type;
            cbOperator.DataSource = sqlOperation.Operator;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string Query;
            if (cbFilter.SelectedIndex == 0)
            {
                Query = "SELECT * FROM Events WHERE Type='" + cbType.Text + "'";
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                Query = "SELECT * FROM Events WHERE Operator='" + cbOperator.Text + "'";
            }
            else
            {
                Query = "SELECT * FROM Events WHERE Date='" + dateTimePicker1.Value + "'";
            }
            //false====Select data from database and not assign it in lists
            sqlOperation.SelectFromDB(Query, false);
            dataGridView1.DataSource = sqlOperation.dt;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files | *.txt;";
            saveFileDialog1.InitialDirectory = @"C:\Users\madricano\Desktop\FileMFE";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path_file = saveFileDialog1.FileName;
                File.WriteAllText(path_file, richTextBox1.Text);
            }
        }
        private void load_chart()
        {
            sqlOperation.load_Data();
            foreach (string temp in sqlOperation.temp)
                    {
                        chart1.Series["Temp"].Points.AddY(Convert.ToDouble(temp));
                        richTextBox1.AppendText("\n"+temp);
                    }
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            load_chart();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_HMI
{
    public partial class Alarm : Form
    {
        SqlOp sqlOperation = new SqlOp();
        public double highLimit=60;
        public double lowLimit=30;
        public Alarm()
        {
            InitializeComponent();
            string Query = "SELECT * FROM Events WHERE Type='Alarm'";
            sqlOperation.SelectFromDB(Query, true);
            cbType.DataSource = sqlOperation.type;
            cbOperator.DataSource = sqlOperation.Operator;
            dataGridView1.DataSource = sqlOperation.dt;


        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnValderLimite_Click(object sender, EventArgs e)
        {
            if (txtHighLimit.Text != null && txtLowLimit.Text != null)
            {
                highLimit=Convert.ToDouble(txtHighLimit.Text);
                lowLimit = Convert.ToDouble(txtLowLimit.Text);
            }
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
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

    }
}

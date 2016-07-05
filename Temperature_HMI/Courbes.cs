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
    public partial class Courbes : Form
    {
        public Courbes()
        {
            InitializeComponent();
        }

        private void Courbes_Load(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    chart1.Series["Temp"].Color=colorDialog1.Color;
                }
                else
                {
                    chart2.Series["Control"].Color= colorDialog1.Color;
                }
            }
        }

      

        public void temperature_courbe_trace(double Temp)
        {
            this.chart1.Series["Temp"].Points.AddY(Temp);
        }
        public void Control_courbe_trace(double Commande)
        {
            this.chart2.Series["Control"].Points.AddY(Commande);
        }

        private void btnGridOff_Click(object sender, EventArgs e)
        {
            this.chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            this.chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
        }

        private void btnGridOn_Click(object sender, EventArgs e)
        {
            this.chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = true;
            this.chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = true;
        }

    }
}

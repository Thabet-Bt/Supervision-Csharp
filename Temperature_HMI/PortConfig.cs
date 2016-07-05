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
    public partial class PortConfig : Form
    {
        public string port_Name;
        public int baud;
        public PortConfig()
        {
            InitializeComponent();

        }

        private void PortConfig_Load(object sender, EventArgs e)
        {
            Form1 serialport = new Form1();
            serialport.Find_portName();
            cbPortShow.DataSource = serialport.port_name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // affected a value of portname and baudRate
            port_Name = cbPortShow.SelectedItem.ToString();
            string Baud = cbBaudRate.SelectedItem.ToString();
            baud = Convert.ToInt32(Baud);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

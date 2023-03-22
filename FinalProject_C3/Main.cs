using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace FinalProject_C3
{
    public partial class Main : Form
    {
        SerialPort port = new SerialPort("COM3", 9600);
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            port.Open();
            while (true)
            {
                try
                {
                    TB_Sensor.Text += port.ReadLine() + "\n";
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("시리얼 통신 오류");
                    break;
                }
            }
        }
    }
}

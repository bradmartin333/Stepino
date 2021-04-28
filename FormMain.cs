using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Stepino
{
    public partial class FormMain : Form
    {
        public static SerialPort _Port = new SerialPort("COM6", 9600);

        public FormMain()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            _Port.Open();
        }

        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_Port != null && _Port.IsOpen)
                _Port.Close();
        }

        private void PortWrite(string message)
        {
            _Port.Write(message);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PortWrite("H");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            PortWrite("G" + numericUpDown1.Value.ToString());
        }
    }
}
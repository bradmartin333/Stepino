using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;

delegate void StringArgReturningVoidDelegate(string text);

namespace Stepino
{
    public partial class FormMain : Form
    {
        private SerialPort _Port;

        // Get this point using ShareX's Ruler tool
        private static Point _CamShutter = new Point(1524, 328); 
        public FormMain()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(Form1_FormClosed);

            _Port = new SerialPort
            {
                BaudRate = 9600,
                DataBits = 8,
                DiscardNull = false,
                DtrEnable = false,
                RtsEnable = true,
                Handshake = Handshake.None,
                ReadBufferSize = 4096,
                ReadTimeout = -1,
                WriteTimeout = -1,
                StopBits = StopBits.One
            };

            _Port.DataReceived += _Port_DataReceived;
        }

        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Port.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _Port.Write("H");
            InMotion(true);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            InMotion(true);
            _Port.Write("G" + numericUpDown1.Value.ToString());
        }

        private void InMotion(bool moving)
        {
            gbxMotion.Enabled = !moving;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            portComboBox.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                portComboBox.Items.Add(s);
            }
            portComboBox.SelectedIndex = portComboBox.Items.Count - 1;
            _Port.PortName = portComboBox.Text;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                statusLabel.Text = "";
                _Port.Open();
                System.Threading.Thread.Sleep(100);
                _Port.Write(" ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            _Port.Close();
        }

        private void portComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_Port.IsOpen)
                return;

            _Port.PortName = portComboBox.Text;
        }

        private void _Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;
            string msg;
            msg = serialPort.ReadLine();
            MsgIn(msg);
        }

        private void MsgIn(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (statusStrip.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(MsgIn);
                Invoke(d, new object[] { text });
            }
            else
            {
                statusLabel.Text = text.Trim();
                if (text.Contains("OK") || text.Contains("HOMED"))
                {
                    InMotion(false);
                    timer.Enabled = false;

                    if (text.Contains("HOMED"))
                        btnHome.BackColor = Color.LawnGreen;
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnScan.PerformClick();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            btnGo.PerformClick();
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Clicking.SendClick(_CamShutter);
        }
    }
}
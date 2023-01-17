using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Arduino_PulseGenerator
{
    public partial class FormMain : Form
    {
        private SerialPort comPort = new SerialPort();
        string appName = "Arduino pulse generator";

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cmbPortName.SelectedIndex != -1)
            {
                comPort.PortName = cmbPortName.Text;

                try
                {
                    comPort.BaudRate = 9600;
                    comPort.Parity = Parity.None;
                    comPort.StopBits = StopBits.One;
                    comPort.DataBits = 8;
                    comPort.Handshake = Handshake.None;
                    comPort.ReadTimeout = 1000;
                    comPort.DataReceived += new SerialDataReceivedEventHandler(ComPort_DataReceived);

                    comPort.Open();
                    comPort.Write("g" + Environment.NewLine);

                    btnSend.Enabled = true;
                }

                catch (Exception ex)
                {
                    btnSend.Enabled = false;
                    btnOpen.Visible = false;
                    MessageBox.Show(ex.Message, appName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("No com port selected.", appName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (comPort.IsOpen)
            {
                btnOpen.Visible = false;
            }
        }

        private void ComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    toolStripStatusLblRxData.Text = comPort.ReadLine().Replace("\r", "");
                });

            }
            catch (Exception)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    toolStripStatusLblRxData.Text = "RX data timeout";
                });
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            comPort.Close();
            comPort.Dispose();
            btnSend.Enabled = false;
            btnOpen.Visible = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendData();
        }

        private void cmbPortName_DropDown(object sender, EventArgs e)
        {
            updatePorts();
        }
        
        private void updatePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbPortName.Items.Add(port);
            }
        }

        private void numericUpDownFreq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.sendData();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void sendData()
        {
            comPort.Write(numericUpDownFreq.Value + "u" + Environment.NewLine);
            comPort.Write(numericUpDownFreq.Value + "s" + Environment.NewLine);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            comPort.Close();
            comPort.Dispose();
        }
    }
}

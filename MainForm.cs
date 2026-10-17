using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArduinoDebugTool
{
    public partial class MainForm : Form
    {
        private ArduinoSerial _arduino;
        private int _commandCount = 0;

        public MainForm()
        {
            InitializeComponent();
            _arduino = new ArduinoSerial();
            _arduino.DataReceived += OnDataReceived;
            _arduino.ErrorOccurred += OnErrorOccurred;
            _arduino.ConnectionStatusChanged += OnConnectionStatusChanged;
            Load += MainForm_Load;
            FormClosing += MainForm_FormClosing;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshPortList();
            cmbBaudRate.SelectedItem = "115200";
            UpdateConnectionStatus(false);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _arduino?.Dispose();
        }

        private void RefreshPortList()
        {
            string currentPort = cmbPort.SelectedItem?.ToString();
            cmbPort.Items.Clear();
            string[] ports = _arduino.GetAvailablePorts();
            cmbPort.Items.AddRange(ports);

            if (currentPort != null && cmbPort.Items.Contains(currentPort))
                cmbPort.SelectedItem = currentPort;
            else if (cmbPort.Items.Count > 0)
                cmbPort.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPortList();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (_arduino.IsConnected)
            {
                _arduino.Disconnect();
            }
            else
            {
                if (cmbPort.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn cổng COM!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int baudRate = int.Parse(cmbBaudRate.SelectedItem?.ToString() ?? "115200");
                if (_arduino.Connect(cmbPort.SelectedItem.ToString(), baudRate))
                {
                    LogMessage($"[SYSTEM] Đã kết nối {_arduino.PortName} @ {_arduino.BaudRate} baud", Color.LimeGreen);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendCommand(txtCommand.Text);
        }

        private void txtCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendCommand(txtCommand.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void SendCommand(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
                return;

            if (!_arduino.IsConnected)
            {
                MessageBox.Show("Chưa kết nối với thiết bị!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _commandCount++;
            LogMessage($"[TX #{_commandCount}] {command}", Color.Cyan);

            if (!_arduino.SendCommand(command))
            {
                LogMessage("[ERROR] Gửi lệnh thất bại!", Color.Red);
            }
        }

        private void OnDataReceived(object sender, string data)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OnDataReceived(sender, data)));
                return;
            }

            LogMessage($"[RX] {data}", Color.White);
        }

        private void OnErrorOccurred(object sender, string error)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OnErrorOccurred(sender, error)));
                return;
            }

            LogMessage($"[ERROR] {error}", Color.Red);
        }

        private void OnConnectionStatusChanged(object sender, bool isConnected)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OnConnectionStatusChanged(sender, isConnected)));
                return;
            }

            UpdateConnectionStatus(isConnected);
        }

        private void UpdateConnectionStatus(bool isConnected)
        {
            btnConnect.Text = isConnected ? "Disconnect" : "Connect";
            btnConnect.BackColor = isConnected ? Color.OrangeRed : Color.SteelBlue;
            btnConnect.ForeColor = Color.White;
            lblStatus.Text = isConnected ? "● Connected" : "● Disconnected";
            lblStatus.ForeColor = isConnected ? Color.LimeGreen : Color.Red;
            cmbPort.Enabled = !isConnected;
            cmbBaudRate.Enabled = !isConnected;
            btnRefresh.Enabled = !isConnected;
        }

        private void LogMessage(string message, Color color)
        {
            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.SelectionLength = 0;
            txtLog.SelectionColor = color;
            txtLog.AppendText($"[{DateTime.Now:HH:mm:ss.fff}] {message}{Environment.NewLine}");
            txtLog.ScrollToCaret();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FileName = $"DebugLog_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, txtLog.Text);
                    LogMessage($"[SYSTEM] Đã log lưu log vào: {sfd.FileName}", Color.Yellow);
                }
            }
        }

        // === PNEUMATIC SYSTEM TEST BUTTONS ===

        private void btnAirOn_Click(object sender, EventArgs e) => SendCommand("AIR_ON");
        private void btnAirOff_Click(object sender, EventArgs e) => SendCommand("AIR_OFF");
        private void btnValve1On_Click(object sender, EventArgs e) => SendCommand("VALVE1_ON");
        private void btnValve1Off_Click(object sender, EventArgs e) => SendCommand("VALVE1_OFF");
        private void btnValve2On_Click(object sender, EventArgs e) => SendCommand("VALVE2_ON");
        private void btnValve2Off_Click(object sender, EventArgs e) => SendCommand("VALVE2_OFF");
        private void btnValve3On_Click(object sender, EventArgs e) => SendCommand("VALVE3_ON");
        private void btnValve3Off_Click(object sender, EventArgs e) => SendCommand("VALVE3_OFF");
        private void btnValve4On_Click(object sender, EventArgs e) => SendCommand("VALVE4_ON");
        private void btnValve4Off_Click(object sender, EventArgs e) => SendCommand("VALVE4_OFF");

        private void btnCylinderUp_Click(object sender, EventArgs e) => SendCommand("CYL_UP");
        private void btnCylinderDown_Click(object sender, EventArgs e) => SendCommand("CYL_DOWN");
        private void btnCylinderFwd_Click(object sender, EventArgs e) => SendCommand("CYL_FWD");
        private void btnCylinderRev_Click(object sender, EventArgs e) => SendCommand("CYL_REV");

        private void btnPumpOn_Click(object sender, EventArgs e) => SendCommand("PUMP_ON");
        private void btnPumpOff_Click(object sender, EventArgs e) => SendCommand("PUMP_OFF");

        private void btnPressureUp_Click(object sender, EventArgs e) => SendCommand("PRESS_UP");
        private void btnPressureDown_Click(object sender, EventArgs e) => SendCommand("PRESS_DOWN");
        private void btnPressureSet_Click(object sender, EventArgs e) => SendCommand($"PRESS_SET {txtPressure.Text}");

        private void btnReadPressure_Click(object sender, EventArgs e) => SendCommand("READ_PRESSURE");
        private void btnReadTemp_Click(object sender, EventArgs e) => SendCommand("READ_TEMP");
        private void btnReadAll_Click(object sender, EventArgs e) => SendCommand("READ_ALL");

        private void btnEStop_Click(object sender, EventArgs e)
        {
            SendCommand("ESTOP");
            LogMessage("[!!!] EMERGENCY STOP đã gửi!", Color.Red);
        }

        private void btnReset_Click(object sender, EventArgs e) => SendCommand("RESET");
        private void btnStatus_Click(object sender, EventArgs e) => SendCommand("STATUS");
        private void btnVersion_Click(object sender, EventArgs e) => SendCommand("VERSION");
        private void btnHelp_Click(object sender, EventArgs e) => SendCommand("HELP");

        private void btnSequenceTest_Click(object sender, EventArgs e)
        {
            LogMessage("[SEQ] Bắt đầu test sequence...", Color.Yellow);
            SendCommand("SEQ_TEST_START");
        }

        private void btnCycleTest_Click(object sender, EventArgs e)
        {
            LogMessage("[SEQ] Bắt đầu cycle test...", Color.Yellow);
            SendCommand("CYCLE_TEST");
        }
    }
}

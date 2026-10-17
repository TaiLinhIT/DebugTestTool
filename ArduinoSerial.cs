using System;
using System.IO.Ports;
using System.Threading;

namespace ArduinoDebugTool
{
    public class ArduinoSerial : IDisposable
    {
        private SerialPort _serialPort;
        private Thread _readThread;
        private bool _isRunning;
        private readonly object _lockObj = new object();

        public event EventHandler<string> DataReceived;
        public event EventHandler<string> ErrorOccurred;
        public event EventHandler<bool> ConnectionStatusChanged;

        public bool IsConnected => _serialPort?.IsOpen ?? false;
        public string PortName => _serialPort?.PortName;
        public int BaudRate => _serialPort?.BaudRate ?? 0;

        public ArduinoSerial()
        {
            _serialPort = new SerialPort
            {
                ReadTimeout = 500,
                WriteTimeout = 500,
                NewLine = "\n",
                Encoding = System.Text.Encoding.UTF8
            };
        }

        public string[] GetAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }

        public bool Connect(string portName, int baudRate = 115200)
        {
            try
            {
                if (IsConnected)
                {
                    Disconnect();
                }

                _serialPort.PortName = portName;
                _serialPort.BaudRate = baudRate;
                _serialPort.Open();

                _isRunning = true;
                _readThread = new Thread(ReadThread);
                _readThread.IsBackground = true;
                _readThread.Start();

                ConnectionStatusChanged?.Invoke(this, true);
                return true;
            }
            catch (Exception ex)
            {
                ErrorOccurred?.Invoke(this, $"Lỗi kết nối: {ex.Message}");
                return false;
            }
        }

        public void Disconnect()
        {
            _isRunning = false;

            if (_readThread != null && _readThread.IsAlive)
            {
                _readThread.Join(1000);
            }

            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Close();
            }

            ConnectionStatusChanged?.Invoke(this, false);
        }

        public bool SendCommand(string command)
        {
            if (!IsConnected || string.IsNullOrWhiteSpace(command))
                return false;

            try
            {
                lock (_lockObj)
                {
                    _serialPort.WriteLine(command);
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorOccurred?.Invoke(this, $"Lỗi gửi lệnh: {ex.Message}");
                return false;
            }
        }

        private void ReadThread()
        {
            while (_isRunning && IsConnected)
            {
                try
                {
                    string data = _serialPort.ReadLine();
                    if (!string.IsNullOrEmpty(data))
                    {
                        DataReceived?.Invoke(this, data.Trim());
                    }
                }
                catch (TimeoutException) { }
                catch (Exception ex)
                {
                    if (_isRunning)
                    {
                        ErrorOccurred?.Invoke(this, $"Lỗi đọc: {ex.Message}");
                    }
                    break;
                }
            }
        }

        public void Dispose()
        {
            Disconnect();
            _serialPort?.Dispose();
        }
    }
}

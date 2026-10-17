namespace ArduinoDebugTool
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panelPneumatic = new System.Windows.Forms.Panel();
            this.grpPneumatic = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grpAirSupply = new System.Windows.Forms.GroupBox();
            this.btnAirOff = new System.Windows.Forms.Button();
            this.btnAirOn = new System.Windows.Forms.Button();
            this.grpValves = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnValve4Off = new System.Windows.Forms.Button();
            this.btnValve4On = new System.Windows.Forms.Button();
            this.btnValve3Off = new System.Windows.Forms.Button();
            this.btnValve3On = new System.Windows.Forms.Button();
            this.btnValve2Off = new System.Windows.Forms.Button();
            this.btnValve2On = new System.Windows.Forms.Button();
            this.btnValve1Off = new System.Windows.Forms.Button();
            this.btnValve1On = new System.Windows.Forms.Button();
            this.grpCylinders = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCylinderRev = new System.Windows.Forms.Button();
            this.btnCylinderFwd = new System.Windows.Forms.Button();
            this.btnCylinderDown = new System.Windows.Forms.Button();
            this.btnCylinderUp = new System.Windows.Forms.Button();
            this.grpPressure = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPressureSet = new System.Windows.Forms.Button();
            this.btnPressureDown = new System.Windows.Forms.Button();
            this.btnPressureUp = new System.Windows.Forms.Button();
            this.grpPump = new System.Windows.Forms.GroupBox();
            this.btnPumpOff = new System.Windows.Forms.Button();
            this.btnPumpOn = new System.Windows.Forms.Button();
            this.grpSensors = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReadAll = new System.Windows.Forms.Button();
            this.btnReadTemp = new System.Windows.Forms.Button();
            this.btnReadPressure = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnVersion = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEStop = new System.Windows.Forms.Button();
            this.btnCycleTest = new System.Windows.Forms.Button();
            this.btnSequenceTest = new System.Windows.Forms.Button();
            this.panelCommand = new System.Windows.Forms.Panel();
            this.grpCommand = new System.Windows.Forms.GroupBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.panelLog = new System.Windows.Forms.Panel();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.panelLogButtons = new System.Windows.Forms.Panel();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelConnection.SuspendLayout();
            this.grpConnection.SuspendLayout();
            this.panelPneumatic.SuspendLayout();
            this.grpPneumatic.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpAirSupply.SuspendLayout();
            this.grpValves.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grpCylinders.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grpPressure.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.grpPump.SuspendLayout();
            this.grpSensors.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.grpControl.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panelCommand.SuspendLayout();
            this.grpCommand.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panelLogButtons.SuspendLayout();
            this.SuspendLayout();
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelConnection, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelPneumatic, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelCommand, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelLog, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 800);
            this.tableLayoutPanel1.TabIndex = 0;
            //
            // panelHeader
            //
            this.tableLayoutPanel1.SetColumnSpan(this.panelHeader, 2);
            this.panelHeader.Controls.Add(this.picLogo);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1194, 74);
            this.panelHeader.TabIndex = 0;
            //
            // picLogo
            //
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::ArduinoDebugTool.Resources.logo_han;
            this.picLogo.Location = new System.Drawing.Point(1050, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(140, 65);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            //
            // lblTitle
            //
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1194, 74);
            this.lblTitle.Text = "Arduino Pneumatic Debug Tool";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // panelConnection
            //
            this.panelConnection.Controls.Add(this.grpConnection);
            this.panelConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConnection.Location = new System.Drawing.Point(603, 83);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Padding = new System.Windows.Forms.Padding(1);
            this.panelConnection.Size = new System.Drawing.Size(594, 354);
            //
            // grpConnection
            //
            this.grpConnection.Controls.Add(this.btnRefresh);
            this.grpConnection.Controls.Add(this.cmbBaudRate);
            this.grpConnection.Controls.Add(this.label2);
            this.grpConnection.Controls.Add(this.cmbPort);
            this.grpConnection.Controls.Add(this.label1);
            this.grpConnection.Controls.Add(this.lblStatus);
            this.grpConnection.Controls.Add(this.btnConnect);
            this.grpConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConnection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpConnection.Location = new System.Drawing.Point(5, 5);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(584, 344);
            this.grpConnection.Text = "Kết nối Serial";
            //
            // btnRefresh
            //
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(490, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // cmbBaudRate
            //
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cmbBaudRate.Location = new System.Drawing.Point(120, 70);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(150, 28);
            //
            // label2
            //
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.Text = "Baud Rate:";
            //
            // cmbPort
            //
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(120, 30);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(150, 28);
            //
            // label1
            //
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.Text = "COM Port:";
            //
            // lblStatus
            //
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(15, 120);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(200, 30);
            this.lblStatus.Text = "● Disconnected";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnConnect
            //
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConnect.Location = new System.Drawing.Point(380, 120);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(190, 50);
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            //
            // panelPneumatic
            //
            this.panelPneumatic.Controls.Add(this.grpPneumatic);
            this.panelPneumatic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPneumatic.Location = new System.Drawing.Point(3, 83);
            this.panelPneumatic.Name = "panelPneumatic";
            this.panelPneumatic.Padding = new System.Windows.Forms.Padding(1);
            this.panelPneumatic.Size = new System.Drawing.Size(594, 354);
            //
            // grpPneumatic
            //
            this.grpPneumatic.Controls.Add(this.tableLayoutPanel2);
            this.grpPneumatic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPneumatic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPneumatic.Location = new System.Drawing.Point(5, 5);
            this.grpPneumatic.Name = "grpPneumatic";
            this.grpPneumatic.Size = new System.Drawing.Size(584, 344);
            this.grpPneumatic.Text = "Điều khiển hệ thống khí";
            //
            // tableLayoutPanel2
            //
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel2.Controls.Add(this.grpAirSupply, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grpValves, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.grpCylinders, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.grpPressure, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.grpPump, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.grpSensors, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(578, 313);
            //
            // grpAirSupply
            //
            this.grpAirSupply.Controls.Add(this.btnAirOff);
            this.grpAirSupply.Controls.Add(this.btnAirOn);
            this.grpAirSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAirSupply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpAirSupply.Location = new System.Drawing.Point(3, 3);
            this.grpAirSupply.Name = "grpAirSupply";
            this.grpAirSupply.Size = new System.Drawing.Size(186, 150);
            this.grpAirSupply.Text = "Nguồn khí";
            //
            // btnAirOff
            //
            this.btnAirOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAirOff.Location = new System.Drawing.Point(10, 70);
            this.btnAirOff.Name = "btnAirOff";
            this.btnAirOff.Size = new System.Drawing.Size(166, 35);
            this.btnAirOff.Text = "AIR OFF";
            this.btnAirOff.Click += new System.EventHandler(this.btnAirOff_Click);
            //
            // btnAirOn
            //
            this.btnAirOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAirOn.Location = new System.Drawing.Point(10, 25);
            this.btnAirOn.Name = "btnAirOn";
            this.btnAirOn.Size = new System.Drawing.Size(166, 35);
            this.btnAirOn.Text = "AIR ON";
            this.btnAirOn.Click += new System.EventHandler(this.btnAirOn_Click);
            //
            // grpValves
            //
            this.grpValves.Controls.Add(this.tableLayoutPanel3);
            this.grpValves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpValves.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpValves.Location = new System.Drawing.Point(195, 3);
            this.grpValves.Name = "grpValves";
            this.grpValves.Size = new System.Drawing.Size(186, 150);
            this.grpValves.Text = "Van điều khiển";
            //
            // tableLayoutPanel3
            //
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnValve4Off, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnValve4On, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnValve3Off, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnValve3On, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnValve2Off, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnValve2On, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnValve1Off, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnValve1On, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(180, 123);
            //
            // btnValve4Off
            //
            this.btnValve4Off.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValve4Off.Location = new System.Drawing.Point(93, 93);
            this.btnValve4Off.Name = "btnValve4Off";
            this.btnValve4Off.Size = new System.Drawing.Size(84, 27);
            this.btnValve4Off.Text = "V4 OFF";
            this.btnValve4Off.Click += new System.EventHandler(this.btnValve4Off_Click);
            //
            // btnValve4On
            //
            this.btnValve4On.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValve4On.Location = new System.Drawing.Point(3, 93);
            this.btnValve4On.Name = "btnValve4On";
            this.btnValve4On.Size = new System.Drawing.Size(84, 27);
            this.btnValve4On.Text = "V4 ON";
            this.btnValve4On.Click += new System.EventHandler(this.btnValve4On_Click);
            //
            // btnValve3Off
            //
            this.btnValve3Off.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValve3Off.Location = new System.Drawing.Point(93, 63);
            this.btnValve3Off.Name = "btnValve3Off";
            this.btnValve3Off.Size = new System.Drawing.Size(84, 27);
            this.btnValve3Off.Text = "V3 OFF";
            this.btnValve3Off.Click += new System.EventHandler(this.btnValve3Off_Click);
            //
            // btnValve3On
            //
            this.btnValve3On.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValve3On.Location = new System.Drawing.Point(3, 63);
            this.btnValve3On.Name = "btnValve3On";
            this.btnValve3On.Size = new System.Drawing.Size(84, 27);
            this.btnValve3On.Text = "V3 ON";
            this.btnValve3On.Click += new System.EventHandler(this.btnValve3On_Click);
            //
            // btnValve2Off
            //
            this.btnValve2Off.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValve2Off.Location = new System.Drawing.Point(93, 33);
            this.btnValve2Off.Name = "btnValve2Off";
            this.btnValve2Off.Size = new System.Drawing.Size(84, 27);
            this.btnValve2Off.Text = "V2 OFF";
            this.btnValve2Off.Click += new System.EventHandler(this.btnValve2Off_Click);
            //
            // btnValve2On
            //
            this.btnValve2On.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValve2On.Location = new System.Drawing.Point(3, 33);
            this.btnValve2On.Name = "btnValve2On";
            this.btnValve2On.Size = new System.Drawing.Size(84, 27);
            this.btnValve2On.Text = "V2 ON";
            this.btnValve2On.Click += new System.EventHandler(this.btnValve2On_Click);
            //
            // btnValve1Off
            //
            this.btnValve1Off.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValve1Off.Location = new System.Drawing.Point(93, 3);
            this.btnValve1Off.Name = "btnValve1Off";
            this.btnValve1Off.Size = new System.Drawing.Size(84, 27);
            this.btnValve1Off.Text = "V1 OFF";
            this.btnValve1Off.Click += new System.EventHandler(this.btnValve1Off_Click);
            //
            // btnValve1On
            //
            this.btnValve1On.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValve1On.Location = new System.Drawing.Point(3, 3);
            this.btnValve1On.Name = "btnValve1On";
            this.btnValve1On.Size = new System.Drawing.Size(84, 27);
            this.btnValve1On.Text = "V1 ON";
            this.btnValve1On.Click += new System.EventHandler(this.btnValve1On_Click);
            //
            // grpCylinders
            //
            this.grpCylinders.Controls.Add(this.tableLayoutPanel4);
            this.grpCylinders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCylinders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCylinders.Location = new System.Drawing.Point(387, 3);
            this.grpCylinders.Name = "grpCylinders";
            this.grpCylinders.Size = new System.Drawing.Size(188, 150);
            this.grpCylinders.Text = "Xi lanh";
            //
            // tableLayoutPanel4
            //
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnCylinderRev, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnCylinderFwd, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnCylinderDown, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCylinderUp, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(182, 123);
            //
            // btnCylinderRev
            //
            this.btnCylinderRev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCylinderRev.Location = new System.Drawing.Point(94, 64);
            this.btnCylinderRev.Name = "btnCylinderRev";
            this.btnCylinderRev.Size = new System.Drawing.Size(85, 56);
            this.btnCylinderRev.Text = "CYL REV";
            this.btnCylinderRev.Click += new System.EventHandler(this.btnCylinderRev_Click);
            //
            // btnCylinderFwd
            //
            this.btnCylinderFwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCylinderFwd.Location = new System.Drawing.Point(3, 64);
            this.btnCylinderFwd.Name = "btnCylinderFwd";
            this.btnCylinderFwd.Size = new System.Drawing.Size(85, 56);
            this.btnCylinderFwd.Text = "CYL FWD";
            this.btnCylinderFwd.Click += new System.EventHandler(this.btnCylinderFwd_Click);
            //
            // btnCylinderDown
            //
            this.btnCylinderDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCylinderDown.Location = new System.Drawing.Point(94, 3);
            this.btnCylinderDown.Name = "btnCylinderDown";
            this.btnCylinderDown.Size = new System.Drawing.Size(85, 55);
            this.btnCylinderDown.Text = "CYL DOWN";
            this.btnCylinderDown.Click += new System.EventHandler(this.btnCylinderDown_Click);
            //
            // btnCylinderUp
            //
            this.btnCylinderUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCylinderUp.Location = new System.Drawing.Point(3, 3);
            this.btnCylinderUp.Name = "btnCylinderUp";
            this.btnCylinderUp.Size = new System.Drawing.Size(85, 55);
            this.btnCylinderUp.Text = "CYL UP";
            this.btnCylinderUp.Click += new System.EventHandler(this.btnCylinderUp_Click);
            //
            // grpPressure
            //
            this.grpPressure.Controls.Add(this.tableLayoutPanel5);
            this.grpPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPressure.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpPressure.Location = new System.Drawing.Point(3, 159);
            this.grpPressure.Name = "grpPressure";
            this.grpPressure.Size = new System.Drawing.Size(186, 151);
            this.grpPressure.Text = "Áp suất";
            //
            // tableLayoutPanel5
            //
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.txtPressure, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnPressureSet, 0, 1);
            this.tableLayoutPanel5.SetColumnSpan(this.btnPressureSet, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnPressureDown, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnPressureUp, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(180, 124);
            //
            // txtPressure
            //
            this.txtPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPressure.Location = new System.Drawing.Point(3, 3);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(84, 24);
            this.txtPressure.Text = "2.0";
            this.txtPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // label3
            //
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(93, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 35);
            this.label3.Text = "bar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnPressureSet
            //
            this.btnPressureSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPressureSet.Location = new System.Drawing.Point(3, 44);
            this.btnPressureSet.Name = "btnPressureSet";
            this.btnPressureSet.Size = new System.Drawing.Size(174, 35);
            this.btnPressureSet.Text = "SET PRESSURE";
            this.btnPressureSet.Click += new System.EventHandler(this.btnPressureSet_Click);
            //
            // btnPressureDown
            //
            this.btnPressureDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPressureDown.Location = new System.Drawing.Point(93, 85);
            this.btnPressureDown.Name = "btnPressureDown";
            this.btnPressureDown.Size = new System.Drawing.Size(84, 36);
            this.btnPressureDown.Text = "▼ DOWN";
            this.btnPressureDown.Click += new System.EventHandler(this.btnPressureDown_Click);
            //
            // btnPressureUp
            //
            this.btnPressureUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPressureUp.Location = new System.Drawing.Point(3, 85);
            this.btnPressureUp.Name = "btnPressureUp";
            this.btnPressureUp.Size = new System.Drawing.Size(84, 36);
            this.btnPressureUp.Text = "▲ UP";
            this.btnPressureUp.Click += new System.EventHandler(this.btnPressureUp_Click);
            //
            // grpPump
            //
            this.grpPump.Controls.Add(this.btnPumpOff);
            this.grpPump.Controls.Add(this.btnPumpOn);
            this.grpPump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPump.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpPump.Location = new System.Drawing.Point(195, 159);
            this.grpPump.Name = "grpPump";
            this.grpPump.Size = new System.Drawing.Size(186, 151);
            this.grpPump.Text = "Bơm khí";
            //
            // btnPumpOff
            //
            this.btnPumpOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPumpOff.Location = new System.Drawing.Point(10, 70);
            this.btnPumpOff.Name = "btnPumpOff";
            this.btnPumpOff.Size = new System.Drawing.Size(166, 35);
            this.btnPumpOff.Text = "PUMP OFF";
            this.btnPumpOff.Click += new System.EventHandler(this.btnPumpOff_Click);
            //
            // btnPumpOn
            //
            this.btnPumpOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPumpOn.Location = new System.Drawing.Point(10, 25);
            this.btnPumpOn.Name = "btnPumpOn";
            this.btnPumpOn.Size = new System.Drawing.Size(166, 35);
            this.btnPumpOn.Text = "PUMP ON";
            this.btnPumpOn.Click += new System.EventHandler(this.btnPumpOn_Click);
            //
            // grpSensors
            //
            this.grpSensors.Controls.Add(this.tableLayoutPanel6);
            this.grpSensors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSensors.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpSensors.Location = new System.Drawing.Point(387, 159);
            this.grpSensors.Name = "grpSensors";
            this.grpSensors.Size = new System.Drawing.Size(188, 151);
            this.grpSensors.Text = "Cảm biến";
            //
            // tableLayoutPanel6
            //
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.btnReadAll, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.btnReadTemp, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnReadPressure, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(182, 124);
            //
            // btnReadAll
            //
            this.btnReadAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReadAll.Location = new System.Drawing.Point(3, 85);
            this.btnReadAll.Name = "btnReadAll";
            this.btnReadAll.Size = new System.Drawing.Size(176, 36);
            this.btnReadAll.Text = "READ ALL";
            this.btnReadAll.Click += new System.EventHandler(this.btnReadAll_Click);
            //
            // btnReadTemp
            //
            this.btnReadTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReadTemp.Location = new System.Drawing.Point(3, 44);
            this.btnReadTemp.Name = "btnReadTemp";
            this.btnReadTemp.Size = new System.Drawing.Size(176, 35);
            this.btnReadTemp.Text = "READ TEMP";
            this.btnReadTemp.Click += new System.EventHandler(this.btnReadTemp_Click);
            //
            // btnReadPressure
            //
            this.btnReadPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReadPressure.Location = new System.Drawing.Point(3, 3);
            this.btnReadPressure.Name = "btnReadPressure";
            this.btnReadPressure.Size = new System.Drawing.Size(176, 35);
            this.btnReadPressure.Text = "READ PRESSURE";
            this.btnReadPressure.Click += new System.EventHandler(this.btnReadPressure_Click);
            //
            // panelControl
            //
            this.panelControl.Controls.Add(this.grpControl);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(603, 443);
            this.panelControl.Name = "panelControl";
            this.panelControl.Padding = new System.Windows.Forms.Padding(1);
            this.panelControl.Size = new System.Drawing.Size(594, 354);
            //
            // grpControl
            //
            this.grpControl.Controls.Add(this.tableLayoutPanel7);
            this.grpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpControl.Location = new System.Drawing.Point(5, 5);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(584, 344);
            this.grpControl.Text = "Điều khiển hệ thống";
            //
            // tableLayoutPanel7
            //
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel7.Controls.Add(this.btnHelp, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnVersion, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnStatus, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnReset, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnEStop, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnCycleTest, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.btnSequenceTest, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(578, 313);
            //
            // btnHelp
            //
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHelp.Location = new System.Drawing.Point(388, 107);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(187, 97);
            this.btnHelp.Text = "HELP";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            //
            // btnVersion
            //
            this.btnVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVersion.Location = new System.Drawing.Point(195, 107);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Size = new System.Drawing.Size(187, 97);
            this.btnVersion.Text = "VERSION";
            this.btnVersion.Click += new System.EventHandler(this.btnVersion_Click);
            //
            // btnStatus
            //
            this.btnStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatus.Location = new System.Drawing.Point(3, 107);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(186, 97);
            this.btnStatus.Text = "STATUS";
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            //
            // btnReset
            //
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(388, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(187, 98);
            this.btnReset.Text = "RESET";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            //
            // btnEStop
            //
            this.btnEStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEStop.Location = new System.Drawing.Point(195, 3);
            this.btnEStop.Name = "btnEStop";
            this.btnEStop.Size = new System.Drawing.Size(187, 98);
            this.btnEStop.Text = "EMERGENCY STOP";
            this.btnEStop.Click += new System.EventHandler(this.btnEStop_Click);
            //
            // btnCycleTest
            //
            this.btnCycleTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCycleTest.Location = new System.Drawing.Point(3, 211);
            this.btnCycleTest.Name = "btnCycleTest";
            this.btnCycleTest.Size = new System.Drawing.Size(186, 99);
            this.btnCycleTest.Text = "CYCLE TEST";
            this.btnCycleTest.Click += new System.EventHandler(this.btnCycleTest_Click);
            //
            // btnSequenceTest
            //
            this.btnSequenceTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSequenceTest.Location = new System.Drawing.Point(3, 3);
            this.btnSequenceTest.Name = "btnSequenceTest";
            this.btnSequenceTest.Size = new System.Drawing.Size(186, 98);
            this.btnSequenceTest.Text = "SEQUENCE TEST";
            this.btnSequenceTest.Click += new System.EventHandler(this.btnSequenceTest_Click);
            //
            // panelCommand
            //
            this.panelCommand.Controls.Add(this.grpCommand);
            this.panelCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCommand.Location = new System.Drawing.Point(3, 443);
            this.panelCommand.Name = "panelCommand";
            this.panelCommand.Padding = new System.Windows.Forms.Padding(1);
            this.panelCommand.Size = new System.Drawing.Size(594, 354);
            //
            // grpCommand
            //
            this.grpCommand.Controls.Add(this.txtCommand);
            this.grpCommand.Controls.Add(this.btnSend);
            this.grpCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCommand.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCommand.Location = new System.Drawing.Point(5, 5);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Size = new System.Drawing.Size(584, 344);
            this.grpCommand.Text = "Gửi lệnh tùy chỉnh";
            //
            // txtCommand
            //
            this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommand.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.Location = new System.Drawing.Point(15, 40);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(450, 30);
            this.txtCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyDown);
            //
            // btnSend
            //
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSend.Location = new System.Drawing.Point(480, 35);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 40);
            this.btnSend.Text = "SEND";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            //
            // panelLog
            //
            this.panelLog.Controls.Add(this.grpLog);
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLog.Location = new System.Drawing.Point(603, 443);
            this.panelLog.Name = "panelLog";
            this.panelLog.Padding = new System.Windows.Forms.Padding(1);
            this.panelLog.Size = new System.Drawing.Size(594, 354);
            //
            // grpLog
            //
            this.grpLog.Controls.Add(this.tableLayoutPanel8);
            this.grpLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpLog.Location = new System.Drawing.Point(5, 5);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(584, 344);
            this.grpLog.Text = "Log giao tiếp";
            //
            // tableLayoutPanel8
            //
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.txtLog, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panelLogButtons, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(578, 313);
            //
            // txtLog
            //
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(3, 3);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(572, 262);
            this.txtLog.Text = "";
            this.txtLog.WordWrap = false;
            //
            // panelLogButtons
            //
            this.panelLogButtons.Controls.Add(this.btnSaveLog);
            this.panelLogButtons.Controls.Add(this.btnClearLog);
            this.panelLogButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogButtons.Location = new System.Drawing.Point(3, 271);
            this.panelLogButtons.Name = "panelLogButtons";
            this.panelLogButtons.Size = new System.Drawing.Size(572, 39);
            //
            // btnSaveLog
            //
            this.btnSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveLog.Location = new System.Drawing.Point(470, 3);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(100, 32);
            this.btnSaveLog.Text = "Save Log";
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            //
            // btnClearLog
            //
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearLog.Location = new System.Drawing.Point(3, 3);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(100, 32);
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Pneumatic Debug Tool";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelConnection.ResumeLayout(false);
            this.grpConnection.ResumeLayout(false);
            this.panelPneumatic.ResumeLayout(false);
            this.grpPneumatic.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grpAirSupply.ResumeLayout(false);
            this.grpValves.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.grpCylinders.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.grpPressure.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.grpPressure.PerformLayout();
            this.grpPump.ResumeLayout(false);
            this.grpSensors.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.grpControl.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panelCommand.ResumeLayout(false);
            this.grpCommand.ResumeLayout(false);
            this.grpCommand.PerformLayout();
            this.panelLog.ResumeLayout(false);
            this.grpLog.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panelLogButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panelPneumatic;
        private System.Windows.Forms.GroupBox grpPneumatic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grpAirSupply;
        private System.Windows.Forms.Button btnAirOff;
        private System.Windows.Forms.Button btnAirOn;
        private System.Windows.Forms.GroupBox grpValves;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnValve4Off;
        private System.Windows.Forms.Button btnValve4On;
        private System.Windows.Forms.Button btnValve3Off;
        private System.Windows.Forms.Button btnValve3On;
        private System.Windows.Forms.Button btnValve2Off;
        private System.Windows.Forms.Button btnValve2On;
        private System.Windows.Forms.Button btnValve1Off;
        private System.Windows.Forms.Button btnValve1On;
        private System.Windows.Forms.GroupBox grpCylinders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnCylinderRev;
        private System.Windows.Forms.Button btnCylinderFwd;
        private System.Windows.Forms.Button btnCylinderDown;
        private System.Windows.Forms.Button btnCylinderUp;
        private System.Windows.Forms.GroupBox grpPressure;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtPressure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPressureSet;
        private System.Windows.Forms.Button btnPressureDown;
        private System.Windows.Forms.Button btnPressureUp;
        private System.Windows.Forms.GroupBox grpPump;
        private System.Windows.Forms.Button btnPumpOff;
        private System.Windows.Forms.Button btnPumpOn;
        private System.Windows.Forms.GroupBox grpSensors;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnReadAll;
        private System.Windows.Forms.Button btnReadTemp;
        private System.Windows.Forms.Button btnReadPressure;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnVersion;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEStop;
        private System.Windows.Forms.Button btnCycleTest;
        private System.Windows.Forms.Button btnSequenceTest;
        private System.Windows.Forms.Panel panelCommand;
        private System.Windows.Forms.GroupBox grpCommand;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Panel panelLogButtons;
        private System.Windows.Forms.Button btnSaveLog;
        private System.Windows.Forms.Button btnClearLog;
    }
}

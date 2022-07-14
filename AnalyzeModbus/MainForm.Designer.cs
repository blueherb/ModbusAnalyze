
namespace AnalyzeModbus
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModbusRtu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModbusTcp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbErrCount = new System.Windows.Forms.Label();
            this.lbRxCount = new System.Windows.Forms.Label();
            this.lbTxCount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lbConnectTime = new System.Windows.Forms.Label();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbIp = new System.Windows.Forms.Label();
            this.lbMode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbHex = new System.Windows.Forms.TextBox();
            this.vsbHex = new System.Windows.Forms.VScrollBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.vsbData = new System.Windows.Forms.VScrollBar();
            this.btnSend = new System.Windows.Forms.Button();
            this.dudSendedData = new System.Windows.Forms.DomainUpDown();
            this.cbFunctionCoil = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbMemoryLength = new System.Windows.Forms.TextBox();
            this.tbQueryNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMemoryStart = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbLeftTime = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbRapidCount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbIntervalTx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxAutoTx = new System.Windows.Forms.CheckBox();
            this.cbQueryRule = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmConnect,
            this.tsmHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiOpen,
            this.tsmiSaveLog});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(43, 20);
            this.tsmFile.Text = "파일";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(178, 22);
            this.tsmiSave.Text = "현재 설정 저장하기";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(178, 22);
            this.tsmiOpen.Text = "이전 설정 불러오기";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // tsmiSaveLog
            // 
            this.tsmiSaveLog.Name = "tsmiSaveLog";
            this.tsmiSaveLog.Size = new System.Drawing.Size(178, 22);
            this.tsmiSaveLog.Text = "로그 저장하기";
            // 
            // tsmConnect
            // 
            this.tsmConnect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModbusRtu,
            this.tsmiModbusTcp});
            this.tsmConnect.Name = "tsmConnect";
            this.tsmConnect.Size = new System.Drawing.Size(43, 20);
            this.tsmConnect.Text = "연결";
            // 
            // tsmiModbusRtu
            // 
            this.tsmiModbusRtu.Name = "tsmiModbusRtu";
            this.tsmiModbusRtu.Size = new System.Drawing.Size(191, 22);
            this.tsmiModbusRtu.Text = "ModbusRTU(Serial)";
            // 
            // tsmiModbusTcp
            // 
            this.tsmiModbusTcp.Name = "tsmiModbusTcp";
            this.tsmiModbusTcp.Size = new System.Drawing.Size(191, 22);
            this.tsmiModbusTcp.Text = "ModbusTCP(Ethernet)";
            this.tsmiModbusTcp.Click += new System.EventHandler(this.tsmiModbusTcp_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStart,
            this.TsmiInfo});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(55, 20);
            this.tsmHelp.Text = "도움말";
            // 
            // tsmiStart
            // 
            this.tsmiStart.Name = "tsmiStart";
            this.tsmiStart.Size = new System.Drawing.Size(126, 22);
            this.tsmiStart.Text = "시작 하기";
            // 
            // TsmiInfo
            // 
            this.TsmiInfo.Name = "TsmiInfo";
            this.TsmiInfo.Size = new System.Drawing.Size(126, 22);
            this.TsmiInfo.Text = "정보";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbErrCount);
            this.groupBox1.Controls.Add(this.lbRxCount);
            this.groupBox1.Controls.Add(this.lbTxCount);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.lbConnectTime);
            this.groupBox1.Controls.Add(this.lbStartTime);
            this.groupBox1.Controls.Add(this.lbPort);
            this.groupBox1.Controls.Add(this.lbIp);
            this.groupBox1.Controls.Add(this.lbMode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "연결 상태";
            // 
            // lbErrCount
            // 
            this.lbErrCount.Location = new System.Drawing.Point(378, 79);
            this.lbErrCount.Name = "lbErrCount";
            this.lbErrCount.Size = new System.Drawing.Size(69, 12);
            this.lbErrCount.TabIndex = 25;
            this.lbErrCount.Text = "-";
            // 
            // lbRxCount
            // 
            this.lbRxCount.Location = new System.Drawing.Point(288, 79);
            this.lbRxCount.Name = "lbRxCount";
            this.lbRxCount.Size = new System.Drawing.Size(69, 12);
            this.lbRxCount.TabIndex = 24;
            this.lbRxCount.Text = "-";
            // 
            // lbTxCount
            // 
            this.lbTxCount.Location = new System.Drawing.Point(202, 79);
            this.lbTxCount.Name = "lbTxCount";
            this.lbTxCount.Size = new System.Drawing.Size(69, 12);
            this.lbTxCount.TabIndex = 23;
            this.lbTxCount.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(358, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 12);
            this.label15.TabIndex = 22;
            this.label15.Text = "Err";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(268, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "Rx";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(487, 73);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(69, 24);
            this.btnDisconnect.TabIndex = 0;
            this.btnDisconnect.Text = "연결 끊기";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lbConnectTime
            // 
            this.lbConnectTime.Location = new System.Drawing.Point(376, 53);
            this.lbConnectTime.Name = "lbConnectTime";
            this.lbConnectTime.Size = new System.Drawing.Size(164, 12);
            this.lbConnectTime.TabIndex = 19;
            this.lbConnectTime.Text = "-";
            // 
            // lbStartTime
            // 
            this.lbStartTime.Location = new System.Drawing.Point(376, 27);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(164, 12);
            this.lbStartTime.TabIndex = 18;
            this.lbStartTime.Text = "-";
            // 
            // lbPort
            // 
            this.lbPort.Location = new System.Drawing.Point(97, 79);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(90, 12);
            this.lbPort.TabIndex = 17;
            this.lbPort.Text = "-";
            // 
            // lbIp
            // 
            this.lbIp.Location = new System.Drawing.Point(97, 53);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(164, 12);
            this.lbIp.TabIndex = 16;
            this.lbIp.Text = "-";
            // 
            // lbMode
            // 
            this.lbMode.Location = new System.Drawing.Point(97, 27);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(164, 12);
            this.lbMode.TabIndex = 15;
            this.lbMode.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = " 통신 진행시간 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "통신 시작시간 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "서버 Port :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(183, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 12);
            this.label13.TabIndex = 20;
            this.label13.Text = "Tx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "서버 IP :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "연결 모드 :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbHex);
            this.groupBox2.Controls.Add(this.vsbHex);
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 242);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hex";
            // 
            // tbHex
            // 
            this.tbHex.Location = new System.Drawing.Point(6, 20);
            this.tbHex.Multiline = true;
            this.tbHex.Name = "tbHex";
            this.tbHex.Size = new System.Drawing.Size(527, 216);
            this.tbHex.TabIndex = 0;
            // 
            // vsbHex
            // 
            this.vsbHex.Location = new System.Drawing.Point(536, 20);
            this.vsbHex.Name = "vsbHex";
            this.vsbHex.Size = new System.Drawing.Size(20, 216);
            this.vsbHex.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbData);
            this.groupBox3.Controls.Add(this.vsbData);
            this.groupBox3.Location = new System.Drawing.Point(598, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(562, 242);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "데이터 정보";
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(6, 20);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(527, 216);
            this.tbData.TabIndex = 0;
            // 
            // vsbData
            // 
            this.vsbData.Location = new System.Drawing.Point(536, 20);
            this.vsbData.Name = "vsbData";
            this.vsbData.Size = new System.Drawing.Size(20, 216);
            this.vsbData.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(505, 410);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(69, 24);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // dudSendedData
            // 
            this.dudSendedData.Location = new System.Drawing.Point(18, 411);
            this.dudSendedData.Name = "dudSendedData";
            this.dudSendedData.Size = new System.Drawing.Size(481, 21);
            this.dudSendedData.TabIndex = 1;
            this.dudSendedData.Text = "00 01 00 00 00 06 01 00 00 00 00 01";
            // 
            // cbFunctionCoil
            // 
            this.cbFunctionCoil.FormattingEnabled = true;
            this.cbFunctionCoil.Items.AddRange(new object[] {
            "01 (Bit 메모리 읽기 영역)",
            "02 (Bit 메모리 쓰기 영역)",
            "03 (Word 메모리 읽기 영역)",
            "04 (Word 메모리 쓰기 영역)",
            "05 (Bit 메모리 단일 쓰기)",
            "06 (Word 메모리 단일 쓰기)",
            "15 (Bit 메모리 복수 쓰기)",
            "16 (Word 메모리 복수 쓰기)"});
            this.cbFunctionCoil.Location = new System.Drawing.Point(333, 28);
            this.cbFunctionCoil.MaxLength = 2;
            this.cbFunctionCoil.Name = "cbFunctionCoil";
            this.cbFunctionCoil.Size = new System.Drawing.Size(184, 20);
            this.cbFunctionCoil.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbMemoryLength);
            this.groupBox4.Controls.Add(this.tbQueryNumber);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cbFunctionCoil);
            this.groupBox4.Controls.Add(this.tbMemoryStart);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(18, 444);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(556, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "프레임 구조 설정";
            // 
            // tbMemoryLength
            // 
            this.tbMemoryLength.Location = new System.Drawing.Point(333, 64);
            this.tbMemoryLength.MaxLength = 4;
            this.tbMemoryLength.Name = "tbMemoryLength";
            this.tbMemoryLength.Size = new System.Drawing.Size(80, 21);
            this.tbMemoryLength.TabIndex = 6;
            this.tbMemoryLength.Text = "1";
            // 
            // tbQueryNumber
            // 
            this.tbQueryNumber.Location = new System.Drawing.Point(104, 28);
            this.tbQueryNumber.MaxLength = 4;
            this.tbQueryNumber.Name = "tbQueryNumber";
            this.tbQueryNumber.Size = new System.Drawing.Size(81, 21);
            this.tbQueryNumber.TabIndex = 3;
            this.tbQueryNumber.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "메모리 범위";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "펑션 코일";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "통신 쿼리";
            // 
            // tbMemoryStart
            // 
            this.tbMemoryStart.Location = new System.Drawing.Point(105, 64);
            this.tbMemoryStart.MaxLength = 4;
            this.tbMemoryStart.Name = "tbMemoryStart";
            this.tbMemoryStart.Size = new System.Drawing.Size(80, 21);
            this.tbMemoryStart.TabIndex = 5;
            this.tbMemoryStart.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "시작 메모리";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbLeftTime);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.tbRapidCount);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.tbIntervalTx);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.cbxAutoTx);
            this.groupBox5.Controls.Add(this.cbQueryRule);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(598, 444);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(556, 100);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "자동 송신";
            // 
            // lbLeftTime
            // 
            this.lbLeftTime.AutoSize = true;
            this.lbLeftTime.Location = new System.Drawing.Point(437, 67);
            this.lbLeftTime.Name = "lbLeftTime";
            this.lbLeftTime.Size = new System.Drawing.Size(11, 12);
            this.lbLeftTime.TabIndex = 23;
            this.lbLeftTime.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(354, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 12);
            this.label18.TabIndex = 21;
            this.label18.Text = "예상 종료시간";
            // 
            // tbRapidCount
            // 
            this.tbRapidCount.Location = new System.Drawing.Point(276, 63);
            this.tbRapidCount.Name = "tbRapidCount";
            this.tbRapidCount.Size = new System.Drawing.Size(50, 21);
            this.tbRapidCount.TabIndex = 10;
            this.tbRapidCount.Text = "1";
            this.tbRapidCount.TextChanged += new System.EventHandler(this.leftTime_Changed);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(213, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 12);
            this.label17.TabIndex = 19;
            this.label17.Text = "반복 횟수";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(327, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "ms";
            // 
            // tbIntervalTx
            // 
            this.tbIntervalTx.Location = new System.Drawing.Point(276, 28);
            this.tbIntervalTx.Name = "tbIntervalTx";
            this.tbIntervalTx.Size = new System.Drawing.Size(50, 21);
            this.tbIntervalTx.TabIndex = 8;
            this.tbIntervalTx.Text = "1000";
            this.tbIntervalTx.TextChanged += new System.EventHandler(this.leftTime_Changed);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "송신 간격";
            // 
            // cbxAutoTx
            // 
            this.cbxAutoTx.AutoSize = true;
            this.cbxAutoTx.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxAutoTx.Location = new System.Drawing.Point(9, 30);
            this.cbxAutoTx.Name = "cbxAutoTx";
            this.cbxAutoTx.Size = new System.Drawing.Size(184, 16);
            this.cbxAutoTx.TabIndex = 7;
            this.cbxAutoTx.Text = "설정 값에 따라 자동 송신하기";
            this.cbxAutoTx.UseVisualStyleBackColor = true;
            // 
            // cbQueryRule
            // 
            this.cbQueryRule.FormattingEnabled = true;
            this.cbQueryRule.Items.AddRange(new object[] {
            "사용 안함",
            "송신 시",
            "수신 시"});
            this.cbQueryRule.Location = new System.Drawing.Point(125, 64);
            this.cbQueryRule.Name = "cbQueryRule";
            this.cbQueryRule.Size = new System.Drawing.Size(68, 20);
            this.cbQueryRule.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "쿼리 값 자동 올리기";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(598, 38);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(561, 103);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "메모리 테이블";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dudSendedData);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Modbus 통신 분석기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveLog;
        private System.Windows.Forms.ToolStripMenuItem tsmConnect;
        private System.Windows.Forms.ToolStripMenuItem tsmiModbusRtu;
        private System.Windows.Forms.ToolStripMenuItem tsmiModbusTcp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiStart;
        private System.Windows.Forms.ToolStripMenuItem TsmiInfo;
        private System.Windows.Forms.TextBox tbHex;
        private System.Windows.Forms.VScrollBar vsbHex;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog openFileDialog;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbMemoryLength;
        private System.Windows.Forms.TextBox tbMemoryStart;
        private System.Windows.Forms.TextBox tbQueryNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFunctionCoil;
        private System.Windows.Forms.DomainUpDown dudSendedData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.VScrollBar vsbData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbIntervalTx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbxAutoTx;
        private System.Windows.Forms.ComboBox cbQueryRule;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbConnectTime;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbIp;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbRapidCount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbLeftTime;
        private System.Windows.Forms.Label lbErrCount;
        private System.Windows.Forms.Label lbRxCount;
        private System.Windows.Forms.Label lbTxCount;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Timer timer1;
    }
}


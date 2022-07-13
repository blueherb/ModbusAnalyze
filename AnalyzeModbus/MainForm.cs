using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using EasyModbus;

namespace AnalyzeModbus
{
    public partial class MainForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MainForm));
        ModbusClient modbusClient = new ModbusClient();

        public static bool configLoaded = false;
        public static bool configSaved = false;
        public static string rx;
        public static string tx;
        public static string err;
        public static int convertedValue;
        TimeSpan tcpConnectedTime;

        public MainForm()
        {
            InitializeComponent();
        }

        //MainForm 로드 이벤트 발생 시 이전 작업 복구
        private void MainForm_Load(object sender, EventArgs e)
        {
            log.Info("[프로그램 시작]");
            tbQuery.Text = Properties.Settings.Default.queryNumber;
            cbFunctionCoil.Text = Properties.Settings.Default.functionCoil;
            tbMemoryStart.Text = Properties.Settings.Default.startMemory;
            tbMemoryLength.Text = Properties.Settings.Default.memoryLength;

            cbxAutoTx.Checked = Properties.Settings.Default.autoTx;
            tbTxInterval.Text = Properties.Settings.Default.intervalTx;
            cbQueryRule.Text = Properties.Settings.Default.queryRule;
            tbRapidCount.Text = Properties.Settings.Default.rapidCount;
            dudTx.Text = Properties.Settings.Default.sendedData;
            StrCheck(tbQuery.Text);
            StrCheck(cbFunctionCoil.Text);
            StrCheck(tbMemoryStart.Text);
            StrCheck(tbMemoryLength.Text);
            StrCheck(tbTxInterval.Text);
            StrCheck(cbQueryRule.Text);
            StrCheck(tbRapidCount.Text);
            StrCheck(dudTx.Text);

            LeftTime();

            log.Info("*이전 임시설정 복구");
        }
        public static string StrCheck (string value)
        {
            if (value == "")
            {
                value = "1";
            }
            else if (!Int32.TryParse(value, out convertedValue))
            {
                value = "1";
            }
            return value;
        }
        //자동 송신 예상시간 계산
        private void leftTime_Changed(object sender, EventArgs e)
        {
            LeftTime();

        }
        public void LeftTime()
        {
            TimeSpan leftTime = TimeSpan.FromSeconds(Convert.ToDouble(tbTxInterval.Text) / Convert.ToDouble(1000) * Convert.ToDouble(tbRapidCount.Text));
            lbLeftTime.Text = leftTime.ToString(@"hh\-mm\-ss\");
        }

        //ModbusTCP 연결 탭 열기
        private void tsmiModbusTcp_Click(object sender, EventArgs e)
        {
            ModbusTcpForm modbusTcpForm = new ModbusTcpForm();
            if (modbusTcpForm.ShowDialog() == DialogResult.OK)
                log.Info("*ModbusTCP 연결 탭 열림");
        }

        //연결 시 스탯 표시
        public void TcpConnectionStatus()
        {  
            if (modbusClient.Connected)
            {
                timer1.Start();
                lbIp.Text = Config.sTcpIpAddress;
                lbPort.Text = Config.sTcpPort;
                lbMode.Text = "ModbusTCP";
                lbStartTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss");
                lbRxCount.Text = rx;
                lbTxCount.Text = tx;
                lbErrCount.Text = err;
                log.Info("*연결 상태 모니터 활성화");
            }
        }

        //ModbusTCP 통신 시간차 계산
        private void timer1_Tick(object sender, EventArgs e)
        {
            tcpConnectedTime = DateTime.Now - Convert.ToDateTime(lbStartTime.Text);
            Convert.ToDateTime(tcpConnectedTime);
            lbConnectTime.Text = tcpConnectedTime.ToString("dd hh-mm-ss");
        }

        //연결 취소
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected)
            {
                modbusClient.Disconnect();
                timer1.Stop();
                log.Info("*연결 끊음"+"[Mode : ModbusTCP, IP :"+Config.sTcpIpAddress+", Port : "+Config.sTcpIpAddress
                +"Connected time : "+lbConnectTime.Text+"]");
            }

        }
        //설정 저장
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            configSaved = true;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.Title = "현재 설정 저장하기";
            saveFileDialog.Filter = "ini File(*.ini)|*.ini";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Config.sINIPath = saveFileDialog.FileName;
                Config.SaveIniFile();
                Config.ReadUpdatingInfo();
                log.Info("*설정 파일 저장완료");
            }
        }

        //설정 불러오기
        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            configLoaded = true;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Title = "이전 설정 불러오기";
            openFileDialog.Filter = "ini File(*.ini)|*.ini";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Config.sINIPath = openFileDialog.FileName;
                Config.LoadIniFile();
                Config.WriteUpdatingInfo(true);
                log.Info("*설정 파일 로드완료");
            }
        }

        //프로그램 종료 이벤트
        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            log.Info("[프로그램 종료]"+ Environment.NewLine);
        }


    }
}

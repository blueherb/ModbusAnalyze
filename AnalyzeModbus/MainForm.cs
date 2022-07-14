using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using log4net;
using EasyModbus;
using System.Globalization;

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
        public static int intValue;
        private string timeNow = DateTime.Now.ToString("yyMMddHHmmss");
        private string timeDifference;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormPropertyLoad()
        {
            tbQueryNumber.Text = Properties.Settings.Default.queryNumber;
            cbFunctionCoil.Text = Properties.Settings.Default.functionCoil;
            tbMemoryStart.Text = Properties.Settings.Default.memoryStart;
            tbMemoryLength.Text = Properties.Settings.Default.memoryLength;

            cbxAutoTx.Checked = Properties.Settings.Default.autoTx;
            tbIntervalTx.Text = Properties.Settings.Default.intervalTx;
            cbQueryRule.Text = Properties.Settings.Default.queryRule;
            tbRapidCount.Text = Properties.Settings.Default.rapidCount;

            dudSendedData.Text = Properties.Settings.Default.sendedData;
        }
        private void MainFormPropertySave()
        {
            Properties.Settings.Default.queryNumber = tbQueryNumber.Text;
            Properties.Settings.Default.functionCoil = cbFunctionCoil.Text;
            Properties.Settings.Default.memoryStart = tbMemoryStart.Text;
            Properties.Settings.Default.memoryLength = tbMemoryLength.Text;

            Properties.Settings.Default.autoTx = cbxAutoTx.Checked;
            Properties.Settings.Default.intervalTx = tbIntervalTx.Text;
            Properties.Settings.Default.queryRule = cbQueryRule.Text;
            Properties.Settings.Default.rapidCount = tbRapidCount.Text;

            Properties.Settings.Default.sendedData = dudSendedData.Text;
            Properties.Settings.Default.Save();
        }
        private void MainFormConfigLoad()
        {
            tbQueryNumber.Text = Config.sQueryNumber;
            cbFunctionCoil.Text = Config.sFunctionCoil;
            tbMemoryStart.Text = Config.sMemoryStart;
            tbMemoryLength.Text = Config.sMemoryLength;

            cbxAutoTx.Checked = Convert.ToBoolean(Config.sAutoTx);
            tbIntervalTx.Text = Config.sIntervalTx;
            cbQueryRule.Text = Config.sQueryRule;
            tbRapidCount.Text = Config.sRapidCount;

            dudSendedData.Text = Config.sSendedData;
        }
        private void MainFormConfigSave()
        {
            Config.sQueryNumber = tbQueryNumber.Text;
            Config.sFunctionCoil = cbFunctionCoil.Text;
            Config.sMemoryStart = tbMemoryStart.Text;
            Config.sMemoryLength = tbMemoryLength.Text;

            Config.sAutoTx = Convert.ToString(cbxAutoTx.Checked);
            Config.sIntervalTx = tbIntervalTx.Text;
            Config.sQueryRule = cbQueryRule.Text;
            Config.sRapidCount = tbRapidCount.Text;

            Config.sSendedData = dudSendedData.Text;
        }

        //ModbusTCP 연결 탭 열기
        private void tsmiModbusTcp_Click(object sender, EventArgs e)
        {
            ModbusTcpForm modbusTcpForm = new ModbusTcpForm();
            if (modbusTcpForm.ShowDialog() == DialogResult.OK)
                log.Info("*ModbusTCP 연결 탭 열림");
        }

        //MainForm 로드 이벤트 발생 시 이전 작업 복구
        private void MainForm_Load(object sender, EventArgs e)
        {
            log.Info("[프로그램 시작]");
            MainFormPropertyLoad();
            log.Info("*이전 임시설정 복구");
        }
       
        //오류없이 str -> int 변환
        public static int Str2int (string str)
        {
            int num = (int.TryParse(str, out num) == true) ? num :  0;
            return num;
        }

        //자동 송신 예상시간 계산 ("왜인진 모르겠지만 작동 안함.")
        private void leftTime_Changed(object sender, EventArgs e)
        {
            TextRestriction(tbIntervalTx.Text, "dec");
            TextRestriction(tbRapidCount.Text, "dec");
            int leftTime = Str2int(tbIntervalTx.Text) * Str2int(tbRapidCount.Text) / 1000;
       
            string leftTime_D = Convert.ToString(leftTime / 86400)+"일 ";
            string leftTime_H = Convert.ToString(leftTime % 86400 / 3600)+"시간 ";
            string leftTime_M = Convert.ToString(leftTime % 86400 % 3600 / 60)+"분 ";
            string leftTime_S = Convert.ToString(leftTime % 86400 % 3600 % 60 % 60)+"초";
            lbLeftTime.Text =leftTime_D + leftTime_H + leftTime_M + leftTime_S;
            
            if (leftTime/ 86400 >= 7)
            {
                tbIntervalTx.Text = "1000";
                tbRapidCount.Text = "1";
                MessageBox.Show("7일보다 더 길게 통신할 수 없습니다!");
            }
        }

        //Dec 입력 유연대처
        public static string TextRestriction(string str, string mode)
        {
            log.Debug("텍스트 보정 발동!!");
            if (Str2int(str) == 0 && mode == "dec")
            {
                str = Regex.Replace(str, @"[^0-9]", "");
                log.Debug("정수 보정!!");
                return str;
            }
            else if (Str2int(str) == 0 && mode == "hex")
            {
                str = Regex.Replace(str, @"[^0-9A-F]", "");
                log.Debug("16진수 보정!!");
                return str;
            }
            else if (Str2int(str) == 0 && mode == "ip")
            {
                str = Regex.Replace(str, @"(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){ 3}", "");
                log.Debug("IP 보정!!");
                return str;
            }
            else
            {
                log.Debug("보정이 필요없음!!");
                return str;
            } 

        }
        //시간 차 구하기 ("시간차 안구함")
        public string TimeDifference(string now, string before)
        {
            timeDifference = (Convert.ToDateTime(now) - Convert.ToDateTime(before)).ToString("yy MM dd HH mm ss");
            return timeDifference;
        }

        //ModbusTCP 통신 진행시간 계산
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeDifference(lbStartTime.Text, timeNow);
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
                lbStartTime.Text = timeNow;
                lbConnectTime.Text = timeDifference;
                lbRxCount.Text = rx;
                lbTxCount.Text = tx;
                lbErrCount.Text = err;
                log.Info("*연결 상태 모니터 활성화");
            }
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
            MainFormConfigSave();
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
                MainFormConfigLoad();
                log.Info("*설정 파일 로드완료");
            }
        }

        //프로그램 종료 이벤트
        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            log.Info("*사용자 임시설정 저장 중...");
            MainFormPropertySave();
            log.Info("[프로그램 종료]"+ Environment.NewLine);
        }


    }
}

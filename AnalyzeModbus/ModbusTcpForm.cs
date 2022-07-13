using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using log4net;

namespace AnalyzeModbus
{
    public partial class ModbusTcpForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ModbusTcpForm));
        ModbusClient modbusClient = new ModbusClient();
        MainForm mainForm = new MainForm();
        bool valueChanged = false;
        public ModbusTcpForm()
        {
            InitializeComponent();
        }

        //연결 설정의 값을 변형하면 True.
        private void Tb_Changed(object sender, EventArgs e)
        {
            valueChanged = false;
        }

        //이전에 입력했던 주소를 자동으로 불러오기
        //만일 설정을 이미 불러온 경우, 해당 설정으로 입력
        private void ModbusTcpForm_Load(object sender, EventArgs e)
        {
            if (MainForm.configLoaded == true)
                valueChanged = false;

            if (MainForm.configLoaded == true && valueChanged == false)
            {
                tbTcpIpAddress.Text = Config.sTcpIpAddress;
                tbTcpPort.Text = Config.sTcpPort;
                log.Info("*연결 설정 불러옴");
            }
            else
            {
                tbTcpIpAddress.Text = Properties.Settings.Default.ip;
                tbTcpPort.Text = Properties.Settings.Default.port;
                log.Info("*임시 연결 설정 불러옴");
            }
        }

        //임시, 영구 설정값 저장 및 연결
        public void btnConnect_Click(object sender, EventArgs e)
        {
            Config.sTcpIpAddress = tbTcpIpAddress.Text;
            Config.sTcpPort = tbTcpPort.Text;

            Properties.Settings.Default.ip = tbTcpIpAddress.Text;
            Properties.Settings.Default.port = tbTcpPort.Text;
            Properties.Settings.Default.Save();
            try
            {
                modbusClient.IPAddress = tbTcpIpAddress.Text;
                modbusClient.Port = Convert.ToInt32(tbTcpPort.Text);
                modbusClient.Connect();
                mainForm.TcpConnectionStatus();
                MainForm.configLoaded = false;
                log.Info("*연결 성공"+"[Mode : ModbusTCP, IP :" + tbTcpIpAddress.Text + ", Port : " + tbTcpPort.Text+"]");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("연결할 수 없습니다.");
                log.Error("*연결 실패. 사유 -");
            }
        }
        //연결 시도를 포기하고 창을 닫을 경우 적어놓은 데이터를 저장.
        private void ModbusTcpForm_Close(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.ip = tbTcpIpAddress.Text;
            Properties.Settings.Default.port = tbTcpPort.Text;
            Properties.Settings.Default.Save();
            MainForm.configLoaded = false;
            log.Info("*연결 탭 닫음");
        }
    }
}

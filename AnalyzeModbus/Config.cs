using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyzeModbus
{
    public static class Config
    {
        [System.Runtime.InteropServices.DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string sAppName, string sKeyName, string sDefault, StringBuilder sReturnedString, int nSize, string sFileName);

        [System.Runtime.InteropServices.DllImport("kernel32")]
        public static extern int WritePrivateProfileString(string sAppName, string sKeyName, string sValue, string sFileName);

        public static string sINIPath = string.Empty;

        public static string sTcpIpAddress = string.Empty;

        public static string sTcpPort = string.Empty;

        public static string sSendedData = string.Empty;

        public static string sQueryNumber = string.Empty;

        public static string sFunctionCoil = string.Empty;

        public static string sMemoryStart = string.Empty;

        public static string sMemoryLength = string.Empty;

        public static string sIntervalTx = string.Empty;

        public static string sQueryRule = string.Empty;

        public static string sRapidCount = string.Empty;

        public static string sHex = string.Empty;

        public static string sData = string.Empty;

        public static string sAutoTx = string.Empty;


        public static void LoadIniFile()
        {
            StringBuilder Buf = new StringBuilder(1024);

            GetPrivateProfileString("Modbus_TCP_Client", "IP", sTcpIpAddress, Buf, 1024, sINIPath);
            sTcpIpAddress = Buf.ToString();

            GetPrivateProfileString("Modbus_TCP_Client", "Port", sTcpPort, Buf, 1024, sINIPath);
            sTcpPort = Buf.ToString() + Environment.NewLine;

            GetPrivateProfileString("Setting", "쿼리 번호", sQueryNumber, Buf, 1024, sINIPath);
            sQueryNumber = Buf.ToString();

            GetPrivateProfileString("Setting", "펑션 코일", sFunctionCoil, Buf, 1024, sINIPath);
            sFunctionCoil = Buf.ToString();

            GetPrivateProfileString("Setting", "메모리 시작점", sMemoryStart, Buf, 1024, sINIPath);
            sMemoryStart = Buf.ToString();

            GetPrivateProfileString("Setting", "메모리 길이", sMemoryLength, Buf, 1024, sINIPath);
            sMemoryLength = Buf.ToString() + Environment.NewLine;

            GetPrivateProfileString("Auto Tx", "자동 송신", sAutoTx, Buf, 1024, sINIPath);
            sAutoTx = Buf.ToString();

            GetPrivateProfileString("Auto Tx", "쿼리 규칙", sQueryRule, Buf, 1024, sINIPath);
            sQueryRule = Buf.ToString();

            GetPrivateProfileString("Auto Tx", "송신 횟수", sRapidCount, Buf, 1024, sINIPath);
            sRapidCount = Buf.ToString();

            GetPrivateProfileString("Auto Tx", "송신 간격", sIntervalTx, Buf, 1024, sINIPath);
            sIntervalTx = Buf.ToString() + Environment.NewLine;

            GetPrivateProfileString("Data", "송신했던 데이터", sSendedData, Buf, 1024, sINIPath);
            sSendedData = Buf.ToString();

        }

        public static void SaveIniFile()
        {
            WritePrivateProfileString("Modbus_TCP_Client", "IP", sTcpIpAddress, sINIPath);

            WritePrivateProfileString("Modbus_TCP_Client", "Port", sTcpPort, sINIPath);

            WritePrivateProfileString("Setting", "쿼리 번호", sQueryNumber, sINIPath);
         
            WritePrivateProfileString("Setting", "펑션 코일", sFunctionCoil, sINIPath);

            WritePrivateProfileString("Setting", "메모리 시작점", sMemoryStart, sINIPath);

            WritePrivateProfileString("Setting", "메모리 길이", sMemoryLength, sINIPath);

            WritePrivateProfileString("Auto Tx", "자동 송신", sAutoTx, sINIPath);

            WritePrivateProfileString("Auto Tx", "쿼리 규칙", sQueryRule, sINIPath);

            WritePrivateProfileString("Auto Tx", "송신 횟수", sRapidCount, sINIPath);

            WritePrivateProfileString("Auto Tx", "송신 간격", sIntervalTx, sINIPath);

            WritePrivateProfileString("Data", "송신했던 데이터", sSendedData, sINIPath);
        }

        public static void WriteUpdatingInfo(bool b)
        {
            string sVal = b ==true ? "true" : "false";
            WritePrivateProfileString("UPDATE", "UPDATING", sVal + Environment.NewLine, sINIPath);
        }

        public static string ReadUpdatingInfo()
        {
            StringBuilder Buf = new StringBuilder(1024);
            GetPrivateProfileString("UPDATE", "UPDATING", "", Buf, 1024, sINIPath);

            return Buf.ToString();
        }
    }
}

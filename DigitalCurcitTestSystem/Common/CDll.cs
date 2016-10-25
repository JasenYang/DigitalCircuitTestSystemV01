﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CircuitBoardTestSystem;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using DigitalCircuitSystem.DriverDAL;
using DigitalCurcitTestSystem.DriverDAL;

namespace DigitalCircuitSystem.Common
{
    class CDll
    {
        private static string strError;


        [DllImport("kernel32")]
        //section：要读取的段落名
        // key: 要读取的键
        //defVal: 读取异常的情况下的缺省值
        //retVal: key所对应的值，如果该key不存在则返回空值
        //size: 值允许的大小
        //filePath: INI文件的完整路径和文件名
        private static extern int GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32")]
        //section: 要写入的段落名
        //key: 要写入的键，如果该key存在则覆盖写入
        //val: key所对应的值
        //filePath: INI文件的完整路径和文件名
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);


        /*************************************************
      * 函数原型：private string GetContentValueFromFile(string strFilePath,string Section, string key)
      * 函数功能：从ini文件的指定段中指定的key中获取字符串数值信息
      * 输入参数：strFilePath，ini文件的路径信息；Section，段信息；key，key信息。
      * 输出参数：返回获得字符串类型的数值信息
      * 创 建 者：yzx
      * 创建日期：2016.7.23
      * 修改说明：
     */
        public static string GetValueFromIniFile(string strFilePath, string Section, string key)
        {
            int nRntCount;
            StringBuilder temp = new StringBuilder(1024);
            nRntCount = GetPrivateProfileString(Section, key, "", temp, 1024, strFilePath);
            if (nRntCount == 0)
            {
                return null;
            }
            else
            {
                return temp.ToString();
            }

        }

        /*************************************************
         * 函数原型：private long WriteValueToIniFile(string strFilePath,string Section, string key,string strValue)
         * 函数功能：向ini文件的指定段中指定的key中写入字符串数值信息
         * 输入参数：strFilePath，ini文件的路径信息；Section，段信息；key，key信息。
         * 输出参数：
         * 创 建 者：yzx
         * 创建日期：2016.7.23
         * 修改说明：
        */
        public static long WriteValueToIniFile(string strFilePath, string Section, string key, string strValue)
        {

            long error = 0;

            error = WritePrivateProfileString(Section, key, strValue, strFilePath);
            if (error < 0)
            {
                MessageBox.Show("ini文件写入出错！");
            }
            return error;
        }

        /*************************************************
         * 函数原型：private void GetAlltheInstumentsParasFromImiFile()
         * 函数功能：从ini文件中获取所有的仪器的参数信息.
         * 输入参数：
         * 输出参数：
         * 创 建 者：yzx
         * 创建日期：2016.7.23
         * 修改说明：
        */
        public static void GetAlltheInstumentsParasFromIniFile()
        {
            string strPort;
            string strFilePath;
            string strBusType;

            //获取ini文件的相对路径
            strFilePath = System.Windows.Forms.Application.StartupPath + "\\APP_INFOS.ini";
            if (File.Exists(strFilePath))//首先判读INI文件是否存在
            {

                CGloabal.g_InstrPowerModule.ipAdress = GetValueFromIniFile(strFilePath, "电源", "IP地址");
                strPort = GetValueFromIniFile(strFilePath, "电源", "端口号");
                CGloabal.g_InstrPowerModule.port = int.Parse(strPort);

                CGloabal.g_InstrScopeModule.ipAdress = GetValueFromIniFile(strFilePath, "示波器", "IP地址");
                strPort = GetValueFromIniFile(strFilePath, "示波器", "端口号");
                CGloabal.g_InstrScopeModule.port = int.Parse(strPort);

                CGloabal.g_InstrSignalModule.ipAdress = GetValueFromIniFile(strFilePath, "信号发生器", "IP地址");
                strPort = GetValueFromIniFile(strFilePath, "信号发生器", "端口号");
                CGloabal.g_InstrSignalModule.port = int.Parse(strPort);

                CGloabal.g_InstrN5751AModule.ipAdress = GetValueFromIniFile(strFilePath, "N5751A", "IP地址");
                strPort = GetValueFromIniFile(strFilePath, "N5751A", "端口号");
                CGloabal.g_InstrN5751AModule.port = int.Parse(strPort);

                strPort = GetValueFromIniFile(strFilePath, "N3300A", "GPIB地址");
                CGloabal.g_InstrN3300AModule.port = int.Parse(strPort);    
            }
            else
            {
                CCommonFuncs.ShowHintInfor(eHintInfoType.error, "APP_INFOS.ini文件不存在！");
            }
        }
        /*************************************************
         * 函数原型：private void StoreAlltheInstumentsParas2IniFile()
         * 函数功能：将仪器的参数信息保存在ini文件中
         * 输入参数：
         * 输出参数：
         * 创 建 者：yzx
         * 创建日期：2016.7.23
         * 修改说明：
        */
        private static void StoreAlltheInstumentsParas2IniFile()
        {
            string strFileName;
            string strFilePath;

            //获取ini文件的相对路径
            strFilePath = System.Windows.Forms.Application.StartupPath + "\\APP_INFOS.ini";
            if (File.Exists(strFilePath))//先判断INI文件是否存在
            {
                strFileName = Path.GetFileNameWithoutExtension(strFilePath);//获得ini文件名

                WriteValueToIniFile(strFilePath, "电源", "IP地址", CGloabal.g_InstrPowerModule.ipAdress);
                WriteValueToIniFile(strFilePath, "电源", "端口号", CGloabal.g_InstrPowerModule.port.ToString());

                WriteValueToIniFile(strFilePath, "示波器", "IP地址", CGloabal.g_InstrScopeModule.ipAdress);
                WriteValueToIniFile(strFilePath, "示波器", "端口号", CGloabal.g_InstrScopeModule.port.ToString());

                WriteValueToIniFile(strFilePath, "信号发生器", "IP地址", CGloabal.g_InstrSignalModule.ipAdress);
                WriteValueToIniFile(strFilePath, "信号发生器", "端口号", CGloabal.g_InstrSignalModule.port.ToString());

                WriteValueToIniFile(strFilePath, "N5751A", "IP地址", CGloabal.g_InstrN5751AModule.ipAdress);
                WriteValueToIniFile(strFilePath, "N5751A", "端口号", CGloabal.g_InstrN5751AModule.port.ToString());

                WriteValueToIniFile(strFilePath, "N3300A", "IP地址", CGloabal.g_InstrN3300AModule.ipAdress);
                WriteValueToIniFile(strFilePath, "N3300A", "端口号", CGloabal.g_InstrN3300AModule.port.ToString());

            }
            else
            {
                CCommonFuncs.ShowHintInfor(eHintInfoType.error, "APP_INFOS.ini文件不存在！");
            }
        }

        /******************************************************************************************
       * 函数原型：ConnectSpecificInstrument(string strInstruName,string resourceName)
       * 函数功能：根据输入的仪器名进行连接。连接后的句柄存储在相应的句柄参数中
       * 输入参数：strInstruName，仪器名字；resourceName，资源名字，用于VISA连接
       * 输出参数：
       * 创 建 者：yzx
       * 创建日期：2016.7.27
       * 修改说明：
       * */
        public static int ConnectSpecificInstrument(string strInstruName, string resourceName)
        {
            int error = 0;
            if (strInstruName == "电源")
            {
                if (CGloabal.g_InstrPowerModule.nHandle == 0)
                {
                    error = Power_Driver.Init(resourceName, ref CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, strError);
                    if (error < 0)
                    {
                        CGloabal.g_InstrPowerModule.bInternet = false;
                        CCommonFuncs.ShowHintInfor(eHintInfoType.error, CGloabal.g_InstrPowerModule.strInstruName + "连接失败");
                    }
                    else
                    {

                        CGloabal.g_InstrPowerModule.bInternet = true;
                    }
                }
                else
                {
                    CCommonFuncs.ShowHintInfor(eHintInfoType.hint, CGloabal.g_InstrPowerModule.strInstruName + "已经处于连接状态");
                }

            }
            else if (strInstruName == "示波器")
            {
                if (CGloabal.g_InstrScopeModule.nHandle == 0)
                {
                    error = Oscilloscope_Driver.Init(resourceName, CGloabal.g_nSimulteFlag, ref CGloabal.g_InstrScopeModule.nHandle, ref strError);
                    if (error < 0)
                    {
                        CGloabal.g_InstrScopeModule.bInternet = false;
                        CCommonFuncs.ShowHintInfor(eHintInfoType.error, CGloabal.g_InstrScopeModule.strInstruName + "连接失败");
                    }
                    else
                    {
                        CGloabal.g_InstrScopeModule.bInternet = true;
                    }
                }
                else
                {
                    CCommonFuncs.ShowHintInfor(eHintInfoType.hint, CGloabal.g_InstrScopeModule.strInstruName + "已经处于连接状态");
                }

            }
            else if (strInstruName == "信号发生器")
            {
                if (CGloabal.g_InstrSignalModule.nHandle == 0)
                {
                    error = Signal_Driver.Init(resourceName, ref CGloabal.g_InstrSignalModule.nHandle, strError);
                    if (error < 0)
                    {
                        CGloabal.g_InstrPowerModule.bInternet = false;
                        CCommonFuncs.ShowHintInfor(eHintInfoType.error, CGloabal.g_InstrN5751AModule.strInstruName + "连接失败");
                    }
                    else
                    {

                        CGloabal.g_InstrPowerModule.bInternet = true;
                    }
                }
                else
                {
                    CCommonFuncs.ShowHintInfor(eHintInfoType.hint, CGloabal.g_InstrPowerModule.strInstruName + "已经处于连接状态");
                }
            }
            else if (strInstruName == "N5751A")
            {
                if (CGloabal.g_InstrN5751AModule.nHandle == 0)
                {
                    error = N5751A_Driver.Init(resourceName, ref CGloabal.g_InstrN5751AModule.nHandle, CGloabal.g_nSimulteFlag, strError);
                    if (error < 0)
                    {
                        CGloabal.g_InstrPowerModule.bInternet = false;
                        CCommonFuncs.ShowHintInfor(eHintInfoType.error, CGloabal.g_InstrN5751AModule.strInstruName + "连接失败");
                    }
                    else
                    {

                        CGloabal.g_InstrPowerModule.bInternet = true;
                    }
                }
                else
                {
                    CCommonFuncs.ShowHintInfor(eHintInfoType.hint, CGloabal.g_InstrPowerModule.strInstruName + "已经处于连接状态");
                }
            }
            else
            {
                CCommonFuncs.ShowHintInfor(eHintInfoType.error, "错误的仪器名");
                return -1;
            }

            return error;

        }




        /******************************************************************************************
        * 函数原型：CloseSpecificInstrument(string strInstruName)
        * 函数功能：断开指定的仪器的网络连接
        * 输入参数：strInstruName，仪器名字
        * 输出参数：
        * 创 建 者：yzx
        * 创建日期：2016.7.27
        * 修改说明：
        * */
        public static int CloseSpecificInstrument(string strInstruName)
        {
            int error = 0;
            if (strInstruName == "电源")
            {
                if (CGloabal.g_InstrPowerModule.nHandle > 0)
                {
                    error = Power_Driver.Close(CGloabal.g_InstrPowerModule.nHandle, 0, strError);
                    if (error < 0)
                    {

                        CCommonFuncs.ShowHintInfor(eHintInfoType.error, "电源断开失败");
                    }
                    else//断开成功，要将此时的连接状态更新到仪器参数中
                    {
                        CGloabal.g_InstrPowerModule.bInternet = false;
                    }
                }

            }
            else if (strInstruName == "示波器")
            {
                if (CGloabal.g_InstrScopeModule.nHandle > 0)
                {
                    error = Oscilloscope_Driver.Close(CGloabal.g_InstrScopeModule.nHandle, 0, ref strError);
                    if (error < 0)
                    {
                        CCommonFuncs.ShowHintInfor(eHintInfoType.error, "示波器断开失败");

                    }
                    else//断开成功，要将此时的连接状态更新到仪器参数中
                    {
                        CGloabal.g_InstrScopeModule.bInternet = false;
                    }
                }
            }
            else if (strInstruName == "信号发生器")
            {
                if (CGloabal.g_InstrPowerModule.nHandle > 0)
                {
                    error = Signal_Driver.Close(CGloabal.g_InstrSignalModule.nHandle, strError);
                    if (error < 0)
                    {

                        CCommonFuncs.ShowHintInfor(eHintInfoType.error, "信号发生器断开失败");
                    }
                    else//断开成功，要将此时的连接状态更新到仪器参数中
                    {
                        CGloabal.g_InstrPowerModule.bInternet = false;
                    }
                }
            }
            else if (strInstruName == "N5751A")
            {
                if (CGloabal.g_InstrPowerModule.nHandle > 0)
                {
                    error = N5751A_Driver.Close(CGloabal.g_InstrN5751AModule.nHandle, 0, strError);
                    if (error < 0)
                    {

                        CCommonFuncs.ShowHintInfor(eHintInfoType.error, "N5751A断开失败");
                    }
                    else//断开成功，要将此时的连接状态更新到仪器参数中
                    {
                        CGloabal.g_InstrPowerModule.bInternet = false;
                    }
                }
            }           
            else
            {
                CCommonFuncs.ShowHintInfor(eHintInfoType.error, "错误的仪器名");
                return -1;
            }
            return error;
        }

        /******************************************************************************************
         * 函数原型：int SaveInputNetInforsToIniFile(string strInstruName,string strIP,UInt32 port )
         * 函数功能：当用户在界面上正确连接设备后，要将该此时的IP地址和端口号保存到ini文件中并更新仪器的参数信息
         *            这个函数只有在仪器连接成功后，才能调用。
         * 输入参数：strInstruName，仪器名字。
         * 输出参数：
         * 返 回 值：
         * 创 建 者：yzx
         * 创建日期：2016.7.27
         * 修改说明：
         * */
        public static int SaveInputNetInforsToIniFile(string strInstruName, string strIP, UInt32 port)
        {
            string strFilePath;
            //获取ini文件的相对路径
            strFilePath = System.Windows.Forms.Application.StartupPath + "\\APP_INFOS.ini";
            if (File.Exists(strFilePath))//先判断INI文件是否存在
            {
                if (strInstruName == "电源")
                {
                    //保存到ini文件
                    CDll.WriteValueToIniFile(strFilePath, "电源", "IP地址", strIP);
                    CDll.WriteValueToIniFile(strFilePath, "电源", "端口号", port.ToString());
                    //更新当前仪器的参数信息
                    CGloabal.g_InstrPowerModule.ipAdress = strIP;
                    CGloabal.g_InstrPowerModule.port = (int)port;
                    CGloabal.g_InstrPowerModule.bInternet = true;
                }
                else if (strInstruName == "示波器")
                {
                    //保存到ini文件
                    CDll.WriteValueToIniFile(strFilePath, "示波器", "IP地址", strIP);
                    CDll.WriteValueToIniFile(strFilePath, "示波器", "端口号", port.ToString());
                    //更新当前仪器的参数信息
                    CGloabal.g_InstrScopeModule.ipAdress = strIP;
                    CGloabal.g_InstrScopeModule.port = (int)port;
                    CGloabal.g_InstrScopeModule.bInternet = true;
                }
                else if (strInstruName == "信号发生器")
                {
                    //保存到ini文件
                    CDll.WriteValueToIniFile(strFilePath, "信号发生器", "IP地址", strIP);
                    CDll.WriteValueToIniFile(strFilePath, "信号发生器", "端口号", port.ToString());
                    //更新当前仪器的参数信息
                    CGloabal.g_InstrSignalModule.ipAdress = strIP;
                    CGloabal.g_InstrSignalModule.port = (int)port;
                    CGloabal.g_InstrSignalModule.bInternet = true;
                }
                else if (strInstruName == "N5751A")
                {
                    //保存到ini文件
                    CDll.WriteValueToIniFile(strFilePath, "N5715A", "IP地址", strIP);
                    CDll.WriteValueToIniFile(strFilePath, "N5715A", "端口号", port.ToString());
                    //更新当前仪器的参数信息
                    CGloabal.g_InstrN5751AModule.ipAdress = strIP;
                    CGloabal.g_InstrN5751AModule.port = (int)port;
                    CGloabal.g_InstrN5751AModule.bInternet = true;
                }
                else if (strInstruName == "N3300A")
                {
                    //保存到ini文件
                    CDll.WriteValueToIniFile(strFilePath, "N3300A", "IP地址", strIP);
                    CDll.WriteValueToIniFile(strFilePath, "N3300A", "端口号", port.ToString());
                    //更新当前仪器的参数信息
                    CGloabal.g_InstrN3300AModule.ipAdress = strIP;
                    CGloabal.g_InstrN3300AModule.port = (int)port;
                    CGloabal.g_InstrN3300AModule.bInternet = true;
                }
                else
                {
                    MessageBox.Show("错误的仪器名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
            return 0;
        }


        const int BUFF_SIZE = 512;

        static int ScopeDefaultRM;
        static int PowerDefaultRM;
        static int MultimeterDefaultRM;





        /***********************************************************************************
        函数原型：private int WriteCmdToInstrument(int nInstrumentHandle, string StrCmd)  
        函数功能：向仪器写命令
        输入参数：
        输出参数：
        返 回 值：
        */
        public static int WriteCmdToInstrument(int nInstrumentHandle, string StrCmd)
        {
            int retCnt = 0;
            int error = 0;
            error = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(StrCmd), StrCmd.Length, out retCnt);
            return error;
        }

        /***********************************************************************************
        函数原型：ReadDoubleValFromInstrument(int nInstrumentHandle, out double dRtnVal)
        函数功能：从指定的仪器中读数
        输入参数：
        输出参数：
        返 回 值：
        */
        public static int ReadDoubleValFromInstrument(int nInstrumentHandle, out double dRtnVal)
        {
            int error = 0;
            int retCnt;
            byte[] ReadBuf = new byte[100];
            error = visa32.viRead(nInstrumentHandle, ReadBuf, 100, out retCnt);
            if (error < 0)
            {
                dRtnVal = -1.0;
                return error;
            };
            ReadBuf[retCnt] = 0; //字符串结尾加0

            string str = System.Text.Encoding.Default.GetString(ReadBuf);
            dRtnVal = Convert.ToDouble(str);

            return 0;

        }

        /*************************************************
    函数原型：MultimeterModule_Init (ViChar resourceName[],HANDLE *pnHandle,ViString pErrMsg)  
    函数功能：万用表模块初始化
    输入参数：
    输出参数：
    返 回 值：
    */
        public static int MultimeterModule_Init(string resourceName, int nSimulateFlag, ref int pnHandle, ref string pErrMsg)
        {
            int error = 0;

            //检测是否处于模拟状态
            if (nSimulateFlag == 1)
                return 0;


            if ((error = visa32.viOpenDefaultRM(out MultimeterDefaultRM)) < 0)
                return error;

            if ((error = visa32.viOpen(MultimeterDefaultRM, resourceName, 0, 0, out pnHandle)) < 0)
            {
                visa32.viClose(ScopeDefaultRM);
                pnHandle = 0;
                pErrMsg = "万用表模块初始化失败！";
                return error;
            }

            visa32.viSetAttribute(pnHandle, visa32.VI_ATTR_TERMCHAR_EN, visa32.VI_TRUE);//终止符使能
            visa32.viSetAttribute(pnHandle, visa32.VI_ATTR_SEND_END_EN, visa32.VI_TRUE);//终止符使能	
            visa32.viSetAttribute(pnHandle, visa32.VI_ATTR_TERMCHAR, 0xA);//终止符设置0xA

            visa32.viSetBuf(pnHandle, visa32.VI_READ_BUF, 500);//RECVMAXLEN+4

            visa32.viSetAttribute(pnHandle, visa32.VI_ATTR_TMO_VALUE, 2000); //超时2000ms

            return 0;
        }

    }
}

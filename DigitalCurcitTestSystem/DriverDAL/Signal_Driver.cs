using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CircuitBoardTestSystem;

namespace DigitalCurcitTestSystem.DriverDAL
{
     public  class Signal_Driver
    {
        static int SignalDefaultRM;
        const int BUFF_SIZE = 512;

        /*************************************************
        函数原型：Init (ViChar resourceName[],HANDLE *pnHandle,ViString pErrMsg)  
        函数功能：电源模块初始化
        输入参数：
        输出参数：
        返 回 值：
        */
        public static int Init(string resourceName, ref int nHandle,  string pErrMsg)
        {
            int nReturnStatus; //模块化电源底层初始化函数返回状态

            if ((nReturnStatus = visa32.viOpenDefaultRM(out SignalDefaultRM)) < 0)
                return nReturnStatus;

            if ((nReturnStatus = visa32.viOpen(SignalDefaultRM, resourceName, 0, 0, out nHandle)) < 0)
            {
                visa32.viClose(SignalDefaultRM);
                nHandle = 0;
                pErrMsg = "电源模块初始化失败！";
                return nReturnStatus;
            }

            visa32.viSetAttribute(nHandle, visa32.VI_ATTR_TERMCHAR_EN, visa32.VI_TRUE);//终止符使能
            visa32.viSetAttribute(nHandle, visa32.VI_ATTR_SEND_END_EN, visa32.VI_TRUE);//终止符使能	
            visa32.viSetAttribute(nHandle, visa32.VI_ATTR_TERMCHAR, 0xa);//终止符设置0xA

            visa32.viSetBuf(nHandle, visa32.VI_READ_BUF, 500);//RECVMAXLEN+4

            visa32.viSetAttribute(nHandle, visa32.VI_ATTR_TMO_VALUE, 500); //超时2000ms

            return 0;
        }

        //IDN查询
        public static int IDNQuery(int nInstrumentHandle, ref string pErrMsg)
        {
            int error = 0;
            int retCnt;

            string Commands = "*IDN?";
            error = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(Commands), Commands.Length, out retCnt);
            if (error < 0)
            {
                pErrMsg = "设置查询模块ID失败";
                return error;
            }

            //读取
            byte[] byteArray = new byte[100];
            error = visa32.viRead(nInstrumentHandle, byteArray, BUFF_SIZE, out retCnt);

            if (error < 0)
            {
                pErrMsg = "读取电源模块ID失败";
                return error;
            }
            else
            {
                string strIDN = System.Text.Encoding.Default.GetString(byteArray);
                pErrMsg = strIDN;
            }
            return error;

        }

        //复位
        public static int Reset(int nInstrumentHandle, string strErrMsg)
        {
            int status = 0;
            string commands;
            int retCnt;

            commands = "*RST";
            status = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (status < 0)
            {
                strErrMsg = "VISA函数错误!";
                return status;
            }
            return status;
        }

        //CLS
        public static int SetCLS(int nInstrumentHandle, string strErrMsg)
        {
            int status = 0;
            string commands;
            int retCnt;

            commands = "*CLS";
            status = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (status < 0)
            {
                strErrMsg = "VISA函数错误!";
                return status;
            }
            return status;
        }

        //关闭模块
        public static int Close(int nInstrumentHandle,  string strErrMsg)
        {            
            if (nInstrumentHandle == 0)
            {
                strErrMsg = "电源模块已经关闭或初始化失败!";
                return -1;
            }
            if (nInstrumentHandle > 0)
            {
                visa32.viClose(nInstrumentHandle);  //关闭指定的session,事件或查表(find list)
            }
            if (SignalDefaultRM > 0)
            {
                visa32.viClose(SignalDefaultRM);
            }
            return 0;
        }

         //设置信号波形
        public static int SetSin(int nInstrumentHandle, string strErrMsg)
        {
            int status = 0;
            string commands;
            int retCnt;

            commands = ":SOUR:FUNC2:SHAP SIN";
            status = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (status < 0)
            {
                strErrMsg = "波形设置错误!";
                return status;
            }

            commands = ":OUTPUT2:LOAD 50";
            status = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (status < 0)
            {
                strErrMsg = "函数设置错误!";
                return status;
            }
            return status;
        }

        //设置信号频率、电压、偏置
        public static int SetAPPL2RateVoltage(int nInstrumentHandle, double rateValue, double voltValue, double electValue, string strErrMsg)
        {
            int status = 0;
            string commands;
            int retCnt;

            commands = string.Format(":APPL2:SIN {0}MHZ,{1},{2}", rateValue, voltValue, electValue);
            status = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (status < 0)
            {
                strErrMsg = "函数设置错误!";
                return status;
            }
            commands = ":OUTP2:NORM:STATE ON";
            status = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (status < 0)
            {
                strErrMsg = "函数设置错误!";
                return status;
            }

            return status;
        }

        //Load
        public static int setLoad(int nInstrumentHandle, string strErrMsg)
        {
            int status = 0;
            string commands;
            int retCnt;
            commands = ":SOUR:FUNC1:SHAP PULS";
            status = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (status < 0)
            {
                strErrMsg = "函数设置错误!";
                return status;
            }

            commands = ":OUTP1:LOAD 1000";
            status = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (status < 0)
            {
                strErrMsg = "函数设置错误!";
                return status;
            }
            return status;
        }


      
         //设置信号频率、电压、偏置
        public static int SetAPPL1RateVoltage(int nInstrumentHandle,double rateValue,double voltValue,double electValue, string strErrMsg)
        {
            int status = 0;
            string commands;
            int retCnt;

            commands = string.Format(":APPL1:PULS {0}MHZ,{1},{2}", rateValue, voltValue, electValue);
            status = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (status < 0)
            {
                strErrMsg = "函数设置错误!";
                return status;
            }

          
            return status;
        }

       
        //开启
        public static int SetPRBSAndSTAT(int nInstrumentHandle, string strErrMsg)
        {
            int status = 0;
            string commands;
            int retCnt;

            commands = ":DIG1:STIM:PATT:PRBS 31";
            status = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (status < 0)
            {
                strErrMsg = "函数设置错误!";
                return status;
            }

            commands = ":DIG1:STIM:PATT:STAT ON";
            status = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (status < 0)
            {
                strErrMsg = "函数设置错误!";
                return status;
            }
            return status;
        }

    }
}

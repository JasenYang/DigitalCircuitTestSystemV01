using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CircuitBoardTestSystem;

namespace DigitalCircuitSystem.DriverDAL
{
    public class N5751A_Driver
    {
        static int N57551ADefaultRM;
        const int BUFF_SIZE = 512;       
           
        /*************************************************
       函数原型：Init (ViChar resourceName[],HANDLE *pnHandle,ViString pErrMsg)  
       函数功能：电源模块初始化
       输入参数：
       输出参数：
       返 回 值：
       */
        public static int Init(string resourceName, ref int nHandle, int nSimulateFlag, string pErrMsg)
        {
            int nReturnStatus; //模块化电源底层初始化函数返回状态

            //检测是否处于模拟状态
            if (nSimulateFlag == 1)
                return 0;


            if ((nReturnStatus = visa32.viOpenDefaultRM(out N57551ADefaultRM)) < 0)
                return nReturnStatus;

            if ((nReturnStatus = visa32.viOpen(N57551ADefaultRM, resourceName, 0, 0, out nHandle)) < 0)
            {
                visa32.viClose(N57551ADefaultRM);
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
        public static int IDNQuery(int nInstrumentHandle, int nSimulateFlag, ref string pErrMsg)
        {
            int error = 0;
            int retCnt;


            //检测是否处于模拟状态
            if (nSimulateFlag == 1)
                return 0;

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
        public static int Reset(int nInstrumentHandle, int nSimulateFlag, string strErrMsg)
        {
            int status = 0;
            string commands;
            int retCnt;

            //检测是否处于模拟状态
            if (nSimulateFlag == 1)
                return 0;

            commands = "*RST";
            status = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (status < 0)
            {
                strErrMsg = "VISA函数错误!";
                return status;
            }
            return status;
        }

        //关闭模块
        public static int Close(int nInstrumentHandle, int nSimulateFlag, string strErrMsg)
        {

            //检测是否处于模拟状态
            if (nSimulateFlag == 1)
                return 0;


            if (nInstrumentHandle == 0)
            {
                strErrMsg = "电源模块已经关闭或初始化失败!";
                return -1;
            }
            if (nInstrumentHandle > 0)
            {
                visa32.viClose(nInstrumentHandle);  //关闭指定的session,事件或查表(find list)
            }
            if (N57551ADefaultRM > 0)
            {
                visa32.viClose(N57551ADefaultRM);
            }
            return 0;
        }


     

        /*************************************************
      函数原型：isEnableChannel(HANDLE nInstrumentHandle,int nSimulateFlag,int ChanID,int nFlag,ViString pErrMsg)   
      函数功能：是否使能通道
      输入参数： 
      输出参数：
      返 回 值：
      */
        public static int isEnableChannel_N5715A(int nInstrumentHandle, int nSimulateFlag, int nFlag, ref string pErrMsg)
        {
            int error = 0;
            string CmdBuf;


            //检测是否处于模拟状态
            if (nSimulateFlag == 1)
                return 0;

            if (0 == nInstrumentHandle)
            {
                pErrMsg = "已经关闭或初始化失败!";
                return -1;
            }

            //设置
            if (nFlag == 1)
            {
                CmdBuf = string.Format("OUTP ON");
            }
            else
            {
                CmdBuf = string.Format("OUTP OFF");
            }
            error = WriteCmdToInstrument(nInstrumentHandle, CmdBuf);
            if (error < 0)
            {
                pErrMsg = string.Format("设置是否使能通道失败!");
                return error;
            }

            return error;
        }

        /*************************************************
       函数原型：SetOutputVoltage(HANDLE nInstrumentHandle,double dVoltageV,ViString pErrMsg)    
       函数功能：设置电源模块的通道的电压
       输入参数： 
       输出参数：
       返 回 值：
       */
        public static int SetOutputVoltage(int nInstrumentHandle, int nSimulateFlag, double dVoltageV, string pErrMsg)
        {
            int error = 0;
            string CmdBuf;
            int retCnt;


            //检测是否处于模拟状态
            if (nSimulateFlag == 1)
                return 0;


            if (0 == nInstrumentHandle)
            {
                pErrMsg = "已经关闭或初始化失败!";
                return -1;
            }

            //设置
            CmdBuf = string.Format("VOLT {0}", dVoltageV);
            error = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(CmdBuf), CmdBuf.Length, out retCnt);
            if (error < 0)
            {
                pErrMsg = string.Format("设置通道输出电压失败!");
                return error;
            }
            return error;
        }
       /// <summary>
        /// 设定过压保护
       /// </summary>
       /// <param name="nInstrumentHandle"></param>
       /// <param name="nSimulateFlag"></param>
       /// <param name="dVoltageV"></param>
       /// <param name="pErrMsg"></param>
       /// <returns></returns>
        public static int SetProtectVoltage(int nInstrumentHandle, int nSimulateFlag, double dVoltageV, string pErrMsg)
        {
            int error = 0;
            string CmdBuf;
            int retCnt;


            //检测是否处于模拟状态
            if (nSimulateFlag == 1)
                return 0;


            if (0 == nInstrumentHandle)
            {
                pErrMsg = "已经关闭或初始化失败!";
                return -1;
            }

            //设置
            CmdBuf = string.Format("VOLT:PORT:LEV {0}", dVoltageV*1.3);
            error = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(CmdBuf), CmdBuf.Length, out retCnt);
            if (error < 0)
            {
                pErrMsg = string.Format("设置过压保护失败!");
                return error;
            }
            return error;
        }

        /// <summary>
        /// 启动电流保护
        /// </summary>
        /// <param name="nInstrumentHandle"></param>
        /// <param name="nSimulateFlag"></param>
        /// <param name="pErrMsg"></param>
        /// <returns></returns>
        public static int SetStartElectProtect(int nInstrumentHandle, int nSimulateFlag,ref string pErrMsg)
        {
            int error = 0;
            string CmdBuf;
            int retCnt;

            //检测是否处于模拟状态
            if (nSimulateFlag == 1)
                return 0;


            if (0 == nInstrumentHandle)
            {
                pErrMsg = "已经关闭或初始化失败!";
                return -1;
            }

            //设置
            CmdBuf = string.Format("CURR:PORT:STAT");
            error = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(CmdBuf), CmdBuf.Length, out retCnt);
            if (error < 0)
            {
                pErrMsg = string.Format("启动电流保护失败!");
                return error;
            }

            return error;
        }

        /*************************************************
       函数原型： SetMaxElectricityVal(HANDLE nInstrumentHandle,double dValA,ViString pErrMsg)     
       函数功能：设置电源模块的通道的限流保护数值 
       输入参数： dValA,单位A
       输出参数：
       返 回 值：
       */
        public static int SetMaxElectricityVal(int nInstrumentHandle, int nSimulateFlag, double dValA, string pErrMsg)
        {
            int error = 0;
            string CmdBuf;
            int retCnt;

            //检测是否处于模拟状态
            if (nSimulateFlag == 1)
                return 0;


            if (0 == nInstrumentHandle)
            {
                pErrMsg = "已经关闭或初始化失败!";
                return -1;
            }

            //设置
            CmdBuf = string.Format("CURR {0}", dValA);
            error = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(CmdBuf), CmdBuf.Length, out retCnt);
            if (error < 0)
            {
                pErrMsg = string.Format("设置通道{0}的限流保护数值失败!");
                return error;
            }

            return error;
        }

        /// <summary>
        /// 打开电压输出
        /// </summary>
        /// <param name="nInstrumentHandle"></param>
        /// <param name="nSimulateFlag"></param>
        /// <param name="pErrMsg"></param>
        /// <returns></returns>
        public static int SetOPenVoltage(int nInstrumentHandle, int nSimulateFlag, ref string pErrMsg)
        {
            int error = 0;
            string CmdBuf;
            int retCnt;

            //检测是否处于模拟状态
            if (nSimulateFlag == 1)
                return 0;


            if (0 == nInstrumentHandle)
            {
                pErrMsg = "已经关闭或初始化失败!";
                return -1;
            }

            //设置
            CmdBuf = string.Format("OUTP ON");
            error = visa32.viWrite(nInstrumentHandle, System.Text.Encoding.Default.GetBytes(CmdBuf), CmdBuf.Length, out retCnt);
            if (error < 0)
            {
                pErrMsg = string.Format("打开电压输出失败!");
                return error;
            }

            return error;
        }

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
    }
}

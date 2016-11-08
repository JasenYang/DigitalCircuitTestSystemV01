using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CircuitBoardTestSystem;
using System.Threading;
using DigitalCircuitSystem.Common;

namespace DigitalCircuitSystem.DriverDAL
{
     public class N3300A_Driver
    {
        const int BUFF_SIZE = 512;
        static int N3300ADefaultRM;
        static int nN3300AHandle; //N3300A句柄

        public static int Connect_N3300A(string resourceName)
        {
            int nReturnStatus; //模块化电源底层初始化函数返回状态

            if ((nReturnStatus = visa32.viOpenDefaultRM(out N3300ADefaultRM)) < 0)
                return nReturnStatus;
           
            if ((nReturnStatus = visa32.viOpen(N3300ADefaultRM, resourceName, 0, 0, out nN3300AHandle)) < 0)
            {
                visa32.viClose(N3300ADefaultRM);
                nN3300AHandle = 0;
                return nReturnStatus;
            }

            visa32.viSetAttribute(nN3300AHandle, visa32.VI_ATTR_TERMCHAR_EN, visa32.VI_TRUE);//终止符使能
            visa32.viSetAttribute(nN3300AHandle, visa32.VI_ATTR_SEND_END_EN, visa32.VI_TRUE);//终止符使能	
            visa32.viSetAttribute(nN3300AHandle, visa32.VI_ATTR_TERMCHAR, 0xA);//终止符设置0xA
            visa32.viSetBuf(nN3300AHandle, visa32.VI_READ_BUF, 500);//RECVMAXLEN+4
            visa32.viSetAttribute(nN3300AHandle, visa32.VI_ATTR_TMO_VALUE, 2000); //超时2000ms

            return 0;
        }

        //IDN查询
        public static int IDNQuery(out string strIDN)
        {
            int error = 0;
            int retCnt;

            string Commands = "*IDN?";
            error = visa32.viWrite(nN3300AHandle, System.Text.Encoding.Default.GetBytes(Commands), Commands.Length, out retCnt);
            if (error < 0)
            {
                strIDN = string.Empty;
                return error;
            }
            //读取
            byte[] byteArray = new byte[100];
            error = visa32.viRead(nN3300AHandle, byteArray, BUFF_SIZE, out retCnt);
            if (error < 0)
            {
                strIDN = string.Empty;
                return error;
            }
            else
            {
                strIDN = System.Text.Encoding.Default.GetString(byteArray);
            }
            return error;
        }
        //复位
        public static int Reset()
        {
            int error = 0;
            int retCnt;

            string commands = "*RST";
            error = visa32.viWrite(nN3300AHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (error < 0)
            {
                return error;
            }
            Thread.Sleep(6000); //wait the ocillocope to ready
            return error;
        }

        public static int CLS() {
            int error = 0;
            int retCnt;

            string commands = "*CLS";
            error = visa32.viWrite(nN3300AHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (error < 0)
            {
                return error;
            }
            Thread.Sleep(6000); //wait the ocillocope to ready
            return error;
        }

        //关闭模块
        public static int Close()
        {

            if (nN3300AHandle != 0)
            {
                visa32.viClose(nN3300AHandle);  //关闭指定的session,事件或查表(find list)
            }
            if (N3300ADefaultRM != 0)
            {
                visa32.viClose(N3300ADefaultRM);
            }
            return 0;
        }

        //20设置工作模式
        public static int SetWorkMode()
        {
            int error = 0;
            int retCnt;
            string commands = "CNAN 1;:INPUT OFF";
            error = visa32.viWrite(nN3300AHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (error < 0)
            {
                return error;
            }
            

            commands = "FUNC RES";
            error = visa32.viWrite(nN3300AHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (error < 0)
            {
                return error;
            }
            return error;
        }

        //30设置电流保护
        public static int SetElectProtect()
        {
            int error = 0;
            int retCnt = 0;
           // string strVal;

            //设置
            string commands = "CURR:PORT:LEV 2;DEL 0.5";    
            error = visa32.viWrite(nN3300AHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (error < 0)
            {              
                return error;
            }

            ////读取
            //byte[] byteArray = new byte[100];
            //error = visa32.viRead(nN3300AHandle, byteArray, BUFF_SIZE, out retCnt);
            //if (error < 0)
            //{
            //    dVal = -10000.0;
            //    return error;
            //}
            //else
            //{
            //    strVal = System.Text.Encoding.Default.GetString(byteArray);
            //    dVal = Convert.ToDouble(strVal);
            //}
            return error;
        }

         //40 启动保护机制
        public static int SetStartProtectfeature()
        {
            int error = 0;
            int retCnt = 0;
            // string strVal;

            //设置
            string commands = "CURR:PORT:STAT ON";
            error = visa32.viWrite(nN3300AHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (error < 0)
            {
                return error;
            }

            return error;
        }

         //50选择最大电阻
        public static int SelectResistanceRange()
        {
            int error = 0;
            int retCnt = 0;
            // string strVal;

            //设置
            string commands = "RES:RANG 150";
            error = visa32.viWrite(nN3300AHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (error < 0)
            {
                return error;
            }

            return error;
        }

         //60 设置电阻水平
        public static int SetResistanceLevel(double volValue)
        {
            int error = 0;
            int retCnt = 0;
            // string strVal;

            //设置
            string commands = string.Format("RES {0}", volValue);
            error = visa32.viWrite(nN3300AHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (error < 0)
            {
                return error;
            }

            return error;
        }

         //70打开输入
        public static int SetOpenInput()
        {
            int error = 0;
            int retCnt = 0;
            // string strVal;

            //设置
            string commands = "INPUT ON";
            error = visa32.viWrite(nN3300AHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
            if (error < 0)
            {
                return error;
            }
            return error;
        }

         //读取电压直

        public static int  GetVoltageValue(ref double retuenValue, ref double reEleValue)
         {
             int error = 0;
             int retCnt = 0;
             //设置
             string commands = ":MEAS:VOLT?";
             error = visa32.viWrite(nN3300AHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
             if (error<0)
             {
                 return error;
             }
             error = ReadDoubleValFromInstrument(nN3300AHandle, out retuenValue);

             commands = ":MEAS:CURR?";
             error = visa32.viWrite(nN3300AHandle, System.Text.Encoding.Default.GetBytes(commands), commands.Length, out retCnt);
             if (error < 0)
             {
                 return error;
             }
             error = ReadDoubleValFromInstrument(nN3300AHandle, out reEleValue);

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
     }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DigitalCircuitSystem.Common
{
   public class CGloabal
    {
       public class InstrMentsParas
       {
           public string strInstruName;  //仪器名字
           public string ipAdress;      //ip地址
           public int port;             //端口号
           public bool bInternet;       //连接状态， 0断开  1连接
           public int nHandle;        //句柄
           public Image imag;         //各自仪器的图片         


           public InstrMentsParas(string name)
           {
               this.strInstruName = name;
               this.ipAdress = "172.141.10.30";
               this.nHandle = 8000;
               this.bInternet = false;
               this.nHandle = 0; //默认为0

           }
       };

       //定义五个仪器的对象
       public static InstrMentsParas g_InstrPowerModule = new InstrMentsParas("电源");
       public static InstrMentsParas g_InstrScopeModule = new InstrMentsParas("示波器");
       public static InstrMentsParas g_InstrSignalModule = new InstrMentsParas("信号发生器");

       public static InstrMentsParas g_InstrN5751AModule = new InstrMentsParas("N5751A");
       public static InstrMentsParas g_InstrN3300AModule = new InstrMentsParas("N3300A");

       public static InstrMentsParas g_curInstrument; //表征当前正在操作的仪器

       const double EPS = (1e-7);

       public static int g_nSimulteFlag = 0;  //整机模拟状态标示 false,真实状态；true，模拟状态

       public static string strExecuteBeginDir;
    }
}

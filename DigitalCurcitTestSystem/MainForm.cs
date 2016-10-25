using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DigitalCircuitSystem.DriverDAL;
using DigitalCircuitSystem.Common;
using DigitalCircuitSystem.TestForm;

namespace DigitalCurcitTestSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //居中显示
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            //显示应用程序在任务栏中的图标
            this.ShowInTaskbar = true;
            //获取应用程序的运行路径
            CGloabal.strExecuteBeginDir = System.Windows.Forms.Application.StartupPath;
            //从ini文件中读取仪器的参数
            CDll.GetAlltheInstumentsParasFromIniFile();

            //模拟点击该按钮
            button测试仪器管理.PerformClick();
        }

       

        private void button测试仪器管理_Click(object sender, EventArgs e)
        {
            lstResourceManage.Clear();
            lstResourceManage.Dock = DockStyle.None;
            button测试仪器管理.Dock = DockStyle.Top;
            //  lstResourceManage.SendToBack();
            lstResourceManage.Dock = DockStyle.Bottom;
            button被测件管理.SendToBack();
            button被测件管理.Dock = DockStyle.Bottom;

            //根据用户点击的按钮，动态调整lstResourceManage中的显示内容
            lstResourceManage.Items.Add("电源分析仪", "电源分析仪", 0);
            lstResourceManage.Items.Add("示波器", "示波器", 1);
            lstResourceManage.Items.Add("信号发生器", "信号发生器", 3);
            lstResourceManage.Items.Add("电源", "电源", 4);
            lstResourceManage.Items.Add("电子负载", "电子负载", 5);
        }

        private void button被测件管理_Click(object sender, EventArgs e)
        {
            lstResourceManage.Clear();
            lstResourceManage.Dock = DockStyle.None;

            button测试仪器管理.Dock = DockStyle.Top;
            //  button被测件管理.SendToBack();
            button被测件管理.Dock = DockStyle.Bottom;

            lstResourceManage.SendToBack();
            lstResourceManage.Dock = DockStyle.Bottom;

            //根据用户点击的按钮，动态调整lstResourceManage中的显示内容
            lstResourceManage.Items.Add("LVDS031", "LVDS031", 2);
        }

        private void lstResourceManage_Click(object sender, EventArgs e)
        {
            if (lstResourceManage.SelectedItems[0].Name == "电源分析仪")
            {

                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;

                groupBox0.Visible = true;
                groupBox0.Location = new System.Drawing.Point(62, 39);

                //显示当前参数
                CGloabal.g_curInstrument = CGloabal.g_InstrPowerModule;
                ipAddressControl.Text = CGloabal.g_curInstrument.ipAdress;
                Port0.Value = CGloabal.g_curInstrument.port;
                pictureBox1.Image = Properties.Resources.电源;
            }
            else if (lstResourceManage.SelectedItems[0].Name == "示波器")
            {
                groupBox0.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;

                groupBox1.Visible = true;
                groupBox1.Location = new System.Drawing.Point(62, 39);


                //显示当前参数
                CGloabal.g_curInstrument = CGloabal.g_InstrScopeModule;
                ipAddressControl1.Text = CGloabal.g_curInstrument.ipAdress;
                Port1.Value = CGloabal.g_curInstrument.port;               

                pictureBox1.Image = Properties.Resources.示波器;

            }
            else if (lstResourceManage.SelectedItems[0].Name == "信号发生器")
            {
                groupBox0.Visible = false;
                groupBox1.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;

                groupBox2.Visible = true;
                groupBox2.Location = new System.Drawing.Point(62, 39);

                //显示当前参数
                CGloabal.g_curInstrument = CGloabal.g_InstrSignalModule;
                ipAddressControl2.Text = CGloabal.g_curInstrument.ipAdress;
                Port2.Value = CGloabal.g_curInstrument.port;

                pictureBox1.Image = Properties.Resources._81160A;
               
            }
            else if (lstResourceManage.SelectedItems[0].Name == "电源")
            {
                groupBox0.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;

                groupBox3.Visible = true;
                groupBox3.Location = new System.Drawing.Point(62, 39);

                //显示当前参数
                CGloabal.g_curInstrument = CGloabal.g_InstrN5751AModule;
                ipAddressControl3.Text = CGloabal.g_curInstrument.ipAdress;
                Port3.Value = CGloabal.g_curInstrument.port;
                pictureBox1.Image = Properties.Resources.N5751A;
               
            }
            else if (lstResourceManage.SelectedItems[0].Name == "电子负载")
            {

                groupBox0.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox5.Visible = false;

                groupBox4.Visible = true;
                groupBox4.Location = new System.Drawing.Point(62, 39);

                //显示当前参数              
                CGloabal.g_curInstrument = CGloabal.g_InstrN3300AModule;
                pictureBox1.Image = Properties.Resources.N3300A;
            }
            else if (lstResourceManage.SelectedItems[0].Name == "LVDS031")
            {

                //pictureBox1.Image = Properties.Resources.板卡;
                groupBox0.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;

                groupBox5.Visible = true;
                groupBox5.Location = new System.Drawing.Point(62, 39);


            }
        }

     

        private void button0_Click(object sender, EventArgs e)
        {
            string strIP;
            UInt32 nPort;
            string resourceName;
            int error = 0;
            if (button0.Text == "打开")//用户要连接仪器
            {
                strIP = this.ipAddressControl.Text;
                nPort = (UInt32)this.Port0.Value;
                //连接设备
                resourceName = "TCPIP0::" + strIP + "::inst0::INSTR";

                error = CDll.ConnectSpecificInstrument(CGloabal.g_curInstrument.strInstruName, resourceName);
                if (error < 0)//连接失败
                {
                    CCommonFuncs.ShowHintInfor(eHintInfoType.error, "电源打开失败！");
                   button0.Text = "打开";
                }
                else//连接成功,则要将当前用户输入的IP地址和端口号保存到ini文件中
                {
                    CDll.SaveInputNetInforsToIniFile(CGloabal.g_curInstrument.strInstruName, strIP, nPort);
                    button0.Text = "关闭";
                }
            }
            else//此时用户要断开连接
            {
                error = CDll.CloseSpecificInstrument(CGloabal.g_curInstrument.strInstruName);
                if (error < 0)//断开失败，则还要将switchConnect恢复为连接状态      
                {
                    button0.Text = "关闭";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strIP;
            UInt32 nPort;
            string resourceName;
            int error = 0;
            if (button1.Text == "打开")//用户要连接仪器
            {
                strIP = this.ipAddressControl1.Text;
                nPort = (UInt32)this.Port1.Value;
                //连接设备
                resourceName = "TCPIP0::" + strIP + "::inst0::INSTR";

                error = CDll.ConnectSpecificInstrument(CGloabal.g_curInstrument.strInstruName, resourceName);
                if (error < 0)//连接失败
                {
                  CCommonFuncs.ShowHintInfor(eHintInfoType.error, "示波器连接失败！");
                  button1.Text = "打开";

                }
                else//连接成功,则要将当前用户输入的IP地址和端口号保存到ini文件中
                {
                    CDll.SaveInputNetInforsToIniFile(CGloabal.g_curInstrument.strInstruName, strIP, nPort);
                    button1.Text = "关闭";
                }
            }
            else//此时用户要断开连接
            {
                error = CDll.CloseSpecificInstrument(CGloabal.g_curInstrument.strInstruName);
                if (error < 0)//断开失败，则还要将switchConnect恢复为连接状态      
                {
                    button1.Text = "关闭";
                }
            }
        }

        //信号发生器
        private void button2_Click(object sender, EventArgs e)
        {
            string strIP;
            UInt32 nPort;
            string resourceName;
            int error = 0;
            if ( button2.Text == "打开")//用户要连接仪器
            {
                strIP = this.ipAddressControl2.Text;
                nPort = (UInt32)this.Port2.Value;
                //连接设备
                resourceName = "TCPIP0::" + strIP + "::inst0::INSTR";

                error = CDll.ConnectSpecificInstrument(CGloabal.g_curInstrument.strInstruName, resourceName);
                if (error < 0)//连接失败
                {
                    CCommonFuncs.ShowHintInfor(eHintInfoType.error, "信号发生器连接失败！");
                    button2.Text = "打开";
                }
                else//连接成功,则要将当前用户输入的IP地址和端口号保存到ini文件中
                {
                    CDll.SaveInputNetInforsToIniFile(CGloabal.g_curInstrument.strInstruName, strIP, nPort);
                     button2.Text = "关闭";
                }
            }
            else//此时用户要断开连接
            {
                error = CDll.CloseSpecificInstrument(CGloabal.g_curInstrument.strInstruName);
                if (error < 0)//断开失败，则还要将switchConnect恢复为连接状态      
                {
                     button2.Text = "关闭";
                }
            }
        }

        //N5751A
        private void button3_Click(object sender, EventArgs e)
        {
            string strIP;
            UInt32 nPort;
            string resourceName;
            int error = 0;
            if (button3.Text == "打开")//用户要连接仪器
            {
                strIP = this.ipAddressControl3.Text;
                nPort = (UInt32)this.Port3.Value;
                //连接设备
                resourceName = "TCPIP0::" + strIP + "::inst0::INSTR";

                error = CDll.ConnectSpecificInstrument(CGloabal.g_curInstrument.strInstruName, resourceName);
                if (error < 0)//连接失败
                {
                    button3.Text = "打开";
                }
                else//连接成功,则要将当前用户输入的IP地址和端口号保存到ini文件中
                {
                    CDll.SaveInputNetInforsToIniFile(CGloabal.g_curInstrument.strInstruName, strIP, nPort);
                    button3.Text = "关闭";
                }
            }
            else//此时用户要断开连接
            {
                error = CDll.CloseSpecificInstrument(CGloabal.g_curInstrument.strInstruName);
                if (error < 0)//断开失败，则还要将switchConnect恢复为连接状态      
                {
                   button3.Text = "关闭";
                }               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int nGpibAddr = 0;
            int error = 0;
            nGpibAddr = (Int32)GPIBNum.Value;
            string strResource = "GPIB0::" + nGpibAddr + "::INSTR"; // GPIB1 to GPIB0 
            if (button4.Text == "打开")//用户要连接N3300A   
            {
                error = N3300A_Driver.Connect_N3300A(strResource);
                if (error < 0)
                {
                    CCommonFuncs.ShowHintInfor(eHintInfoType.error, "N3300A连接失败！");
                    button4.Text = "打开";
                }
                else
                {
                    button4.Text = "关闭";
                }
            }
            else//断开万用表
            {
                N3300A_Driver.Close();
                button4.Text = "打开";
            }
        }

        private void btnFZTest_Click(object sender, EventArgs e)
        {
            LoadForm LForm = new LoadForm();
            LForm.ShowDialog();
        }

        private void btnYTTest_Click(object sender, EventArgs e)
        {
            EyeDiagramsForm EDForm = new EyeDiagramsForm();
            EDForm.ShowDialog();
        }
    }
}

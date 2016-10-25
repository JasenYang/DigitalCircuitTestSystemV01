using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DigitalCircuitSystem.Common;
using DigitalCircuitSystem.DriverDAL;
using DigitalCurcitTestSystem.DriverDAL;
using System.IO;
using System.Threading;

namespace DigitalCircuitSystem.TestForm
{
    public partial class EyeDiagramsForm : Form
    {
        public EyeDiagramsForm()
        {
            InitializeComponent();

            bgWork.DoWork += bgWork_doWork;
            bgWork.ProgressChanged += bgWork_ProgressChanged;
            bgWork.RunWorkerCompleted +=bgWork_RunWorkerCompleted;

            rate.SelectedIndex = 0;
            double[] la = {1,4,10.23,50,100};
            rate.DataSource = la;
        }

        private void openAllBtn_Click(object sender, EventArgs e)
        {
            int error = 0;
            string strMsg = "";

            for (int ChanID = 1; ChanID <= 4; ChanID++)
            {

                error = Power_Driver.isEnableChannel(CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, ChanID, 1, ref strMsg);
                if (error < 0)
                {
                    strMsg = string.Format("电源通道{0}打开失败", ChanID);
                    CCommonFuncs.ShowHintInfor(eHintInfoType.error, strMsg);
                    return;
                }
                else
                {
                    switch (ChanID)
                    {
                        case 1:
                            error = Power_Driver.SetOutputVoltage(CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, ChanID, (double)volOut1.Value, strMsg);
                            error = Power_Driver.SetMaxElectricityVal(CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, ChanID, (double)eleOut1.Value, strMsg);
                            //SPC1.Value = true;
                            break;
                        case 2:
                            error = Power_Driver.SetOutputVoltage(CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, ChanID, (double)volOut2.Value, strMsg);
                            error = Power_Driver.SetMaxElectricityVal(CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, ChanID, (double)eleOut2.Value, strMsg);
                            //SPC2.Value = true;
                            break;
                        case 3:
                            error = Power_Driver.SetOutputVoltage(CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, ChanID, (double)volOut3.Value, strMsg);
                            error = Power_Driver.SetMaxElectricityVal(CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, ChanID, (double)eleOut3.Value, strMsg);
                            //SPC3.Value = true;
                            break;
                        case 4:
                            error = Power_Driver.SetOutputVoltage(CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, ChanID, (double)volOut4.Value, strMsg);
                            error = Power_Driver.SetMaxElectricityVal(CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, ChanID, (double)eleOut4.Value, strMsg);
                           // SPC4.Value = true;
                            break;
                    }

                }

            }
        }

        private void closeAllBtn_Click(object sender, EventArgs e)
        {
            int error = 0;
            string strMsg = "";
            for (int ChanID = 1; ChanID <= 4; ChanID++)
            {
                error = Power_Driver.isEnableChannel(CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, ChanID, 0, ref strMsg);
                if (error < 0)
                {
                    CCommonFuncs.ShowHintInfor(eHintInfoType.error, strMsg);
                }
                else
                {
                    switch (ChanID)
                    {
                        case 1:
                          //  SPC1.Value = false;
                            break;
                        case 2:
                           // SPC2.Value = false;
                            break;
                        case 3:
                         //   SPC3.Value = false;
                            break;
                        case 4:
                          //  SPC4.Value = false;
                            break;
                    }
                }
            }
        }

        private void runCurBtn_Click(object sender, EventArgs e)
        {
            string strMsg = "";
            int error = 0;
            if (pupleFirstCB.Checked == true)
            {
                error = Power_Driver.isEnableChannel(CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, 1, 1, ref strMsg);
                if (error < 0)
                {
                    CCommonFuncs.ShowHintInfor(eHintInfoType.error, strMsg);
                }
                else
                {
                    //SPC1.Value = true;
                }
            }

            if (pupleSecondCB.Checked == true)
            {
                error = Power_Driver.isEnableChannel(CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, 2, 1, ref strMsg);
                if (error < 0)
                {
                    CCommonFuncs.ShowHintInfor(eHintInfoType.error, strMsg);
                }
                else
                {
                    //SPC2.Value = true;
                }
            }

            if (pupleThirdCB.Checked == true)
            {
                error = Power_Driver.isEnableChannel(CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, 3, 1, ref strMsg);
                if (error < 0)
                {
                    CCommonFuncs.ShowHintInfor(eHintInfoType.error, strMsg);
                }
                else
                {
                    //SPC3.Value = true;
                }
            }
            if (pupleFourthCB.Checked == true)
            {
                error = Power_Driver.isEnableChannel(CGloabal.g_InstrPowerModule.nHandle, CGloabal.g_nSimulteFlag, 4, 1, ref strMsg);
                if (error < 0)
                {
                    CCommonFuncs.ShowHintInfor(eHintInfoType.error, strMsg);
                }
                else
                {
                    //SPC4.Value = true;
                }
            }
        }

        double rateValue;
        private void btnSet_Click(object sender, EventArgs e)
        {
            rateValue = double.Parse(rate.Text.ToString());
            bgWork.RunWorkerAsync();
        }

        public  string  PicName = "";
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog afd = new SaveFileDialog();
            afd.Filter = "图片文件(*.jpg)|*.jpg";
            afd.FilterIndex = 1;
            afd.RestoreDirectory = true;
            if (afd.ShowDialog()==DialogResult.OK)
	        {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(PicName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else
                {
                    MessageBox.Show("没有结果可以保存！");
                    return;
                }
	        } 
        }

        public void bgWork_doWork(object sender ,DoWorkEventArgs e)
        {
            string ErrMsg = "";
            int error;
            
            double voltValue = (double)volt.Value;
            double electValue = (double)elect.Value;
            error = Signal_Driver.Reset(CGloabal.g_InstrSignalModule.nHandle, ErrMsg);
            if (error < 0)
            {
                MessageBox.Show("命令出错！");
                return;
            }
            error = Signal_Driver.SetCLS(CGloabal.g_InstrSignalModule.nHandle, ErrMsg);
            if (error < 0)
            {
                MessageBox.Show("命令出错！");
                return;
            }
            error = Signal_Driver.SetSin(CGloabal.g_InstrSignalModule.nHandle, ErrMsg);
            if (error < 0)
            {
                MessageBox.Show("命令出错！");
                return;
            }
            error = Signal_Driver.SetAPPL2RateVoltage(CGloabal.g_InstrSignalModule.nHandle, rateValue, voltValue, 0, ErrMsg);
            if (error < 0)
            {
                MessageBox.Show("命令出错！");
                return;
            }
            error = Signal_Driver.setLoad(CGloabal.g_InstrSignalModule.nHandle, ErrMsg);
            if (error < 0)
            {
                MessageBox.Show("命令出错！");
                return;
            }
            bgWork.ReportProgress(20);
            error = Signal_Driver.SetAPPL1RateVoltage(CGloabal.g_InstrSignalModule.nHandle, rateValue, voltValue, electValue, ErrMsg);
            if (error < 0)
            {
                MessageBox.Show("命令出错！");
                return;
            }
            error = Signal_Driver.SetPRBSAndSTAT(CGloabal.g_InstrSignalModule.nHandle, ErrMsg);
            if (error < 0)
            {
                MessageBox.Show("命令出错！");
                return;
            }

            //自动测试示波器
          

            error = Oscilloscope_Driver.Reset(CGloabal.g_InstrScopeModule.nHandle, 0, ErrMsg);
            if (error < 0)
            {
                MessageBox.Show("命令出错！");
                return;
            }

            DialogResult dr = MessageBox.Show(" 1、请确认81160A通道2与示波器通道4相连\n 2、请确认81160A与被测件输入信号相连", "提示", MessageBoxButtons.OK);
            if (dr == DialogResult.OK)
            {
                error = Oscilloscope_Driver.SetTick(CGloabal.g_InstrScopeModule.nHandle, ErrMsg);
                if (error < 0)
                {
                    MessageBox.Show("命令出错！");
                    return;
                }
                error = Oscilloscope_Driver.UpdateAxis(CGloabal.g_InstrScopeModule.nHandle, ErrMsg);
                if (error < 0)
                {
                    MessageBox.Show("命令出错！");
                    return;
                }
                if (rateValue == 100)
                {
                    error = Oscilloscope_Driver.UpdateTimeBase(CGloabal.g_InstrScopeModule.nHandle,25E-9, ErrMsg);
                }
                else if (rateValue == 1) {
                    error = Oscilloscope_Driver.UpdateTimeBase(CGloabal.g_InstrScopeModule.nHandle, 2500E-9, ErrMsg);
                }
                else if (rateValue == 4)
                {
                    error = Oscilloscope_Driver.UpdateTimeBase(CGloabal.g_InstrScopeModule.nHandle, 600E-9, ErrMsg);
                }
                else if (rateValue == 10.23)
                {
                    error = Oscilloscope_Driver.UpdateTimeBase(CGloabal.g_InstrScopeModule.nHandle, 200E-9, ErrMsg);
                }
                else if (rateValue == 50)
                {
                    error = Oscilloscope_Driver.UpdateTimeBase(CGloabal.g_InstrScopeModule.nHandle, 50E-9, ErrMsg);
                }
                
                if (error < 0)
                {
                    MessageBox.Show("命令出错！");
                    return;
                }
                bgWork.ReportProgress(40);
               
            }
            else
            {

            }
        
            DialogResult dr2 = MessageBox.Show("1、请确认示波器1、3通道与被测件信号相连\n2、请确认被测件信号显示正常", "提示", MessageBoxButtons.OK);
            if (dr == DialogResult.OK)
            {
                error = Oscilloscope_Driver.SetMaxShow(CGloabal.g_InstrScopeModule.nHandle, ErrMsg);
                if (error < 0)
                {
                    MessageBox.Show("命令出错！");
                    return;
                }
                error = Oscilloscope_Driver.SetStartRun(CGloabal.g_InstrScopeModule.nHandle, ErrMsg);
                if (error < 0)
                {
                    MessageBox.Show("命令出错！");
                    return;
                }              
                bgWork.ReportProgress(70);
                error = Oscilloscope_Driver.SetStopRun(CGloabal.g_InstrScopeModule.nHandle, ErrMsg);
                if (error < 0)
                {
                    MessageBox.Show("命令出错！");
                    return;
                }

                PicName = "ED" + System.DateTime.Now.ToString("yyyyMMddHHmmss");
                error = Oscilloscope_Driver.SavePictureUrl(CGloabal.g_InstrScopeModule.nHandle, PicName, ErrMsg);
                if (error < 0)
                {
                    MessageBox.Show("命令出错！");
                    return;
                }

                bgWork.ReportProgress(90);
                Thread.Sleep(2000);
                bgWork.ReportProgress(100);
            }
            else
            {
                MessageBox.Show("不可取消");
                return;
            }          
        }
        public void bgWork_ProgressChanged(object sender ,ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            if(e.ProgressPercentage!=100)
            {
                label14.Text = "正在进行测试中(" + e.ProgressPercentage + "%)...";
            }else{
                label14.Text = "测试结束(" + e.ProgressPercentage + "%)...";
            }          
        }
        public void bgWork_RunWorkerCompleted(object sender ,RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"\\169.254.57.10\New folder\" + PicName + ".jpg");
        }
    }
}

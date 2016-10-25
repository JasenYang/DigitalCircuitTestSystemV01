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
using System.Windows.Forms.DataVisualization.Charting;

namespace DigitalCircuitSystem.TestForm
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();

            //初始化chart
            #region           
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            chart1.Series[0].BorderWidth = 2;

            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;          

            chart1.Series[0].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chart1.Series[0].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;

            chart1.Series[1].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chart1.Series[1].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            #endregion

            #region  
            bgWork.DoWork += bgWork_doWork;
            bgWork.ProgressChanged += bgWork_ProgressChanged;
            bgWork.RunWorkerCompleted += bgWork_RunWorkerCompleted;
            #endregion

            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;

            label27.Visible = false;
            label26.Visible = false;
            label25.Visible = false;
            label24.Visible = false;
            label23.Visible = false;
            label22.Visible = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            int error = 0;
            string strMsg = "";

            error = N5751A_Driver.isEnableChannel_N5715A(CGloabal.g_InstrN5751AModule.nHandle, CGloabal.g_nSimulteFlag, 1, ref strMsg);
            if (error < 0)
            {
                strMsg = string.Format("电源通道打开失败");
                CCommonFuncs.ShowHintInfor(eHintInfoType.error, strMsg);
                return;
            }
            else
            {
                error = N5751A_Driver.SetOutputVoltage(CGloabal.g_InstrN5751AModule.nHandle, CGloabal.g_nSimulteFlag, (double)volOut1.Value, strMsg);
                error = N5751A_Driver.SetMaxElectricityVal(CGloabal.g_InstrN5751AModule.nHandle, CGloabal.g_nSimulteFlag, (double)eleOut1.Value, strMsg);                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            int error = 0;
            string strMsg = "";

            error = N5751A_Driver.isEnableChannel_N5715A(CGloabal.g_InstrN5751AModule.nHandle, CGloabal.g_nSimulteFlag, 0, ref strMsg);
            if (error < 0)
            {
                CCommonFuncs.ShowHintInfor(eHintInfoType.error, strMsg);
            }
            else
            {
                   
            }           
        }

        
        double[] yVol;
        double[] yEle;
        private void button3_Click(object sender, EventArgs e)
        {
            int error;
            double reVolValue = 0;
            double reEleValue = 0;
            double ResistValue  =(double)resistValue.Value;
            int circleNum =(int)CycNums.Value;
            yVol = new double[circleNum];
            yEle = new double[circleNum];
            #region 执行N3300A指令
            //error = N3300A_Driver.Reset();
            //error = N3300A_Driver.CLS();
            //error = N3300A_Driver.SetWorkMode();
            //if (error<0)
            //{
            //    MessageBox.Show("命令出错！");
            //    return;
            //}
            //error = N3300A_Driver.SetElectProtect();
            //if (error < 0)
            //{
            //    MessageBox.Show("命令出错！");
            //    return;
            //}
            //error = N3300A_Driver.SetStartProtectfeature();
            //if (error < 0)
            //{
            //    MessageBox.Show("命令出错！");
            //    return;
            //}
            //error = N3300A_Driver.SelectResistanceRange();
            //if (error < 0)
            //{
            //    MessageBox.Show("命令出错！");
            //    return;
            //}
            //error = N3300A_Driver.SetResistanceLevel(ResistValue);
            //if (error < 0)
            //{
            //    MessageBox.Show("命令出错！");
            //    return;
            //}
            //error = N3300A_Driver.SetOpenInput();
            //if (error < 0)
            //{
            //    MessageBox.Show("命令出错！");
            //    return;
            //}
            #endregion 

            chart1.ChartAreas[0].AxisX.Maximum = (int)CycNums.Value;     
            chart1.ChartAreas[0].AxisY.Maximum = ((int)volOut1.Value) * 2;

            bgWork.RunWorkerAsync();
        }
        

        public void bgWork_doWork(object sender, DoWorkEventArgs e)
        {
            int error;
            double reVolValue = 0;
            double reEleValue = 0;
            double ResistValue = (double)resistValue.Value;
            int circleNum = (int)CycNums.Value;
            bgWork.ReportProgress(10);
            #region 执行N3300A指令
            
            error = N3300A_Driver.Reset();
            error = N3300A_Driver.CLS();
            error = N3300A_Driver.SetWorkMode();
            if (error < 0)
            {
                MessageBox.Show("命令出错！");
                return;
            }
            error = N3300A_Driver.SetElectProtect();
            if (error < 0)
            {
                MessageBox.Show("命令出错！");
                return;
            }
            error = N3300A_Driver.SetStartProtectfeature();
            if (error < 0)
            {
                MessageBox.Show("命令出错！");
                return;
            }
            error = N3300A_Driver.SelectResistanceRange();
            if (error < 0)
            {
                MessageBox.Show("命令出错！");
                return;
            }
            error = N3300A_Driver.SetResistanceLevel(ResistValue);
            if (error < 0)
            {
                MessageBox.Show("命令出错！");
                return;
            }
            error = N3300A_Driver.SetOpenInput();
            if (error < 0)
            {
                MessageBox.Show("命令出错！");
                return;
            }
            #endregion 
            

            for (int i = 0; i < circleNum; i++)
            {
                error = N3300A_Driver.GetVoltageValue(ref reVolValue, ref reEleValue);
                if (error >= 0)
                {
                    yVol[i] = reVolValue;
                    yEle[i] = reEleValue;
                   // chart1.Series[0].Points.AddXY(i, reVolValue, reEleValue);   
                    if(circleNum>=100){
                      bgWork.ReportProgress(40);
                    }else{
                        bgWork.ReportProgress(i);
                    }                   
                }
                else
                {
                    MessageBox.Show("命令出错！");
                    return;
                }               
            }
        }
        public void bgWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label13.Text = "正在测试中(" + e.ProgressPercentage + "%)...";

        }
        public void bgWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            for (int i = 0; i < yVol.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, yVol[i]);
                chart1.Series[1].Points.AddXY(i, yEle[i]);
            }
            double AvgVol = 0, MaxVol = yVol[0], MinVol = yVol[0];
            double AvgEle = 0, MaxEle = yEle[0], MinEle = yEle[0];
            for (int i = 0; i < yVol.Length; i++)
            {
                AvgVol += yVol[i];                             
                MaxVol = Math.Max(yVol[i], MaxVol);
                MinVol = Math.Min(yVol[i], MinVol);

                AvgEle += yEle[i];
                MaxEle = Math.Max(yEle[i], MaxEle);
                MinEle = Math.Min(yEle[i], MinEle);               
            }
            AvgVol = AvgVol / yVol.Length;
            AvgEle = AvgEle / yVol.Length;

            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label19.Text = AvgVol.ToString("0.0000") + "V";
            label20.Text = MaxVol.ToString("0.0000") + "V";
            label21.Text = MinVol.ToString("0.0000") + "V";

            label27.Visible = true;
            label26.Visible = true;
            label25.Visible = true;
            label24.Visible = true;
            label23.Visible = true;
            label22.Visible = true;
            label24.Text = AvgEle.ToString("0.0000") + "A";
            label23.Text = MaxEle.ToString("0.0000") + "A";
            label22.Text = MinEle.ToString("0.0000") + "A";

            progressBar1.Value = 100;
            label13.Text = "测试结束(100%)...";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //保存Chart
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "负载测试结果" + System.DateTime.Now.ToString("yyyyMMddHHmmss");
            saveFile.Filter="Bitmap (*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;
            if(saveFile.ShowDialog() ==DialogResult.OK){              
               chart1.SaveImage(saveFile.FileName, ChartImageFormat.Jpeg);
            }           
        }        
    }
}

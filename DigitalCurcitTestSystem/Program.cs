using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigitalCurcitTestSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isAppRunning = false;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, System.Diagnostics.Process.GetCurrentProcess().ProcessName, out isAppRunning);
            if (!isAppRunning)
            {
                MessageBox.Show("程序已经处于运行状态，请不要重复运行","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(1);
            }
            else {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            
        }
    }
}

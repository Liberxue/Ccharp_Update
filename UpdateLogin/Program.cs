using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpdateLogin.UpdateClass;

namespace UpdateLogin
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string proc = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(proc);
            if (processes.Length == 2)
            {
                Application.Exit();
                Application.ExitThread();
                return;
            }
            ServerInfor ser=new ServerInfor();
            try
            {
                VersionHelper ver = new VersionHelper();
                ser = ver.GetUpdateFile(System.AppDomain.CurrentDomain.BaseDirectory + "Update.ini");
                if (ser != null)
                {
                    if (ser.DownloadFileList.Count == 0)
                    {
                        Application.Exit();
                        Application.ExitThread();
                        Process.Start(ser.Application);
                    }
                    else
                        Application.Run(new UpdatePrecent(ser));
                }
                else
                {
                    MessageBox.Show("缺少配置文件：Update.ini，启动程序失败！");
                    Application.Exit();
                    Application.ExitThread();
                }
            }
            catch
            {
                MessageBox.Show("无法找到程序：" + ser.Application+"，文件被篡改，请重新启动尝试！");
            }
        }
    }
}

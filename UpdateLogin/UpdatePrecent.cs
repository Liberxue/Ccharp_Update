using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using UpdateLogin.UpdateClass;
using UpdateLogin.Properties;
using System.Collections;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Xml;

namespace UpdateLogin
{
    public partial class UpdatePrecent : Form
    {
        #region 设置窗体无边框可拖动
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wparam, int lparam);
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)//按下的是鼠标左键            
            {
                Capture = false;//释放鼠标使能够手动操作                
                SendMessage(Handle, 0x00A1, 2, 0);//拖动窗体            
            }
        }

        [DllImport("User32.DLL")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        [DllImport("User32.DLL")]
        public static extern bool ReleaseCapture();
        public const uint WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 61456;
        public const int HTCAPTION = 2;

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE | HTCAPTION, 0);
        }
        #endregion

        #region 变量、构造函数
        //存放下载列表
        List<SynFileInfo> m_SynFileInfoList;
        INIClass ini;
        ServerInfor infor;
        private string App;
        private long DownloadSize = 0;
        private string WorkPath = System.AppDomain.CurrentDomain.BaseDirectory;
        private string temp = System.AppDomain.CurrentDomain.BaseDirectory + "UTemp\\";
        private int CON = 0;
        private int ECON = 0;
        private int SUM = 0;
        private string TotalSize;
        string xmlPath = System.AppDomain.CurrentDomain.BaseDirectory + "ClentFile.xml";
        XmlDocument localDoc;
        XmlNodeList file;
        string remark = "";
        string version = "";
        Thread tr;

        public UpdatePrecent()
        {
            InitializeComponent();
            m_SynFileInfoList = new List<SynFileInfo>();
            localDoc = new XmlDocument();
            localDoc.Load(xmlPath);
            file = localDoc.SelectSingleNode("Config").ChildNodes;
            dgvDownLoad.AllowUserToResizeRows = false;//是否允许调整行大小(默认：true)
        }

        public UpdatePrecent(ServerInfor Infor)
            : this()
        {
            this.infor = Infor;
            this.ini = Infor.INI;
            cb_Start.Checked = this.infor._QuckLoad;
            this.App = this.infor.Application;
            this.remark = Infor.Remark;
            this.version = Infor.Version;
            if (Infor.UpdateName != "")
                lbl_Title.Text = this.Text = Infor.UpdateName;
            if (Infor.OtherInfo != "")
                lbl_Other.Text = Infor.OtherInfo;
        }

        private void UpdatePrecent_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int t = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            if (t == 1)
            {
                timer1.Stop();
                t = 0;                
                tr = new Thread(StartUpdate);
                tr.Start();
            }
        }

        delegate void StartUpdateHandle();
        /// <summary>
        /// 开始更新
        /// </summary>
        private void StartUpdate()
        {
            if (this.InvokeRequired)
            {
                StartUpdateHandle d = new StartUpdateHandle(StartUpdate);
                this.Invoke(d);
            }
            else
            {
                AddBatchDownload();
                StartDownload();
            }
        }

        /// <summary>
        /// 判断更新的程序是否在运行
        /// </summary>
        /// <param name="processName"></param>
        public void GetPidByProcessName(string processName)
        {
            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
            {
                if (p.ProcessName == processName)
                {
                    p.Kill();
                }
            }
        }
        #endregion

        #region 加载数据
        void AddBatchDownload()
        {
            try
            {
                //清空行数据
                dgvDownLoad.Rows.Clear();
                //添加列表(建立多个任务)
                List<ArrayList> arrayListList = new List<ArrayList>();
                double size = 0;
                double Totle = 0;
                for (int i = 0; i < this.infor.DownloadFileList.Count; i++)
                {
                    size = Convert.ToDouble(this.infor.DownloadFileList[i].Size);
                    Totle += size;
                    arrayListList.Add(new ArrayList() { Resources.hourglass, i, this.infor.DownloadFileList[i].Name, FileOperate.GetAutoSizeString(size, 2), "0%", "0%", size, this.infor.DownloadFileList[i].Version });
                }
                pb_All.Value = 0;
                pb_All.Maximum = int.Parse(Totle.ToString());
                SUM = arrayListList.Count;
                lbl_SUM.Text = string.Format("文件：{0}/{1}", CON, SUM);
                TotalSize = FileOperate.GetAutoSizeString(Totle, 2);
                lbl_Size.Text = string.Format("大小：{0}/{1}", 0, TotalSize);
                lbl_Wait.Visible = false;
                foreach (ArrayList arrayList in arrayListList)
                {
                    int rowIndex = dgvDownLoad.Rows.Add(arrayList.ToArray());
                    arrayList[3] = 0;
                    arrayList.Add(dgvDownLoad.Rows[rowIndex]);
                    //取出列表中的行信息保存列表集合(m_SynFileInfoList)中
                    m_SynFileInfoList.Add(new SynFileInfo(arrayList.ToArray()));
                }
                lbl_Info.Text = string.Format("发布最新版本：{0}\n优化内容：\n{1}", this.version, this.remark);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }           
        #endregion

        #region 开始下载
        private void StartDownload()
        {
            //判断网络连接是否正常
            if (isConnected())
            {
                //设置最大活动线程数以及可等待线程数
                ThreadPool.SetMaxThreads(4, 4);
                foreach (SynFileInfo m_SynFileInfo in m_SynFileInfoList)
                {
                    //启动下载任务
                    StartDownLoad(m_SynFileInfo);
                }
            }
            else
            {
                MessageBox.Show("网络异常!");
            }
        }
        #endregion

        #region 检查网络状态

        //检测网络状态
        [DllImport("wininet.dll")]
        extern static bool InternetGetConnectedState(out int connectionDescription, int reservedValue);
        /// <summary>
        /// 检测网络状态
        /// </summary>
        bool isConnected()
        {
            int I = 0;
            bool state = InternetGetConnectedState(out I, 0);
            return state;
        }

        #endregion

        #region 使用WebClient下载文件

        /// <summary>
        /// HTTP下载远程文件并保存本地的函数
        /// </summary>
        void StartDownLoad(SynFileInfo FileInfo)
        {
            try
            {
                FileInfo.LastTime = DateTime.Now;
                //再次new 避免WebClient不能I/O并发 
                WebClient client = new WebClient();
                //异步下载
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                var savePath = System.AppDomain.CurrentDomain.BaseDirectory;
                if (!Directory.Exists(temp))//如果不存在就创建file文件夹
                {
                    Directory.CreateDirectory(temp);
                }
                string v = temp + FileInfo.DocName.Replace("/", "\\");
                string newPath = v.Substring(0, v.LastIndexOf('\\'));
                if (!Directory.Exists(newPath))//如果不存在就创建file文件夹
                {
                    Directory.CreateDirectory(newPath);
                }
                string file = this.infor.Server + FileInfo.DocName.Replace("\\", "/");
                client.DownloadFileAsync(new Uri(file), v, FileInfo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        SynFileInfo DownloadFileInfo;
        /// <summary>
        /// 下载进度条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadFileInfo = (SynFileInfo)e.UserState;
            DownloadFileInfo.RowObject.Cells["Image"].Value = Resources.hourglass_go;
            DownloadFileInfo.SynProgress = e.ProgressPercentage + "%";
            DownloadFileInfo.SynSpeed = FileOperate.GetAutoSizeString(e.BytesReceived, 2);
            DownloadFileInfo.RowObject.Cells["SynSpeed"].Value = DownloadFileInfo.SynProgress;
            DownloadFileInfo.FileSize = e.TotalBytesToReceive;
            this.DownloadSize += ToInt(e.BytesReceived) - ToInt(DownloadFileInfo.RowObject.Cells["SynProgress"].Value);
            DownloadFileInfo.RowObject.Cells["SynProgress"].Value = e.BytesReceived;
            pb_All.Value = (int)this.DownloadSize;
            lbl_Size.Text = string.Format("大小：{0}/{1}", FileOperate.GetAutoSizeString(this.DownloadSize, 2), TotalSize);
        }

        /// <summary>
        /// 转int类型数据
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int ToInt(Object value)
        {
            try
            {
                string v = "0";
                if (value == null)
                    return 0;
                if (value.ToString().Trim() != "")
                    v = value.ToString().Trim();
                return int.Parse(v);
            }
            catch
            {
                return 0;
            }
        }

        SynFileInfo DownloadCompliteFileInfo;
        /// <summary>
        /// 下载完成调用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //到此则一个文件下载完毕
            DownloadCompliteFileInfo = (SynFileInfo)e.UserState;
            if (DownloadCompliteFileInfo.FileSize != DownloadCompliteFileInfo.Size)
            {
                DownloadCompliteFileInfo.RowObject.Cells["Image"].Value = Resources.cross;
                DownloadCompliteFileInfo.RowObject.Cells["SynSpeed"].Value = "0%";
                ECON++;
                this.DownloadSize = this.DownloadSize - DownloadCompliteFileInfo.FileSize;
            }
            else
            {
                this.infor.DownloadFileList.Remove(this.infor.DownloadFileList.Where(c => c.Name == DownloadCompliteFileInfo.DocName).FirstOrDefault());
                DownloadCompliteFileInfo.RowObject.Cells["Image"].Value = Resources.tick;
                CON++;
                lbl_SUM.Text = string.Format("文件：{0}/{1}", CON, SUM);
                string path = "//File[@Name='" + DownloadCompliteFileInfo.DocName + "']";
                XmlNode root = file[2].SelectSingleNode(path);
                if (root == null)
                {
                    XmlElement subElement = localDoc.CreateElement("File");
                    subElement.SetAttribute("Name", DownloadCompliteFileInfo.DocName);
                    subElement.SetAttribute("Version", DownloadCompliteFileInfo.Version);
                    subElement.SetAttribute("Size", DownloadCompliteFileInfo.Size.ToString());
                    file[2].AppendChild(subElement);
                }
                else
                {
                    root.Attributes[1].Value = DownloadCompliteFileInfo.Version;
                    root.Attributes[2].Value = DownloadCompliteFileInfo.Size.ToString();
                }
                localDoc.Save(xmlPath);
            }
            m_SynFileInfoList.Remove(DownloadCompliteFileInfo);
            if (m_SynFileInfoList.Count <= 0)
            {
                tr.Abort();
                pb_All.Value = (int)this.DownloadSize;
                lbl_Size.Text = string.Format("大小：{0}/{1}", FileOperate.GetAutoSizeString(this.DownloadSize, 2), TotalSize);
                if (ECON != 0)
                {
                    lbl_Error.Text = "文件更新失败" + ECON + "个，请尝试重新更新！\n提示：本地网络限制或访问服务器会更新失败";
                    lbl_Error.Visible = true;
                    btn_OK.Text = "重新更新";
                }
                else
                {
                    CutNewFile();
                    CreateDesk();
                    CompledUpdate();
                }
                file[0].InnerText = this.version;
                file[1].InnerText = this.remark;
                localDoc.Save(xmlPath);
                btn_OK.Enabled = true;
            }
        }

        private void CutNewFile()
        {
            GetPidByProcessName(this.infor.Application.Replace(".exe", ""));
            string[] str = Directory.GetFiles(temp, "*", SearchOption.AllDirectories);
            string nf = "";
            foreach (string item in str)
            {
                nf = item.Replace(temp, "");
                try
                {
                    string newPath = WorkPath + nf.Substring(0, nf.LastIndexOf('\\'));
                    if (!Directory.Exists(newPath))//如果不存在就创建file文件夹
                        Directory.CreateDirectory(newPath);
                }
                catch { }
                nf = WorkPath + nf;
                if (File.Exists(nf))
                    File.Delete(nf);
                File.Move(item, nf);
                File.Delete(item);
            }
        }

        private void CompledUpdate()
        {
            if (cb_Start.Checked)
            {
                if (ECON == 0)//更新没错误才允许下一步
                {
                    if (this.App == "")
                    {
                        MessageBox.Show("设置启动主程序为空，系统找不到启动文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.ExitThread();
                        Application.Exit();
                        return;
                    }
                    Process.Start(this.App);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("更新完毕请点击启动程序！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        delegate void CreateDeskHandle();
        //更新完成，创建桌面快捷方式'
        private void CreateDesk()
        {
            if (this.InvokeRequired)
            {
                CreateDeskHandle d = new CreateDeskHandle(CreateDesk);
                this.Invoke(d);
            }
            else
            {
                try
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + infor.DeskTopName + ".lnk";
                    if (File.Exists(path))
                        return;
                    // 声明操作对象
                    IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                    {
                        if (infor.DeskTopName == "")
                            infor.DeskTopName = "云博程序更新";
                        // 创建一个快捷方式
                        IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(path);
                        // 关联的程序
                        shortcut.TargetPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                        shortcut.WorkingDirectory = System.Environment.CurrentDirectory;
                        shortcut.WindowStyle = 1;
                        // 全局热键
                        shortcut.Hotkey = "";
                        // 设置快捷方式的图标，这里是取程序图标，如果希望指定一个ico文件，那么请写路径。
                        if (infor.IcoName == "" || !File.Exists(WorkPath + infor.IcoName))
                        {
                            Icon ic = this.Icon;
                            Bitmap b = (Bitmap)ic.ToBitmap().Clone();
                            b.Save(WorkPath + "update.ico", System.Drawing.Imaging.ImageFormat.Icon);
                            infor.IcoName = "update.ico";
                        }
                        shortcut.IconLocation = WorkPath + infor.IcoName;
                        // 保存，创建就成功了。
                        shortcut.Save();
                    }
                }
                catch { }
            }
        }
        #endregion

        #region    更新完毕处理
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (btn_OK.Text == "重新更新")
            {
                this.DownloadSize = 0;
                ECON = 0;
                CON = 0;
                btn_OK.Text = "启动";
                btn_OK.Enabled = false;
                lbl_Error.Visible = false;
                lbl_Wait.Visible = true;
                lbl_Size.Text = "大小:0MB/0MB";
                lbl_SUM.Text = "文件：0/0";
                dgvDownLoad.Rows.Clear();
                timer1.Start();
            }
            else
            {
                if (this.App == "")
                {
                    MessageBox.Show("文件被篡改，请重新启动尝试，系统找不到启动文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.ExitThread();
                    Application.Exit();
                    return;
                }
                Process.Start(this.App);
                this.Close();
            }
        }

        private void cb_Start_CheckedChanged(object sender, EventArgs e)
        {
            string val = "0";
            if (cb_Start.Checked)
                val = "1";
            this.ini.IniWriteValue("UpdateLogin", "QuickLoad", val);
        }
        #endregion        

        #region 按钮设计
        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            if (l.Name == "lbl_Close")
                l.Image = Resources.btn_close_down;
            else
                l.Image = Resources.btn_mini_down;
        }

        private void lbl_MouseHover(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            if (l.Name == "lbl_Close")
            l.Image = Resources.btn_close_highlight;
            else
                l.Image = Resources.btn_mini_highlight;
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
           Label l = (Label)sender;
            if (l.Name == "lbl_Close")
                l.Image = Resources.btn_close_disable;
            else
                l.Image = Resources.btn_mini_normal;
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            if (l.Name == "lbl_Close")
            {
                Application.ExitThread();
                Application.Exit();
            }
            else if (l.Name == "lbl_Info")
            {
                if (this.panel1.Width > 415)
                {
                    this.panel1.BorderStyle = BorderStyle.None;
                    this.panel1.Width = 415;
                    this.panel1.Height = 180;
                    this.panel1.Location = new Point(60, 26);
                    lbl_Info.Text = string.Format("发布最新版本：{0}\n优化内容：\n{1}", this.version, this.remark);
                }
                else
                {
                    this.panel1.Size = this.Size;
                    this.panel1.Location = new Point(0, 0);
                    this.panel1.BorderStyle = BorderStyle.FixedSingle;
                    lbl_Info.Text = this.remark;
                }
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        #endregion        

        private void UpdatePrecent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != null)
                tr.Abort();
        }
    }
}

namespace UpdateLogin
{
    partial class UpdatePrecent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePrecent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_SUM = new System.Windows.Forms.Label();
            this.pb_All = new System.Windows.Forms.ProgressBar();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.dgvDownLoad = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.DocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SynSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SynProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_OK = new System.Windows.Forms.Button();
            this.cb_Start = new System.Windows.Forms.CheckBox();
            this.lbl_Other = new System.Windows.Forms.Label();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.lbl_Wait = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_Info);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(56, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 320);
            this.panel1.TabIndex = 14;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoEllipsis = true;
            this.lbl_Info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Info.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Info.Location = new System.Drawing.Point(0, 48);
            this.lbl_Info.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(1225, 272);
            this.lbl_Info.TabIndex = 0;
            this.lbl_Info.Text = "正在更新最新版本....";
            this.lbl_Info.Click += new System.EventHandler(this.lbl_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1225, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "更 新 说 明";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            // 
            // lbl_SUM
            // 
            this.lbl_SUM.AutoSize = true;
            this.lbl_SUM.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SUM.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SUM.ForeColor = System.Drawing.Color.White;
            this.lbl_SUM.Location = new System.Drawing.Point(107, 544);
            this.lbl_SUM.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_SUM.Name = "lbl_SUM";
            this.lbl_SUM.Size = new System.Drawing.Size(143, 36);
            this.lbl_SUM.TabIndex = 15;
            this.lbl_SUM.Text = "文件：0/0";
            this.lbl_SUM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            // 
            // pb_All
            // 
            this.pb_All.Location = new System.Drawing.Point(113, 467);
            this.pb_All.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pb_All.Name = "pb_All";
            this.pb_All.Size = new System.Drawing.Size(1131, 53);
            this.pb_All.TabIndex = 16;
            // 
            // lbl_Size
            // 
            this.lbl_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Size.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Size.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Size.ForeColor = System.Drawing.Color.White;
            this.lbl_Size.Location = new System.Drawing.Point(825, 544);
            this.lbl_Size.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(419, 40);
            this.lbl_Size.TabIndex = 15;
            this.lbl_Size.Text = "大小:0MB/0MB";
            this.lbl_Size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Size.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            // 
            // dgvDownLoad
            // 
            this.dgvDownLoad.AllowUserToAddRows = false;
            this.dgvDownLoad.AllowUserToDeleteRows = false;
            this.dgvDownLoad.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDownLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDownLoad.ColumnHeadersVisible = false;
            this.dgvDownLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.DocID,
            this.DocName,
            this.FileSize,
            this.SynSpeed,
            this.SynProgress});
            this.dgvDownLoad.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvDownLoad.Location = new System.Drawing.Point(61, 589);
            this.dgvDownLoad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvDownLoad.Name = "dgvDownLoad";
            this.dgvDownLoad.ReadOnly = true;
            this.dgvDownLoad.RowHeadersVisible = false;
            this.dgvDownLoad.RowTemplate.Height = 23;
            this.dgvDownLoad.Size = new System.Drawing.Size(1196, 83);
            this.dgvDownLoad.TabIndex = 17;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.Width = 30;
            // 
            // DocID
            // 
            this.DocID.DataPropertyName = "DocID";
            this.DocID.HeaderText = "DocID";
            this.DocID.Name = "DocID";
            this.DocID.ReadOnly = true;
            this.DocID.Visible = false;
            // 
            // DocName
            // 
            this.DocName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DocName.DataPropertyName = "DocName";
            this.DocName.HeaderText = "更新文件";
            this.DocName.Name = "DocName";
            this.DocName.ReadOnly = true;
            this.DocName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FileSize
            // 
            this.FileSize.DataPropertyName = "FileSize";
            this.FileSize.HeaderText = "大小";
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            this.FileSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FileSize.Width = 120;
            // 
            // SynSpeed
            // 
            this.SynSpeed.DataPropertyName = "SynSpeed";
            this.SynSpeed.HeaderText = "已下载";
            this.SynSpeed.Name = "SynSpeed";
            this.SynSpeed.ReadOnly = true;
            this.SynSpeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SynProgress
            // 
            this.SynProgress.DataPropertyName = "SynProgress";
            this.SynProgress.HeaderText = "进度";
            this.SynProgress.Name = "SynProgress";
            this.SynProgress.ReadOnly = true;
            this.SynProgress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SynProgress.Visible = false;
            // 
            // btn_OK
            // 
            this.btn_OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_OK.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_OK.Enabled = false;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(1071, 695);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(173, 69);
            this.btn_OK.TabIndex = 19;
            this.btn_OK.Text = "启动";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // cb_Start
            // 
            this.cb_Start.AutoSize = true;
            this.cb_Start.BackColor = System.Drawing.Color.Transparent;
            this.cb_Start.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_Start.ForeColor = System.Drawing.Color.Yellow;
            this.cb_Start.Location = new System.Drawing.Point(589, 713);
            this.cb_Start.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cb_Start.Name = "cb_Start";
            this.cb_Start.Size = new System.Drawing.Size(349, 40);
            this.cb_Start.TabIndex = 18;
            this.cb_Start.Text = "更新完毕自动启动主程序";
            this.cb_Start.UseVisualStyleBackColor = false;
            this.cb_Start.CheckedChanged += new System.EventHandler(this.cb_Start_CheckedChanged);
            // 
            // lbl_Other
            // 
            this.lbl_Other.AutoEllipsis = true;
            this.lbl_Other.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Other.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Other.ForeColor = System.Drawing.Color.White;
            this.lbl_Other.Location = new System.Drawing.Point(51, 700);
            this.lbl_Other.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Other.Name = "lbl_Other";
            this.lbl_Other.Size = new System.Drawing.Size(400, 61);
            this.lbl_Other.TabIndex = 15;
            this.lbl_Other.Text = "云博软件o13自动更新c#版";
            this.lbl_Other.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Other.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            // 
            // lbl_Close
            // 
            this.lbl_Close.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Close.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Close.ForeColor = System.Drawing.Color.White;
            this.lbl_Close.Image = global::UpdateLogin.Properties.Resources.btn_close_disable;
            this.lbl_Close.Location = new System.Drawing.Point(1253, -4);
            this.lbl_Close.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(80, 53);
            this.lbl_Close.TabIndex = 34;
            this.lbl_Close.Click += new System.EventHandler(this.lbl_Click);
            this.lbl_Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Close.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Close.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lbl_Min
            // 
            this.lbl_Min.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Min.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Min.ForeColor = System.Drawing.Color.White;
            this.lbl_Min.Image = global::UpdateLogin.Properties.Resources.btn_mini_normal;
            this.lbl_Min.Location = new System.Drawing.Point(1187, -4);
            this.lbl_Min.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(76, 53);
            this.lbl_Min.TabIndex = 34;
            this.lbl_Min.Click += new System.EventHandler(this.lbl_Click);
            this.lbl_Min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Min.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Min.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Red;
            this.lbl_Title.Location = new System.Drawing.Point(17, 31);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(310, 41);
            this.lbl_Title.TabIndex = 35;
            this.lbl_Title.Text = "         您有新的更新 !";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            // 
            // lbl_Error
            // 
            this.lbl_Error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Error.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(107, 392);
            this.lbl_Error.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(1137, 128);
            this.lbl_Error.TabIndex = 36;
            this.lbl_Error.Text = "错误";
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Error.Visible = false;
            this.lbl_Error.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            // 
            // lbl_Wait
            // 
            this.lbl_Wait.Image = global::UpdateLogin.Properties.Resources.load;
            this.lbl_Wait.Location = new System.Drawing.Point(591, 599);
            this.lbl_Wait.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Wait.Name = "lbl_Wait";
            this.lbl_Wait.Size = new System.Drawing.Size(99, 61);
            this.lbl_Wait.TabIndex = 37;
            // 
            // UpdatePrecent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1336, 776);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Size);
            this.Controls.Add(this.lbl_Wait);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.lbl_Close);
            this.Controls.Add(this.lbl_Min);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.cb_Start);
            this.Controls.Add(this.dgvDownLoad);
            this.Controls.Add(this.pb_All);
            this.Controls.Add(this.lbl_Other);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_SUM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UpdatePrecent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在线自动更新 !";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdatePrecent_FormClosed);
            this.Load += new System.EventHandler(this.UpdatePrecent_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_SUM;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.DataGridView dgvDownLoad;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.CheckBox cb_Start;
        private System.Windows.Forms.Label lbl_Other;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Error;
        public System.Windows.Forms.ProgressBar pb_All;
        private System.Windows.Forms.Label lbl_Wait;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn SynSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn SynProgress;
    }
}
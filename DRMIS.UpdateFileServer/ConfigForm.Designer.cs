namespace UpdateFileServer
{
    partial class ConfigForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDelet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.fb_SeletFile = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.dgv_Files = new System.Windows.Forms.DataGridView();
            this.col_Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_Del = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApply = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Files)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDelet,
            this.menuAdd});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // menuDelet
            // 
            this.menuDelet.Name = "menuDelet";
            this.menuDelet.Size = new System.Drawing.Size(148, 22);
            this.menuDelet.Text = "移除勾选项";
            this.menuDelet.Click += new System.EventHandler(this.menuDelet_Click);
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(148, 22);
            this.menuAdd.Text = "添加文件路径";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(14, 231);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(363, 233);
            this.txtDescription.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "-------------------------------更新说明-------------------------------";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(89, 30);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(0);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(288, 21);
            this.txtVersion.TabIndex = 18;
            this.txtVersion.Text = "1.0.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(20, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "最新版本号：";
            // 
            // lbl_Close
            // 
            this.lbl_Close.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Close.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Close.ForeColor = System.Drawing.Color.White;
            this.lbl_Close.Image = global::UpdateFileServer.Properties.Resources.btn_close_disable;
            this.lbl_Close.Location = new System.Drawing.Point(349, -4);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(40, 27);
            this.lbl_Close.TabIndex = 35;
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
            this.lbl_Min.Image = global::UpdateFileServer.Properties.Resources.btn_mini_normal;
            this.lbl_Min.Location = new System.Drawing.Point(316, -4);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(38, 27);
            this.lbl_Min.TabIndex = 36;
            this.lbl_Min.Click += new System.EventHandler(this.lbl_Click);
            this.lbl_Min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Min.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Min.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // dgv_Files
            // 
            this.dgv_Files.AllowUserToAddRows = false;
            this.dgv_Files.AllowUserToDeleteRows = false;
            this.dgv_Files.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Files.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Sel,
            this.col_Del,
            this.col_FileName,
            this.Column5,
            this.Column7});
            this.dgv_Files.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Files.Location = new System.Drawing.Point(14, 59);
            this.dgv_Files.Name = "dgv_Files";
            this.dgv_Files.RowHeadersVisible = false;
            this.dgv_Files.RowTemplate.Height = 23;
            this.dgv_Files.Size = new System.Drawing.Size(363, 150);
            this.dgv_Files.TabIndex = 37;
            this.dgv_Files.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Files_CellContentClick);
            // 
            // col_Sel
            // 
            this.col_Sel.HeaderText = "选";
            this.col_Sel.Name = "col_Sel";
            this.col_Sel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Sel.Width = 40;
            // 
            // col_Del
            // 
            this.col_Del.HeaderText = "操作";
            this.col_Del.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.col_Del.Name = "col_Del";
            this.col_Del.ReadOnly = true;
            this.col_Del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_Del.Text = "移除";
            this.col_Del.UseColumnTextForLinkValue = true;
            this.col_Del.VisitedLinkColor = System.Drawing.Color.Blue;
            this.col_Del.Width = 40;
            // 
            // col_FileName
            // 
            this.col_FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_FileName.DataPropertyName = "Name";
            this.col_FileName.HeaderText = "文件名";
            this.col_FileName.Name = "col_FileName";
            this.col_FileName.ReadOnly = true;
            this.col_FileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Version";
            this.Column5.HeaderText = "版本号";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 90;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SIZE";
            this.Column7.HeaderText = "大小";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnApply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApply.Location = new System.Drawing.Point(14, 470);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(363, 36);
            this.btnApply.TabIndex = 38;
            this.btnApply.Text = "保存配置文件";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::UpdateFileServer.Properties.Resources.BackImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 512);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.dgv_Files);
            this.Controls.Add(this.lbl_Close);
            this.Controls.Add(this.lbl_Min);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.Padding = new System.Windows.Forms.Padding(3, 26, 3, 3);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "创建更新文件";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Files)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.FolderBrowserDialog fb_SeletFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem menuDelet;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.DataGridView dgv_Files;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_Sel;
        private System.Windows.Forms.DataGridViewLinkColumn col_Del;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnApply;
    }
}


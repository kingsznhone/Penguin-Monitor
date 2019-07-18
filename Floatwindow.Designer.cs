namespace Penguin_Monitor
{
    partial class FloatWindow
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FloatWindow));
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemPene = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNets = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpacity = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.RAMLB = new Penguin_Monitor.BGLabel();
            this.CPULB = new Penguin_Monitor.BGLabel();
            this.UploadLB = new Penguin_Monitor.BGLabel();
            this.DownloadLB = new Penguin_Monitor.BGLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "偷偷看着我最喜欢的人";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPene,
            this.toolStripMenuItemHide,
            this.toolStripMenuItemNets,
            this.toolStripMenuItemOpacity,
            this.toolStripMenuItemInfo,
            this.exitToolStripMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 176);
            // 
            // toolStripMenuItemPene
            // 
            this.toolStripMenuItemPene.Name = "toolStripMenuItemPene";
            this.toolStripMenuItemPene.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItemPene.Text = "鼠标穿透";
            this.toolStripMenuItemPene.Click += new System.EventHandler(this.ToolStripMenuItemPene_Click);
            // 
            // toolStripMenuItemHide
            // 
            this.toolStripMenuItemHide.Name = "toolStripMenuItemHide";
            this.toolStripMenuItemHide.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItemHide.Text = "隐藏";
            this.toolStripMenuItemHide.Click += new System.EventHandler(this.ToolStripMenuItemHide_Click);
            // 
            // toolStripMenuItemNets
            // 
            this.toolStripMenuItemNets.Name = "toolStripMenuItemNets";
            this.toolStripMenuItemNets.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItemNets.Text = "扫描网络";
            this.toolStripMenuItemNets.Click += new System.EventHandler(this.ManualScanNetwork);
            // 
            // toolStripMenuItemOpacity
            // 
            this.toolStripMenuItemOpacity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripMenuItemOpacity.Name = "toolStripMenuItemOpacity";
            this.toolStripMenuItemOpacity.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItemOpacity.Text = "透明度";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem4.Text = "0.25";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ChangeOpacity_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem5.Text = "0.5";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ChangeOpacity_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Checked = true;
            this.toolStripMenuItem6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem6.Text = "0.75";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.ChangeOpacity_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem7.Text = "1";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.ChangeOpacity_Click);
            // 
            // toolStripMenuItemInfo
            // 
            this.toolStripMenuItemInfo.Name = "toolStripMenuItemInfo";
            this.toolStripMenuItemInfo.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItemInfo.Text = "关于";
            this.toolStripMenuItemInfo.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // exitToolStripMenuItemExit
            // 
            this.exitToolStripMenuItemExit.Name = "exitToolStripMenuItemExit";
            this.exitToolStripMenuItemExit.Size = new System.Drawing.Size(210, 24);
            this.exitToolStripMenuItemExit.Text = "退出";
            this.exitToolStripMenuItemExit.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // RAMLB
            // 
            this.RAMLB.BackColor = System.Drawing.Color.Black;
            this.RAMLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RAMLB.ForeColor = System.Drawing.Color.White;
            this.RAMLB.Location = new System.Drawing.Point(120, 40);
            this.RAMLB.Name = "RAMLB";
            this.RAMLB.Size = new System.Drawing.Size(120, 40);
            this.RAMLB.TabIndex = 0;
            this.RAMLB.Text = "RAM";
            this.RAMLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RAMLB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // CPULB
            // 
            this.CPULB.BackColor = System.Drawing.Color.Black;
            this.CPULB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CPULB.ForeColor = System.Drawing.Color.White;
            this.CPULB.Location = new System.Drawing.Point(120, 0);
            this.CPULB.Name = "CPULB";
            this.CPULB.Size = new System.Drawing.Size(120, 40);
            this.CPULB.TabIndex = 0;
            this.CPULB.Text = "CPU";
            this.CPULB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CPULB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // UploadLB
            // 
            this.UploadLB.BackColor = System.Drawing.Color.Black;
            this.UploadLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UploadLB.ForeColor = System.Drawing.Color.White;
            this.UploadLB.Location = new System.Drawing.Point(0, 40);
            this.UploadLB.Name = "UploadLB";
            this.UploadLB.Size = new System.Drawing.Size(120, 40);
            this.UploadLB.TabIndex = 0;
            this.UploadLB.Text = "Up";
            this.UploadLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UploadLB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // DownloadLB
            // 
            this.DownloadLB.BackColor = System.Drawing.Color.Black;
            this.DownloadLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DownloadLB.ForeColor = System.Drawing.Color.White;
            this.DownloadLB.Location = new System.Drawing.Point(0, 0);
            this.DownloadLB.Name = "DownloadLB";
            this.DownloadLB.Size = new System.Drawing.Size(120, 40);
            this.DownloadLB.TabIndex = 0;
            this.DownloadLB.Text = "Down";
            this.DownloadLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DownloadLB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // FloatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 80);
            this.ControlBox = false;
            this.Controls.Add(this.RAMLB);
            this.Controls.Add(this.CPULB);
            this.Controls.Add(this.UploadLB);
            this.Controls.Add(this.DownloadLB);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FloatWindow";
            this.Opacity = 0.75D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FloatWindow_FormClosed);
            this.Load += new System.EventHandler(this.FloatWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BGLabel DownloadLB;
        private BGLabel UploadLB;
        private BGLabel CPULB;
        private BGLabel RAMLB;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpacity;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNets;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHide;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPene;
    }
}


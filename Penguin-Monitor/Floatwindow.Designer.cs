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
            this.ToolStripMenuItemOCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMod = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStartUp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDonate = new System.Windows.Forms.ToolStripMenuItem();
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
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPene,
            this.toolStripMenuItemHide,
            this.toolStripMenuItemNets,
            this.toolStripMenuItemOpacity,
            this.toolStripMenuItemMod,
            this.toolStripMenuItemStartUp,
            this.toolStripMenuItemDonate,
            this.toolStripMenuItemInfo,
            this.exitToolStripMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // toolStripMenuItemPene
            // 
            resources.ApplyResources(this.toolStripMenuItemPene, "toolStripMenuItemPene");
            this.toolStripMenuItemPene.Name = "toolStripMenuItemPene";
            this.toolStripMenuItemPene.Click += new System.EventHandler(this.ToolStripMenuItemPene_Click);
            // 
            // toolStripMenuItemHide
            // 
            resources.ApplyResources(this.toolStripMenuItemHide, "toolStripMenuItemHide");
            this.toolStripMenuItemHide.Name = "toolStripMenuItemHide";
            this.toolStripMenuItemHide.Click += new System.EventHandler(this.ToolStripMenuItemHide_Click);
            // 
            // toolStripMenuItemNets
            // 
            resources.ApplyResources(this.toolStripMenuItemNets, "toolStripMenuItemNets");
            this.toolStripMenuItemNets.Name = "toolStripMenuItemNets";
            this.toolStripMenuItemNets.Click += new System.EventHandler(this.ManualScanNetwork);
            // 
            // toolStripMenuItemOpacity
            // 
            resources.ApplyResources(this.toolStripMenuItemOpacity, "toolStripMenuItemOpacity");
            this.toolStripMenuItemOpacity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.ToolStripMenuItemOCustom});
            this.toolStripMenuItemOpacity.Name = "toolStripMenuItemOpacity";
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ChangeOpacity_Click);
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ChangeOpacity_Click);
            // 
            // toolStripMenuItem6
            // 
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.ChangeOpacity_Click);
            // 
            // toolStripMenuItem7
            // 
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.ChangeOpacity_Click);
            // 
            // ToolStripMenuItemOCustom
            // 
            resources.ApplyResources(this.ToolStripMenuItemOCustom, "ToolStripMenuItemOCustom");
            this.ToolStripMenuItemOCustom.Name = "ToolStripMenuItemOCustom";
            this.ToolStripMenuItemOCustom.Click += new System.EventHandler(this.ToolStripMenuItemOCustom_Click);
            // 
            // toolStripMenuItemMod
            // 
            resources.ApplyResources(this.toolStripMenuItemMod, "toolStripMenuItemMod");
            this.toolStripMenuItemMod.Name = "toolStripMenuItemMod";
            this.toolStripMenuItemMod.Click += new System.EventHandler(this.toolStripMenuItemMod_Click);
            // 
            // toolStripMenuItemStartUp
            // 
            resources.ApplyResources(this.toolStripMenuItemStartUp, "toolStripMenuItemStartUp");
            this.toolStripMenuItemStartUp.Checked = true;
            this.toolStripMenuItemStartUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemStartUp.Name = "toolStripMenuItemStartUp";
            this.toolStripMenuItemStartUp.Click += new System.EventHandler(this.toolStripMenuItemStartUp_Click);
            // 
            // toolStripMenuItemDonate
            // 
            resources.ApplyResources(this.toolStripMenuItemDonate, "toolStripMenuItemDonate");
            this.toolStripMenuItemDonate.Name = "toolStripMenuItemDonate";
            this.toolStripMenuItemDonate.Click += new System.EventHandler(this.toolStripMenuItemDonate_Click);
            // 
            // toolStripMenuItemInfo
            // 
            resources.ApplyResources(this.toolStripMenuItemInfo, "toolStripMenuItemInfo");
            this.toolStripMenuItemInfo.Name = "toolStripMenuItemInfo";
            this.toolStripMenuItemInfo.Click += new System.EventHandler(this.ToolStripMenuInfo_Click);
            // 
            // exitToolStripMenuItemExit
            // 
            resources.ApplyResources(this.exitToolStripMenuItemExit, "exitToolStripMenuItemExit");
            this.exitToolStripMenuItemExit.Name = "exitToolStripMenuItemExit";
            this.exitToolStripMenuItemExit.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // RAMLB
            // 
            resources.ApplyResources(this.RAMLB, "RAMLB");
            this.RAMLB.BackColor = System.Drawing.Color.Black;
            this.RAMLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(166)))));
            this.RAMLB.Name = "RAMLB";
            this.RAMLB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // CPULB
            // 
            resources.ApplyResources(this.CPULB, "CPULB");
            this.CPULB.BackColor = System.Drawing.Color.Black;
            this.CPULB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(166)))));
            this.CPULB.Name = "CPULB";
            this.CPULB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // UploadLB
            // 
            resources.ApplyResources(this.UploadLB, "UploadLB");
            this.UploadLB.BackColor = System.Drawing.Color.Black;
            this.UploadLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(166)))));
            this.UploadLB.Name = "UploadLB";
            this.UploadLB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // DownloadLB
            // 
            resources.ApplyResources(this.DownloadLB, "DownloadLB");
            this.DownloadLB.BackColor = System.Drawing.Color.Black;
            this.DownloadLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(166)))));
            this.DownloadLB.Name = "DownloadLB";
            this.DownloadLB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // FloatWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ControlBox = false;
            this.Controls.Add(this.RAMLB);
            this.Controls.Add(this.CPULB);
            this.Controls.Add(this.UploadLB);
            this.Controls.Add(this.DownloadLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FloatWindow";
            this.Opacity = 0.75D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FloatWindow_FormClosed);
            this.Load += new System.EventHandler(this.FloatWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            this.MouseLeave += new System.EventHandler(this.FloatWindow_MouseLeave);
            this.MouseHover += new System.EventHandler(this.FloatWindow_MouseHover);
            this.Move += new System.EventHandler(this.FloatWindow_Move);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMod;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDonate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStartUp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOCustom;
    }
}


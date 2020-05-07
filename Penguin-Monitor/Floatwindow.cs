using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using Microsoft.Win32;
using System.Globalization;

namespace Penguin_Monitor
{


    public partial class FloatWindow : Form
    {
        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_STYLE = (-16);
        private const int GWL_EXSTYLE = (-20);
        private const int LWA_ALPHA = 2;

        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(
        IntPtr hwnd,
        int nIndex,
        uint dwNewLong
        );

        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(
        IntPtr hwnd,
        int nIndex
        );

        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        private static extern int SetLayeredWindowAttributes(
        IntPtr hwnd,
        int crKey,
        int bAlpha,
        int dwFlags
        );

        [DllImport("user32.dll")]//Drag Form
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;


        Monitor M = new Monitor();

        bool PositionLock = false;
        bool isPenetrating = false;

        public FloatWindow()
        {

            DecideUILang();
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            InitializeComponent();

            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                if (null == rk.GetValue("PenguinMonitor", null)) toolStripMenuItemStartUp.Checked = false;
            }

            ReloadColor();
            if (!InitMonitor())
                MessageBox.Show("连接网络后重试", "未检测到网络", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DecideUILang()
        {
            if (CultureInfo.CurrentUICulture.Name.StartsWith("zh")) Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh_CN");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
        }

        private void FloatWindow_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            this.Left = width / 2 - 120;
            this.Top = 0;
        }

        #region Hide On Top
        private void FloatWindow_Move(object sender, EventArgs e)
        {
            if (this.Top == 0)
            {
                this.Width = 240;
                this.Height = 5;
            }
            else
            {
                this.Width = 240;
                this.Height = 85;
            }
        }

        private void FloatWindow_MouseHover(object sender, EventArgs e)
        {
            if (this.Top == 0)
            {
                for (int i = 5; i <= 85; i++)
                {
                    this.Width = 240;
                    this.Height = i;
                }
            }
        }

        private void FloatWindow_MouseLeave(object sender, EventArgs e)
        {
            if (this.Top == 0)
            {
                this.Top++;
                this.Top--;
            }
        }

        public void ManualScanNetwork(object sender, EventArgs e)
        {
            if (!InitMonitor())
                MessageBox.Show("连接网络后重试" + Environment.NewLine+ "Retry after conneted to network", "未检测到网络 No network detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion


        public bool InitMonitor()
        {
            toolStripMenuItemNets.DropDownItems.Clear();
            M = new Monitor();
            List<ToolStripMenuItem> TSMIs = new List<ToolStripMenuItem>();
            ToolStripMenuItem item;
            if (M.Nets == null) return false;

            foreach (string net in M.Nets)
            {
                item = new ToolStripMenuItem();
                item.Name = net;
                item.Text = net;
                item.Click += new EventHandler(this.SelectNets);
                TSMIs.Add(item);
            }
            TSMIs[0].Checked = true;
            toolStripMenuItemNets.Click -= new EventHandler(this.ManualScanNetwork);
            if (CultureInfo.CurrentUICulture.Name.StartsWith("zh"))
                toolStripMenuItemNets.Text = "网络";
            else 
                toolStripMenuItemNets.Text = "Networks";
            toolStripMenuItemNets.DropDownItems.AddRange(TSMIs.ToArray());
            RefreshTimer.Enabled = true;
            return true;
        }

        public void SelectNets(object sender, EventArgs e)
        {
            ToolStripMenuItem ThisItem = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem OtherItems in toolStripMenuItemNets.DropDownItems)
            {
                OtherItems.Checked = false;
            }
            ThisItem.Checked = true;
            M.StartMonitor(ThisItem.Text);
        }

        private void DragWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) PositionLock = !PositionLock;

            if (!PositionLock)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            }
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            M.refresh();

            RAMLB.Value = M.getRamUtil();
            RAMLB.StackValue(RAMLB.Value);
            RAMLB.Text = "RAM " + M.getRamUtil() + "%";


            DownloadLB.Text = "↓ " + M.getDownSpeed();
            UploadLB.Text = "↑ " + M.getUpSpeed();

            CPULB.Value = M.getCpuUtil();
            CPULB.StackValue(CPULB.Value);
            CPULB.Text = "CPU " + M.getCpuUtil() + "%";

            this.Refresh();
        }

        private void FloatWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.notifyIcon1.Dispose();
            Environment.Exit(0);
        }

        private void ChangeOpacity_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem T in toolStripMenuItemOpacity.DropDownItems)
            {
                T.Checked = false;
            }
            ToolStripMenuItem i = (ToolStripMenuItem)sender;
            i.Checked = true;

            ChangeOpacity(Convert.ToDouble(i.Text));
        }

        public void ChangeOpacity(double opacity)
        {
            this.Opacity = opacity;
            if (isPenetrating) SetPenetrate(Convert.ToInt32(opacity * 255));
            Properties.Settings.Default.Opacity = opacity;
            Properties.Settings.Default.Save();
        }

        public void SetPenetrate(int opacity)
        {
            //opacity = 0-255
            var STYLE = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, STYLE | WS_EX_LAYERED | WS_EX_TRANSPARENT);
            SetLayeredWindowAttributes(this.Handle, 0, opacity, LWA_ALPHA);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Dispose();
            Environment.Exit(0);
        }

        private void ToolStripMenuInfo_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

        private void ToolStripMenuItemHide_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem i = (ToolStripMenuItem)sender;
            if (i.Checked)
            { Show(); i.Checked = false; }
            else
            { Hide(); i.Checked = true; }
        } 

        private void ToolStripMenuItemPene_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem i = (ToolStripMenuItem)sender;
            if (i.Checked)
            {
                isPenetrating = false;
                i.Checked = false;

                //cancel penetrate
                this.FormBorderStyle = this.FormBorderStyle;
            }
            else
            {
                isPenetrating = true;
                i.Checked = true;
                SetPenetrate(Convert.ToInt32(this.Opacity * 255));
            }
        }

        private void toolStripMenuItemDonate_Click(object sender, EventArgs e)
        {
            Form donate = new DonateWnd();
            donate.Show();
        }

        private void toolStripMenuItemMod_Click(object sender, EventArgs e)
        {
            Modify mod = new Modify(this);
            mod.Show();
            //Thread T = new Thread(() => {
            //    if (mod.ShowDialog() == DialogResult.OK)
            //        this.Invoke(new Action(() => { ReloadColor(); }));
            //});
            //T.Start();
            
        }

        private void toolStripMenuItemStartUp_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            ToolStripMenuItem i = (ToolStripMenuItem)sender;
            if (i.Checked)
            {
                rk.DeleteValue("PenguinMonitor", false);
                i.Checked = false;
            }
            else
            {
                rk.SetValue("PenguinMonitor", Application.ExecutablePath);
                i.Checked = true;
            }

            

        }

        private void ToolStripMenuItemOCustom_Click(object sender, EventArgs e)
        {
            CustomOpacity co = new CustomOpacity(this);
            co.Show();
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (Visible)
            { Hide(); toolStripMenuItemHide.Checked = true; }
            else
            { Show(); toolStripMenuItemHide.Checked = false; }
        }

        public void ReloadColor()
        {
            this.BackColor = Properties.Settings.Default.TopColor;
            CPULB.ReloadColor();
            RAMLB.ReloadColor();
            UploadLB.ReloadColor();
            DownloadLB.ReloadColor();
        }
    }
}

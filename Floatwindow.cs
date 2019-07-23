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

namespace Penguin_Monitor
{
    

    public partial class FloatWindow : Form
    {
        delegate void SwitchAction ();
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

        [DllImport("user32.dll")]//拖动无窗体的控件
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        

        Monitor M = new Monitor();

        bool PositionLock = false;
        bool isPenetrating =false;

        public FloatWindow()
        {
            InitializeComponent();

            if (!InitMonitor()) MessageBox.Show("连接网络后重试", "未检测到网络", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ManualScanNetwork(object sender, EventArgs e)
        {
            if (!InitMonitor()) MessageBox.Show("连接网络后重试", "未检测到网络", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool InitMonitor()
        {
            toolStripMenuItemNets.DropDownItems.Clear();
            M = new Monitor();
            List<ToolStripMenuItem> TSMIs = new List<ToolStripMenuItem>();
            ToolStripMenuItem TSMI;
            if (M.Nets == null) return false;

            foreach (string net in M.Nets)
            {
                TSMI = new ToolStripMenuItem();
                TSMI.Name = net;
                TSMI.Text = net;
                TSMI.Click += new EventHandler(this.SelectNets);
                TSMIs.Add(TSMI);
            }
            TSMIs[0].Checked = true;
            toolStripMenuItemNets.Click -= new EventHandler(this.ManualScanNetwork);
            toolStripMenuItemNets.Text = "网络";
            toolStripMenuItemNets.DropDownItems.AddRange(TSMIs.ToArray());
            RefreshTimer.Enabled = true;
            return true;
        }

        public void SelectNets(object sender, EventArgs e)
        {
            ToolStripMenuItem ThisItem = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem OtherItem in toolStripMenuItemNets.DropDownItems)
            {
                OtherItem.Checked = false;
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


        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Dispose();
            Environment.Exit(0);
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            M.refresh();

            RAMLB.Value = M.getRamUtil();
            RAMLB.Text = "RAM" + M.getRamUtil() + "%";

            DownloadLB.Text = "↓ " + M.getDownSpeed();
            UploadLB.Text = "↑ " + M.getUpSpeed();

            CPULB.Value = M.getCpuUtil();
            CPULB.Text = "CPU " + M.getCpuUtil() + "%";

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

            if (isPenetrating)
            {
                this.Opacity = Convert.ToDouble(i.Text);
                SetPenetrate(Convert.ToInt32(Convert.ToDouble(i.Text) * 255));
            }

                
            else this.Opacity = Convert.ToDouble(i.Text);


        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string INFO =
                "左键拖拽，右键锁定" + Environment.NewLine +
                "Code By:KingsZNHONE" + Environment.NewLine +
                "部分源码来自blog.csdn.net/kunorz/article/details/81044595";
            MessageBox.Show(INFO, "企鹅监控 v1.3", MessageBoxButtons.OK);
        }

        private void FloatWindow_Load(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - 500;
        }

        private void ToolStripMenuItemHide_Click(object sender, EventArgs e)
        {
            SwitchAction @switch = delegate ()
            {
                bool x = this.Visible;
                if (x) this.Hide();
                else this.Show();
            };


            ToolStripMenuItem i = (ToolStripMenuItem)sender;
            if (i.Checked)
            {
                @switch();
                i.Checked = false;
            }
            else
            {
                @switch();
                i.Checked = true;
            }
        }

        public void SetPenetrate(int opacity)
        {
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
            SetLayeredWindowAttributes(this.Handle, 0, opacity, LWA_ALPHA);
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
                
                SetPenetrate(Convert.ToInt32(this.Opacity*255));
            }
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            bool x = this.Visible;
            if (x) { this.Hide(); toolStripMenuItemHide.Checked = true; }
            else { this.Show(); toolStripMenuItemHide.Checked = false; }
        }
    }
}

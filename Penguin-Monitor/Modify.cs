using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penguin_Monitor
{
    public partial class Modify : Form
    {
        PointF[] MergedArray;
        PointF[] baseline;
        PointF[] loadstack;
        public Modify()
        {
            int[] CPUdata = { 10, 15, 48, 56, 4, 15, 2, 8, 15, 88, 98 };
            int[] RAMdata = { 20, 25, 30, 45, 22, 50, 50, 38, 31, 20, 33 };
            InitializeComponent();

            ReloadColor();

            MakeData(CPUdata);
            CPULB.MergedArray = MergedArray;
            CPULB.Value = 100;
            MakeData(RAMdata);
            RAMLB.MergedArray = MergedArray;
            this.Refresh();
        }

        public void ReloadColor()
        {
            TopLB.BackColor = Properties.Settings.Default.TopColor;
            CPULB.ReloadColor();
            RAMLB.ReloadColor();
            UploadLB.ReloadColor();
            DownloadLB.ReloadColor();
        }

        private void MakeData(int[] dataset)
        {
            MergedArray = new PointF[13];
            baseline = new PointF[2];
            loadstack = new PointF[11];
            foreach (int data in dataset) StackValue(data);
            
        }

        private void CreateBaseline()
        {
            PointF pointF = default;
            pointF.Y = 40;
            pointF.X = 0f;
            baseline[0] = pointF;
            pointF.X = 120;
            baseline[1] = pointF;
        }

        public void StackValue(int value)
        {
            CreateBaseline();
            Array.Copy(loadstack, 0, loadstack, 1, loadstack.Length - 1);
            for (int i = 0; i < loadstack.Length; i++)
            {
                loadstack[i].X = (float)(loadstack.Length - i - 1) * 120 / ((float)loadstack.Length - 1f);
            }
            loadstack[0].Y = 40 - 40 * value / 100;

            MergedArray = new PointF[loadstack.Length + baseline.Length];
            Array.Copy(loadstack, 0, MergedArray, 0, loadstack.Length);
            Array.Copy(baseline, 0, MergedArray, loadstack.Length, baseline.Length);
        }

        private void ModFontBtn_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = CPULB.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                CPULB.Font = fontDialog1.Font;
                RAMLB.Font = fontDialog1.Font;
                UploadLB.Font = fontDialog1.Font;
                DownloadLB.Font = fontDialog1.Font;
                this.Refresh();
            }
        }

        private void ModForeColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = CPULB.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                CPULB.ForeColor = colorDialog1.Color;
                RAMLB.ForeColor = colorDialog1.Color;
                UploadLB.ForeColor = colorDialog1.Color;
                DownloadLB.ForeColor = colorDialog1.Color;
                this.Refresh();
            }
        }

        private void TopColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = TopLB.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TopLB.BackColor = colorDialog1.Color;
                this.Refresh();
            }
        }

        private void BorderColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = CPULB.BorderColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                CPULB.BorderColor = colorDialog1.Color;
                this.Refresh();
            }
        }

        private void WarningColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color= CPULB.WarningColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                CPULB.WarningColor = colorDialog1.Color;
                this.Refresh();
            }
        }

        private void BrushColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = RAMLB.BrushColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                RAMLB.BrushColor = colorDialog1.Color;
                this.Refresh();
            }
        }

        private void BackgroundColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = CPULB.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                CPULB.BackColor = colorDialog1.Color;
                RAMLB.BackColor = colorDialog1.Color;
                UploadLB.BackColor = colorDialog1.Color;
                DownloadLB.BackColor = colorDialog1.Color;
                this.Refresh();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BrushColor = RAMLB.BrushColor;
            Properties.Settings.Default.BorderColor = CPULB.BorderColor;
            Properties.Settings.Default.WarningColor = CPULB.WarningColor;
            Properties.Settings.Default.ForeColor = CPULB.ForeColor;
            Properties.Settings.Default.BackgroundColor = CPULB.BackColor;
            Properties.Settings.Default.字体 = CPULB.Font;
            Properties.Settings.Default.TopColor = TopLB.BackColor;
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
        }

        private void DefaltBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BrushColor = Color.Green;
            Properties.Settings.Default.BorderColor = Color.White;
            Properties.Settings.Default.WarningColor = Color.Red;
            Properties.Settings.Default.ForeColor = Color.White;
            Properties.Settings.Default.BackgroundColor = Color.Black;
            Properties.Settings.Default.字体 = new Font("Microsoft YaHei UI", 10.8f);
            Properties.Settings.Default.TopColor = Color.RoyalBlue;
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Penguin_Monitor
{
    public partial class Modify : Form
    {
        public FloatWindow parent;

        List<PointF> MergedArray;
        List<PointF> baseline;
        List<PointF> sampling;
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


        public Modify(FloatWindow parent)
        {
            int[] CPUdata = { 10, 15, 48, 56, 4, 15, 2, 8, 15, 88, 98 };
            int[] RAMdata = { 20, 25, 30, 45, 22, 50, 50, 38, 31, 20, 33 };
            int[] UpData = { 31, 35, 25, 46, 54, 55, 65, 36, 33, 42, 32 };
            int[] DownData = { 56, 57, 59, 63, 74, 78, 76, 88, 92, 94, 98 };
            InitializeComponent();

            ReloadColor();

            MakeData(CPUdata);
            CPULB.MergedArray = MergedArray;
            CPULB.Value = 100;

            MakeData(RAMdata);
            RAMLB.MergedArray = MergedArray;

            MakeData(UpData);
            UploadLB.MergedArray = MergedArray;

            MakeData(DownData);
            DownloadLB.MergedArray = MergedArray;

            this.Refresh();
            this.parent = parent;
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
            MergedArray = new List<PointF>();
            //2 point
            baseline = new List<PointF>();
            //11 point
            sampling = new List<PointF>();
            for (int i = 0; i < 11; i++)
            {
                sampling.Add(new PointF(0, 40));
            }
            foreach (int data in dataset) StackValue(data);
        }

        private void CreateBaseline()
        {
            baseline.Clear();
            baseline.Add(new PointF(0, 40));
            baseline.Add(new PointF(120, 40));
        }

        public void StackValue(int value)
        {
            CreateBaseline();
            //Remove Last, Add a new point at head
            sampling.RemoveAt(sampling.Count - 1);
            PointF pNew = new PointF(0, 0);
            pNew.X = 0;
            pNew.Y = 40- 40 * value / 100;
            sampling.Insert(0, pNew);

            float X = 0f;
            float Y = 0f;
            //Move X
            for (int i = 0; i < sampling.Count; i++)
            {
                Y = sampling[i].Y;
                X = (sampling.Count - i - 1) * (float)120 / (sampling.Count - 1f);
                PointF p = new PointF(X, Y);
                sampling[i] = p;
            }
            MergedArray = sampling.Concat(baseline).ToList();
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
            colorDialog1.Color = CPULB.WarningColor;
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
            this.parent.ReloadColor();
        }

        private void DefaltBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BrushColor = Color.Green;
            Properties.Settings.Default.BorderColor = Color.White;
            Properties.Settings.Default.WarningColor = Color.Red;
            Properties.Settings.Default.ForeColor = Color.White;
            Properties.Settings.Default.BackgroundColor = Color.Black;
            Properties.Settings.Default.字体 = new Font("Microsoft YaHei UI", 9f);
            Properties.Settings.Default.TopColor = Color.RoyalBlue;
            Properties.Settings.Default.Save();
            this.parent.ReloadColor();
            this.Close();
        }
    }
}

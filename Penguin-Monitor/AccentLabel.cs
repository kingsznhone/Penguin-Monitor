using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Penguin_Monitor
{
    public class AccentLabel : Label
    {
        public bool BackColorVisible = true;

        public bool BorderColorVisible = true;

        public int Target = 75;

        public int Value = 0;
        public List<PointF> MergedArray;
        public List<PointF> baseline;
        public List<PointF> sampling;

        public Color BrushColor;
        public Color BorderColor;
        public Color WarningColor;
        public AccentLabel()
        {
            ReloadColor();
            sampling = new List<PointF>();
            baseline = new List<PointF>();

            //11 point
            for (int i = 0; i < 11; i++)
            {
                sampling.Add(new PointF(0,40));
            }

            //2 point
            CreateBaseline();

            MergedArray = sampling.Concat(baseline).ToList();
        }


        public void ReloadColor()
        {
            BrushColor = Properties.Settings.Default.BrushColor;
            BorderColor = Properties.Settings.Default.BorderColor;
            WarningColor = Properties.Settings.Default.WarningColor;
            ForeColor = Properties.Settings.Default.ForeColor;
            BackColor = Properties.Settings.Default.BackgroundColor;
            this.Font = Properties.Settings.Default.字体;
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
            this.Value = value;
            //Remove Last, Add a new point at head
            sampling.RemoveAt(sampling.Count - 1);
            PointF pNew = new PointF(0, 0);
            pNew.X = 0;
            pNew.Y = base.Height - base.Height * value / 100;
            sampling.Insert(0, pNew);

            float X = 0f;
            float Y = 0f;
            //Move X
            for (int i = 0; i < sampling.Count; i++)
            {
                Y = sampling[i].Y;
                X = (sampling.Count - i - 1) * (float)base.Width / (sampling.Count - 1f);
                PointF p = new PointF(X,Y);
                sampling[i] = p;
            }
            MergedArray = sampling.Concat(baseline).ToList();
        }

        public void StackValue(List<int> value)
        {
            CreateBaseline();

            sampling.RemoveAt(sampling.Count - 1);
            PointF pNew = new PointF(0, 0);
            pNew.X = 0;
            pNew.Y = 0;
            sampling.Insert(0, pNew);

            float X = 0f;
            float Y = 0f;
            //Move X
            for (int i = 0; i < sampling.Count; i++)
            {
                Y = base.Height - base.Height * value[i] / 100;
                X = (sampling.Count - i - 1) * (float)base.Width / (sampling.Count - 1f);
                PointF p = new PointF(X, Y);
                sampling[i] = p;
            }
            MergedArray = sampling.Concat(baseline).ToList();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            if (BackColorVisible)
            {
                if (Value >= Target)
                {
                    Brush brush = new SolidBrush(WarningColor);
                    e.Graphics.FillClosedCurve(brush, MergedArray.ToArray()) ;
                    Pen pen = new Pen(BorderColor, 3f);
                    e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                }
                else
                {
                    Brush brush2 = new SolidBrush(BrushColor);
                    e.Graphics.FillClosedCurve(brush2, MergedArray.ToArray());
                }
            }
        }
    }
}

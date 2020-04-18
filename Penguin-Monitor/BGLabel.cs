using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penguin_Monitor
{
	public class BGLabel : Label
	{
		public bool BackColorVisible = true;

		public bool BorderColorVisible = true;

		public int Target = 75;

		public int Value = 0;
		public PointF[] MergedArray;
		public PointF[] baseline;
		public PointF[] loadstack;

		public Color BrushColor;
		public Color BorderColor;
		public Color WarningColor;
		public BGLabel()
		{
			
			MergedArray = new PointF[1];
			ReloadColor();
			loadstack = new PointF[11];
			PointF pointF = default;
			for (int i = 0; i < loadstack.Length; i++)
			{
				pointF.X = 0;
				pointF.Y = 40;
				loadstack[i] = pointF;
			}

			baseline = new PointF[2];
			pointF.Y = 40;
			pointF.X = 0f;
			baseline[0] = pointF;
			pointF.X = 0;
			baseline[1] = pointF;

			MergedArray = new PointF[loadstack.Length + baseline.Length];
			Array.Copy(loadstack, 0, MergedArray, 0, loadstack.Length);
			Array.Copy(baseline, 0, MergedArray, loadstack.Length, baseline.Length);
		}


		public void ReloadColor()
		{
			BrushColor = Properties.Settings.Default.BrushColor;
			BorderColor = Properties.Settings.Default.BorderColor;
			WarningColor = Properties.Settings.Default.WarningColor;
			ForeColor= Properties.Settings.Default.ForeColor;
			this.Font = Properties.Settings.Default.字体;
		}

		private void CreateBaseline()
		{
			PointF pointF = default;
			pointF.Y = this.Height;
			pointF.X = 0f;
			baseline[0] = pointF;
			pointF.X = base.Width;
			baseline[1] = pointF;
		}

		public void StackValue(int value)
		{
			CreateBaseline();
			this.Value = value;
			Array.Copy(loadstack, 0, loadstack, 1, loadstack.Length - 1);
			for (int i = 0; i < loadstack.Length; i++)
			{
				loadstack[i].X = (float)(loadstack.Length - i - 1) * (float)base.Width / ((float)loadstack.Length - 1f);
			}
			loadstack[0].Y = base.Height - base.Height * value / 100;

			MergedArray = new PointF[loadstack.Length + baseline.Length];
			Array.Copy(loadstack, 0, MergedArray, 0, loadstack.Length);
			Array.Copy(baseline, 0, MergedArray, loadstack.Length, baseline.Length);
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
			if (BackColorVisible)
			{
				if (Value >= Target)
				{
					Brush brush = new SolidBrush(WarningColor);
					e.Graphics.FillClosedCurve(brush, MergedArray);
					Pen pen = new Pen(BorderColor, 3f);
					e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
				}
				else
				{
					Brush brush2 = new SolidBrush(BrushColor);
					e.Graphics.FillClosedCurve(brush2, MergedArray);
				}
			}
		}
	}
}

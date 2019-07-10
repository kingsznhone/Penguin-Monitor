using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penguin_Monitor
{
    public partial class BGLabel : Label
    {
        public bool BackColorVisible = true;
        public bool BorderColorVisible = true;
        public int Target = 75;
        public int Value = 00;

        public BGLabel()
        {

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            if (BackColorVisible)
            {
                if (Value >= Target)
                {
                    Brush brush = new SolidBrush(Color.Red);
                    int height = Height * Value / 100;
                    e.Graphics.FillRectangle(brush, 0, Height - height, Width, Height);
                    Pen pen = new Pen(Color.White, 3);
                    e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
                }
                else
                {
                    Brush brush = new SolidBrush(Color.Green);
                    int height = Height * Value / 100;
                    e.Graphics.FillRectangle(brush, 0, Height - height, Width, Height);
                }
            }
        }
    }

}

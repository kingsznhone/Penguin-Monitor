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
    public partial class CustomOpacity : Form
    {
        FloatWindow parent;
        public CustomOpacity(FloatWindow parent)
        {
            InitializeComponent();
            this.parent = parent;
            trackBar1.Value =Convert.ToInt32( parent.Opacity * 100);
            label1.Text = trackBar1.Value.ToString()+"%";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            parent.ChangeOpacity(Convert.ToDouble(trackBar1.Value / 100f));
            label1.Text = trackBar1.Value.ToString() + "%";
        }
    }
}

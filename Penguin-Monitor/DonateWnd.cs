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
    public partial class DonateWnd : Form
    {
        public DonateWnd()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.donate;

        }

    }
}

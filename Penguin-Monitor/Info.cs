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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var uri = new Uri("https://github.com/kingsznhone/Penguin-Monitor");
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);
            //System.Diagnostics.Process.Start("https://github.com/kingsznhone/Penguin-Monitor");
        }
    }
}

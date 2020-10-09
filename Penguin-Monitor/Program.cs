using System;
using System.Threading;
using System.Windows.Forms;

namespace Penguin_Monitor
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool bCreatedNew;
            Mutex m = new Mutex(false, "KingsPenguinMonitor", out bCreatedNew);
            if (bCreatedNew)
            //Create a new mutex using specific mutex name
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FloatWindow());
            }
        }
    }
}

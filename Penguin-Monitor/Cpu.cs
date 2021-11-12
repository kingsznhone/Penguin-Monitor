using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Penguin_Monitor
{
    public class Cpu
    {

        public int curValue { get; private set; }
        public int oldValue { get; private set; }

        private PerformanceCounter counter;
        private CancellationTokenSource cts;
        //ms
        public int UpdateInterval = 1000;
        public Cpu()
        {
            cts = new CancellationTokenSource();
            counter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            curValue = (int)counter.NextValue();
        }

        public async void StartUpdate()
        {
            while (true)
            {
                if (cts.IsCancellationRequested)
                {
                    return;
                }
                refresh();
                await Task.Delay(UpdateInterval);
            }
        }

        public void StopUpdate()
        {
            cts.Cancel();
        }

        private void refresh()
        {
            oldValue = curValue;
            curValue = (int)counter.NextValue();
        }
    }


}

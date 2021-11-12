using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Penguin_Monitor
{
    public class Ram
    {
        public struct MEMORYSTATUS
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong dwTotalPhys;
            public ulong dwAvailPhys;
            public ulong dwTotalPageFile;
            public ulong dwAvailPageFile;
            public ulong dwTotalVirtual;
            public ulong dwAvailVirtual;
            public ulong dwAvailExtendedVirtual;
        }

        public int curValue { get; private set; }
        public int oldValue { get; private set; }

        private MEMORYSTATUS mStatus;

        [DllImport("kernel32.dll")]
        public static extern void GlobalMemoryStatus(ref MEMORYSTATUS stat);

        private CancellationTokenSource cts;
        //ms
        public int UpdateInterval = 1000;

        public Ram()
        {
            cts = new CancellationTokenSource();
            GlobalMemoryStatus(ref mStatus);
            curValue = (int)(mStatus.dwMemoryLoad);
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
            GlobalMemoryStatus(ref mStatus);
            curValue = (int)(mStatus.dwMemoryLoad);
        }
    }


}

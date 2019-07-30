using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Penguin_Monitor
{
    public class Monitor
    {
        private Network network;
        private Cpu cpu;
        private Ram ram;
        public string[] Nets;

        public Monitor()
        {
            List<string> NetsList = new List<string>();
            PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface");
            foreach (string name in category.GetInstanceNames())
            {
                if (name == "MS TCP Loopback interface" || name == "Teredo Tunneling Pseudo-Interface")
                    continue;
                Network n = new Network(name);
                if (n.isConnect)
                {
                    NetsList.Add(name);
                }
            }
            Nets = NetsList.ToArray();
            if (Nets.Length >= 1) StartMonitor(Nets[0]);
        }

        public void StartMonitor(string NetName)
        {
            network = new Network(NetName);
            cpu = new Cpu();
            ram = new Ram();
        }

        public void refresh()
        {
            network.refresh();
            cpu.refresh();
            ram.refresh();
        }

        public string getDownSpeed()
        {
            return network.getFormatDownSpeed();
        }

        public string getUpSpeed()
        {
            return network.getFormatUpSpeed();
        }

        public int getCpuUtil()
        {
            return cpu.curValue;
        }

        public int getRamUtil()
        {
            return ram.curValue;
        }


    }

    public class Network
    {

        public string name { get; private set; }
        public long downSpeed { get; private set; }
        public long upSpeed { get; private set; }
        public bool isUpSpeedChange { get; private set; }
        public bool isConnect { get; private set; }

        private PerformanceCounter downCounter, upCounter;
        private long downValue, upValue;
        private long downValueOld, upValueOld;

        private int ArrayPtr = 0;
        private long[] AdownSpeed;
        private long[] AupSpeed;

        public Network(string name)
        {
            this.name = name;

            AdownSpeed = new long[5] { 0, 0, 0, 0, 0 };
            AupSpeed = new long[5] { 0, 0, 0, 0, 0 };
            downCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", name);
            upCounter = new PerformanceCounter("Network Interface", "Bytes Sent/sec", name);
            if (downCounter == null || upCounter == null)
                return;
            downValueOld = downCounter.NextSample().RawValue;
            upValueOld = upCounter.NextSample().RawValue;
            if (downValueOld > 0 || upValueOld > 0) isConnect = true;
            else isConnect = false;

        }

        public void refresh()
        {
            if (downCounter == null || upCounter == null)
            {
                downSpeed = 0;
                upSpeed = 0;
                return;
            }
            if (downCounter.NextSample() == null || upCounter.NextSample() == null)
            {
                downSpeed = 0;
                upSpeed = 0;
                return;
            }

            downValue = downCounter.NextSample().RawValue;
            upValue = upCounter.NextSample().RawValue;

            downSpeed = downValue - downValueOld;
            upSpeed = upValue - upValueOld;

            downValueOld = downValue;
            upValueOld = upValue;

            //Avg.Test

            AdownSpeed[ArrayPtr] = downSpeed;
            AupSpeed[ArrayPtr] = upSpeed;
            ArrayPtr = (ArrayPtr + 1) % 5;
        }

        public string getFormatDownSpeed()
        {
            return format(AdownSpeed);
        }

        public string getFormatUpSpeed()
        {
            return format(AupSpeed);
        }

        private string format(long num)
        {
            double n = num / 1024.0;
            if (n >= 1000.0) return (n / 1024).ToString("0.00") + "MB/s";
            else if (n >= 100.0) return n.ToString("0.0") + "KB/s";
            else return n.ToString("0.00") + "KB/s";
        }
        private string format(long[] num)
        {
            double n = num.Average() /1024.0;
            if (n >= 1000.0) return (n / 1024).ToString("0.00") + "MB/s";
            else if (n >= 100.0) return n.ToString("0.0") + "KB/s";
            else return n.ToString("0.00") + "KB/s";
        }
    }

    public class Cpu
    {

        public int curValue { get; private set; }
        public int oldValue { get; private set; }

        private PerformanceCounter counter;

        public Cpu()
        {
            counter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            curValue = (int)counter.NextValue();
        }

        public void refresh()
        {
            oldValue = curValue;
            curValue = (int)counter.NextValue();
        }
    }

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

        public Ram()
        {
            GlobalMemoryStatus(ref mStatus);
            curValue = (int)(mStatus.dwMemoryLoad);
        }

        public void refresh()
        {
            oldValue = curValue;
            GlobalMemoryStatus(ref mStatus);
            curValue = (int)(mStatus.dwMemoryLoad);
        }
    }


}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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
            cpu = new Cpu();
            cpu.StartUpdate();
            ram = new Ram();
            ram.StartUpdate();

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
            if (Nets.Length >= 1) StartMonitorNetwork(Nets[0]);
        }

        public void StartMonitorNetwork(string NetName)
        {
            network = new Network(NetName);
            network.StartUpdate();
        }

        public string getDownSpeed()
        {
            return network.getFormatADownSpeed();
        }

        public List<int> getDownSpeedRelative()
        {
            return network.downspeedRelative.Select(x=>Convert.ToInt32(x)).ToList();
        }

        public string getUpSpeed()
        {
            return network.getFormatAUpSpeed();
        }

        public List<int> getUpSpeedRelative()
        {
            return network.upspeedRelative.Select(x => Convert.ToInt32(x)).ToList();
        }

        public int getCpuUsage()
        {
            return cpu.curValue;
        }

        public int getRamUsage()
        {
            return ram.curValue;
        }

        public void SetInterval(int n)
        {
            cpu.UpdateInterval = n;
            ram.UpdateInterval = n;
            network.UpdateInterval = n;
        }
    }


}

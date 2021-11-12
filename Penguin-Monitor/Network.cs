using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Penguin_Monitor
{
    public class Network
    {
        public string name { get; private set; }
        public double downSpeed { get; private set; }
        public double upSpeed { get; private set; }
        public bool isUpSpeedChange { get; private set; }
        public bool isConnect { get; private set; }

        private PerformanceCounter downCounter, upCounter;
        private long downValue, downValueOld;
        private long upValue, upValueOld;

        private int ArrayPtr = 0;
        private double[] AdownSpeed;
        private double[] AupSpeed;

        public List<double> downspeedActrual;
        public List<double> downspeedRelative;
        public List<double> upspeedActrual;
        public List<double> upspeedRelative;

        private CancellationTokenSource cts;

        //ms
        public int UpdateInterval = 1000;
        public Network(string name)
        {
            this.name = name;

            downspeedActrual = new List<double>();
            downspeedRelative = new List<double>();
            upspeedActrual = new List<double>();
            upspeedRelative = new List<double>();
            for(int i = 0; i < 11; i++)
            {
                downspeedActrual.Add(0);
                upspeedActrual.Add(0);
                downspeedRelative.Add(0);
                upspeedRelative.Add(0);
            }


            AdownSpeed = new double[5] { 0, 0, 0, 0, 0 };
            AupSpeed = new double[5] { 0, 0, 0, 0, 0 };


            downCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", name);
            upCounter = new PerformanceCounter("Network Interface", "Bytes Sent/sec", name);
            if (downCounter == null || upCounter == null)
                return;
            downValueOld = downCounter.NextSample().RawValue;
            upValueOld = upCounter.NextSample().RawValue;
            if (downValueOld > 0 || upValueOld > 0) isConnect = true;
            else isConnect = false;

            cts = new CancellationTokenSource();
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

            downSpeed = (downValue - downValueOld) / (UpdateInterval / 1000d);
            upSpeed = (upValue - upValueOld) / (UpdateInterval / 1000d);

            downValueOld = downValue;
            upValueOld = upValue;

            //Avg.
            AdownSpeed[ArrayPtr] = downSpeed;
            AupSpeed[ArrayPtr] = upSpeed;
            ArrayPtr = (ArrayPtr + 1) % 5;

            //history
            upspeedActrual.RemoveAt(upspeedActrual.Count - 1);
            upspeedActrual.Insert(0,upSpeed);
            upspeedRelative = upspeedActrual.ToList();
            GetRelative(ref upspeedRelative);

            downspeedActrual.RemoveAt(downspeedActrual.Count - 1);
            downspeedActrual.Insert(0,downSpeed);
            downspeedRelative = downspeedActrual.ToList();
            GetRelative(ref downspeedRelative);

            void GetRelative(ref List<double> Relative)
            {
                double max = Relative.Max();
                if (max > 0)
                {
                    for (int i = 0; i < Relative.Count; i++)
                    {
                        Relative[i] = Relative[i] / max * 100;
                    }
                }
                
            }

        }

        public string getFormatDownSpeed()
        {
            return format(downSpeed);
        }

        public string getFormatUpSpeed()
        {
            return format(upSpeed);
        }

        public string getFormatADownSpeed()
        {
            return format(AdownSpeed.Average());
        }

        public string getFormatAUpSpeed()
        {
            return format(AupSpeed.Average());
        }

        private string format(double num)
        {
            double n = num / 1024.0;
            if (n >= 1000000.0) return (n / 1024d / 1024d).ToString("0.00") + "GB/s";
            else if (n >= 100000.0) return (n / 1024d).ToString("0.0") + "MB/s";
            else if (n >= 1000.0) return (n / 1024d).ToString("0.00") + "MB/s";
            else if (n >= 100) return n.ToString("0.0") + "KB/s";
            else if (n > 0) return n.ToString("0.00") + "KB/s";
            else { return "0.00" + "KB/s"; }
        }

        public double RawADownSpeed()
        {
            return AdownSpeed.Average();
        }

        public double RawAUpSpeed()
        {
            return AupSpeed.Average();
        }
    }


}

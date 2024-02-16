using System;
namespace AbstractScanner.NetStandard.Hardware
{
    public class BatteryDetailInfo
    {
        public bool Valid { get; set; }

        public ushort Percentage { get; set; }

        public ushort RemainCapacity { get; set; }

        public ushort TotalCapacity { get; set; }

        public float Temperture { get; set; }

        public float Voltage { get; set; }
    }
}

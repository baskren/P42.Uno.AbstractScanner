using System;

namespace AbstractScanner.NetStandard.Hardware
{
    public static class StatusExtensions
    {
        public static bool IsConnected(this ConnectionStatus status)
            => ConnectionStatus.StatusAlreadyConnected == status || ConnectionStatus.StatusConnected == status;

        public static int ToPercent(this BatteryStatus status)
        {
            switch (status)
            {
                case BatteryStatus.BatteryStatus0Of4Bars: return 0;
                case BatteryStatus.BatteryStatus1Of4Bars: return 25;
                case BatteryStatus.BatteryStatus2Of4Bars: return 50;
                case BatteryStatus.BatteryStatus3Of4Bars: return 75;
                case BatteryStatus.BatteryStatus4Of4Bars: return 100;
                case BatteryStatus.PowerSourceConnected: return -1;
            }
            return -2;
        }
    }
}

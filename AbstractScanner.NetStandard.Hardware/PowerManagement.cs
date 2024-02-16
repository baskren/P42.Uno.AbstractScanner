using System;
using System.Threading.Tasks;

namespace AbstractScanner.NetStandard.Hardware
{
    public static class PowerManagement
    {
        internal static IPowerManagement PlatformPowerManagement;

        public static ChargeStatus? ChargeStatus => PlatformPowerManagement?.ChargeStatus;

        public static BatteryStatus? BatteryStatus => PlatformPowerManagement?.BatteryStatus;

        public static event EventHandler<ChargeStatus> ChargeStatusChanged
        {
            add
            {
                if (PlatformPowerManagement != null)
                    PlatformPowerManagement.ChargeStatusChanged += value;
            }
            remove
            {
                if (PlatformPowerManagement != null)
                    PlatformPowerManagement.ChargeStatusChanged -= value;
            }
        }

        public static event EventHandler<BatteryStatus> BatteryStatusChanged
        {
            add
            {
                if (PlatformPowerManagement != null)
                    PlatformPowerManagement.BatteryStatusChanged += value;
            }
            remove
            {
                if (PlatformPowerManagement != null)
                    PlatformPowerManagement.BatteryStatusChanged -= value;
            }
        }

        public static event EventHandler LowBatteryWarning
        {
            add
            {
                if (PlatformPowerManagement != null)
                    PlatformPowerManagement.LowBatteryWarning += value;
            }
            remove
            {
                if (PlatformPowerManagement != null)
                    PlatformPowerManagement.LowBatteryWarning -= value;
            }
        }

        public static event EventHandler LowBatteryShutdown
        {
            add
            {
                if (PlatformPowerManagement != null)
                    PlatformPowerManagement.LowBatteryWarning += value;
            }
            remove
            {
                if (PlatformPowerManagement != null)
                    PlatformPowerManagement.LowBatteryWarning -= value;
            }
        }

        public static async Task<BatteryDetailInfo> GetBatteryInfoAsync()
            => await PlatformPowerManagement?.GetBatteryInfoAsync();

        public static bool ShareSledBatteryWithMobileDevice
        {
            get
            {

                if (PlatformPowerManagement != null)
                    return PlatformPowerManagement.ShareSledBatteryWithMobileDevice;
                return false;
            }
            set
            {
                if (PlatformPowerManagement != null)
                    PlatformPowerManagement.ShareSledBatteryWithMobileDevice = value;
            }
        }

        public static ConnectionStatus Start()
            => PlatformPowerManagement != null ? PlatformPowerManagement.Start() : ConnectionStatus.StatusUnableToConnect;

        public static void Stop()
            => PlatformPowerManagement?.Stop();
    }
}

using System;
using AbstractScanner.NetStandard.Hardware;

namespace AbstractScanner
{
    public static class PowerManagement
    {
        public static ChargeStatus ChargeStatus
        {
            get
            {
                if (AbstractScanner.NetStandard.Hardware.PowerManagement.ChargeStatus is NetStandard.Hardware.ChargeStatus chargeStatus)
                    return (ChargeStatus)chargeStatus;
                return ChargeStatus.Undefined;
            }
        }

        public static BatteryStatus BatteryStatus
        {
            get
            {
                if (NetStandard.Hardware.PowerManagement.BatteryStatus is NetStandard.Hardware.BatteryStatus batteryStatus)
                    return (BatteryStatus)batteryStatus;
                return BatteryStatus.Undefined;
            }
        }

        public static event EventHandler<ChargeStatus> ChargeStatusChanged;
        public static event EventHandler<BatteryStatus> BatteryStatusChanged;
        public static event EventHandler LowBatteryWarning;
        public static event EventHandler LowBatteryShutdown;


        static PowerManagement()
        {
            NetStandard.Hardware.PowerManagement.ChargeStatusChanged += OnCaptuvoChargeStatusChanged;
            NetStandard.Hardware.PowerManagement.BatteryStatusChanged += OnCaptuvoBatteryStatusChanged;
            NetStandard.Hardware.PowerManagement.LowBatteryWarning += OnCaptuvoLowBatteryWarning;
            NetStandard.Hardware.PowerManagement.LowBatteryShutdown += OnCaptuvoLowBatteryShutdown;
        }

        private static void OnCaptuvoChargeStatusChanged(object sender, NetStandard.Hardware.ChargeStatus e)
            => ChargeStatusChanged?.Invoke(null, (ChargeStatus)e);

        private static void OnCaptuvoBatteryStatusChanged(object sender, NetStandard.Hardware.BatteryStatus e)
            => BatteryStatusChanged?.Invoke(null, (BatteryStatus)e);

        private static void OnCaptuvoLowBatteryWarning(object sender, EventArgs e)
            => LowBatteryWarning?.Invoke(null, null);

        private static void OnCaptuvoLowBatteryShutdown(object sender, EventArgs e)
            => LowBatteryShutdown?.Invoke(null, null);

        public static bool ShareBattery
        {
            get => NetStandard.Hardware.PowerManagement.ShareSledBatteryWithMobileDevice;
            set => NetStandard.Hardware.PowerManagement.ShareSledBatteryWithMobileDevice = value;
        }
    }
}

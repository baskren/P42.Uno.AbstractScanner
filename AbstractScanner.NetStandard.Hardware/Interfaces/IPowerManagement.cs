using System;
using System.Threading.Tasks;

namespace AbstractScanner.NetStandard.Hardware
{
    public interface IPowerManagement
    {
        ChargeStatus ChargeStatus { get; }

        BatteryStatus BatteryStatus { get; }

        event EventHandler<ChargeStatus> ChargeStatusChanged;

        event EventHandler<BatteryStatus> BatteryStatusChanged;

        event EventHandler LowBatteryWarning;

        event EventHandler LowBatterShutdown;

        Task<BatteryDetailInfo> GetBatteryInfoAsync();

        bool ShareSledBatteryWithMobileDevice { get; set; }

        ConnectionStatus Start();

        void Stop();
    }
}

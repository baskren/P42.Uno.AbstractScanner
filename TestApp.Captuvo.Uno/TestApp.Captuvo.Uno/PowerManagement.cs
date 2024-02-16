using System;
namespace TestApp.Captuvo.Uno;

#if IOS
public class PowerManagement : CaptuvoSDK.CaptuvoEventsProtocol
{
    const string ShareBatteryKey = "Captuvo.ShareBattery";

    public PowerManagement()
    {
        //Settings.CaptuvoDevice.AddCaptuvoDelegate(this);
        _shareSledBattery = Xamarin.Essentials.Preferences.Get(ShareBatteryKey, false);
        if (_shareSledBattery)
            Settings.CaptuvoDevice.EnableBatteryQuery();
        else
            Settings.CaptuvoDevice.DisableBatteryQuery();
    }

    public ConnectionStatus Start()
        => (ConnectionStatus)Settings.CaptuvoDevice.StartPMHardware();

    public void Stop()
        => Settings.CaptuvoDevice.StopPMHardware();


    public static ChargeStatus ChargeStatus => (ChargeStatus)Settings.CaptuvoDevice.ChargeStatus;

    public static BatteryStatus BatteryStatus => (BatteryStatus)Settings.CaptuvoDevice.BatteryStatus;

    public event EventHandler<ChargeStatus>? ChargeStatusChanged;
    public event EventHandler<BatteryStatus>? BatteryStatusChanged;
    public event EventHandler? LowBatteryWarning;
    public event EventHandler? LowBatterShutdown;

    CaptuvoSDK.cupertinoBatteryDetailInfo? _batteryDetailInfo;
    DateTime _batteryDetailRequestStart = DateTime.MinValue.AddYears(1);
    public async Task<BatteryDetailInfo?> GetBatteryInfoAsync()
    {
        _batteryDetailInfo = null;
        _batteryDetailRequestStart = DateTime.Now;
        Settings.CaptuvoDevice.QueryBatteryDetailInfo();
        while (_batteryDetailInfo == null && DateTime.Now - _batteryDetailRequestStart < TimeSpan.FromSeconds(5))
        {
            await Task.Delay(100);
        }
        return _batteryDetailInfo?.ToAbstract();
    }

    bool _shareSledBattery;
    public bool ShareSledBatteryWithMobileDevice
    {
        get => _shareSledBattery;
        set
        {
            if (value != _shareSledBattery)
            {
                _shareSledBattery = value;
                if (_shareSledBattery)
                    Settings.CaptuvoDevice.EnableBatteryQuery();
                else
                    Settings.CaptuvoDevice.DisableBatteryQuery();
                Xamarin.Essentials.Preferences.Set(ShareBatteryKey, _shareSledBattery);
            }
        }
    }


    public override void ResponseBatteryDetailInformation(CaptuvoSDK.cupertinoBatteryDetailInfo batteryInfo)
        => _batteryDetailInfo = batteryInfo;


    public override void PmLowBatteryWarning()
        => LowBatteryWarning?.Invoke(this, EventArgs.Empty);


    public override void PmLowBatteryShutdown()
        => LowBatterShutdown?.Invoke(this, EventArgs.Empty);


    public override void PmChargeStatusChange(CaptuvoSDK.ChargeStatus newChargeStatus)
        => ChargeStatusChanged?.Invoke(this, (ChargeStatus)newChargeStatus);


    public override void PmBatteryStatusChange(CaptuvoSDK.BatteryStatus newBatteryStatus)
        => BatteryStatusChanged?.Invoke(this, (BatteryStatus)newBatteryStatus);


}

public static class BatteryDetailInfoExtentions
{
    public static BatteryDetailInfo? ToAbstract(this CaptuvoSDK.cupertinoBatteryDetailInfo cupertinoBattery)
    {
        if (cupertinoBattery == null)
            return null;
        var result = new BatteryDetailInfo
        {
            Valid = cupertinoBattery.Valid,
            Percentage = cupertinoBattery.Percentage,
            RemainCapacity = cupertinoBattery.RemainCapacity,
            TotalCapacity = cupertinoBattery.TotalCapacity,
            Temperture = (float)cupertinoBattery.Temperture,
            Voltage = (float)cupertinoBattery.Voltage
        };
        return result;
    }
}

#endif

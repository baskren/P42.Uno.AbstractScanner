using System;
namespace AbstractScanner
{
    public enum ConnectionStatus
    {
        StatusConnected,
        StatusAlreadyConnected,
        StatusBatteryDepleted,
        StatusUnableToConnectIncompatibleSledFirmware,
        StatusUnableToConnect,
        UnableToConnectNOAccessary,
        UnableToConnectNOProtocal
    }

    public enum ChargeStatus
    {
        NotCharging,
        Charging,
        ChargeComplete,
        Undefined
    }

    public enum BatteryStatus
    {
        PowerSourceConnected,
        BatteryStatus4Of4Bars,
        BatteryStatus3Of4Bars,
        BatteryStatus2Of4Bars,
        BatteryStatus1Of4Bars,
        BatteryStatus0Of4Bars,
        Undefined
    }

    public enum TriggerKeyStatus
    {
        Enabled,
        Disabled,
        ChangeSuccessful,
        ChangeFailed,
        ToggleFeatureUnsupported
    }


}

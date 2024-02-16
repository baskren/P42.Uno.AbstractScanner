using System;
using System.Data;

namespace TestApp.Captuvo.Uno;

#if IOS
public class Scanner : CaptuvoSDK.CaptuvoEventsProtocol
{
    #region AbstractScanner.NetStandard.Hardware.IScanner
    public event EventHandler<string>? DataReceived;
    public event EventHandler<byte[]>? RawDataReceived;


    public Scanner()
    {
        Settings.CaptuvoDevice.AddCaptuvoDelegate(this);
    }

    public ConnectionStatus Start()
    {
        var startHardware = Settings.CaptuvoDevice.StartDecoderHardware();
        if (startHardware == CaptuvoSDK.ProtocolConnectionStatus.StatusAlreadyConnected
            || startHardware == CaptuvoSDK.ProtocolConnectionStatus.StatusConnected)
            Settings.CaptuvoDevice.StartDecoderScanning();
        return (ConnectionStatus)startHardware;
    }

    public ConnectionStatus Enable()
    {
        var startHardware = Settings.CaptuvoDevice.StartDecoderHardware();
        if (startHardware == CaptuvoSDK.ProtocolConnectionStatus.StatusAlreadyConnected
            || startHardware == CaptuvoSDK.ProtocolConnectionStatus.StatusConnected)
            Settings.CaptuvoDevice.EnableDecoderScanning();
        return (ConnectionStatus)startHardware;
    }

    public void Stop()
    {
        Settings.CaptuvoDevice.StopDecoderScanning();
        Settings.CaptuvoDevice.StopDecoderHardware();
    }
    #endregion

    #region CaptuvoEventsProtocol
    public override void CaptuvoConnected()
    {
        Settings.CaptuvoDevice.StartDecoderHardware(250);
    }

    public override void CaptuvoDisconnected()
    {
        Settings.CaptuvoDevice.StopDecoderHardware();
    }

    public override void DecoderReady()
    {
        System.Console.WriteLine("CAPTUVO DecoderReady");

    }

    
    public override void ResponseBatteryDetailInformation(CaptuvoSDK.cupertinoBatteryDetailInfo batteryInfo)
    {
        //((PowerManagement)AbstractScanner.NetStandard.Hardware.PowerManagement.PlatformPowerManagement).ResponseBatteryDetailInformation(batteryInfo);
        System.Diagnostics.Debug.WriteLine($"Scanner. : ");
    }
    

    public override void DecoderDataReceived(string data)
    {
        System.Diagnostics.Debug.WriteLine("DecoderDataReceived: [" + data + "]");
        System.Console.WriteLine("CAPTUVO DecoderDataReceived:  [" + data + "]");
        DataReceived?.Invoke(null, data);
    }

    public TriggerKeyStatus TriggerKeyStatus => (TriggerKeyStatus)Settings.CaptuvoDevice.RequestTriggerKeyStatus;

    #endregion
}
#endif

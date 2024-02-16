using System;

namespace AbstractScanner.Captuvo.iOS
{
    public static class Settings
    {
        internal static CaptuvoSDK.Captuvo CaptuvoDevice;

        public static void Initiate()
        {
#if DEBUG
            CaptuvoDevice = CaptuvoSDK.Captuvo.SharedCaptuvoDeviceDebug;
#else
            CaptuvoDevice = CaptuvoSDK.Captuvo.SharedCaptuvoDevice;
#endif
            NetStandard.Hardware.Scanner.PlatformScanner = new Scanner();
            NetStandard.Hardware.Device.PlatformHardware = new Device();
            NetStandard.Hardware.PowerManagement.PlatformPowerManagement = new PowerManagement();
        }


    }
}

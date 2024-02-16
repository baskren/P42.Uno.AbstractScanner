using System;
using AbstractScanner.NetStandard.Hardware;

namespace AbstractScanner.Captuvo.iOS
{
    public class Device : IDevice
    {
        public string Name => Settings.CaptuvoDevice.CaptuvoName;

        public string Model => Settings.CaptuvoDevice.CaptuvoModelNumber;

        public string Serial => Settings.CaptuvoDevice.CaptuvoSerialNumber;

        public string FirmwareRevision => Settings.CaptuvoDevice.CaptuvoFirmwareRevision;

        public string HardwareRevision => Settings.CaptuvoDevice.CaptuvoHardwareRevision;

        public string Manufacturer => Settings.CaptuvoDevice.CaptuvoManufacturer;

        public string SdkBuild => Settings.CaptuvoDevice.SDKbuildNumber;

        public string SdkShortVersion => Settings.CaptuvoDevice.SDKshortVersion;

        public string SdkFullVersion => Settings.CaptuvoDevice.SDKfullVersion;

        public bool Debug => Settings.CaptuvoDevice.Debug;

    }

}

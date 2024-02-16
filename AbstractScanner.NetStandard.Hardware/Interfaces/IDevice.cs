using System;
namespace AbstractScanner.NetStandard.Hardware
{
    public interface IDevice
    {
        string Name { get; }

        string Model { get; }

        string Serial { get; }

        string FirmwareRevision { get; }

        string HardwareRevision { get; }

        string Manufacturer { get; }

        string SdkBuild { get; }

        string SdkShortVersion { get; }

        string SdkFullVersion { get; }

        bool Debug { get; }

    }
}

using System;

namespace AbstractScanner.NetStandard.Hardware
{
    public static class Device
    {
        internal static IDevice PlatformHardware;

        public static string Name => PlatformHardware?.Name;

        public static string Model => PlatformHardware?.Model;

        public static string Serial => PlatformHardware?.Serial;

        public static string FirmwareRevision => PlatformHardware?.FirmwareRevision;

        public static string HardwareRevision => PlatformHardware?.HardwareRevision;

        public static string Manufacturer => PlatformHardware?.Manufacturer;

        public static string SdkBuild => PlatformHardware?.SdkBuild;

        public static string SdkShortVersion => PlatformHardware?.SdkShortVersion;

        public static string SdkFullVersion => PlatformHardware?.SdkFullVersion;

        public static bool Debug => PlatformHardware == null || PlatformHardware.Debug;


    }
}

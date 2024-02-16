using System;
namespace TestApp.Captuvo.Uno;

#if IOS
public static class Device
{
    public static string Name => Settings.CaptuvoDevice.CaptuvoName;

    public static string Model => Settings.CaptuvoDevice.CaptuvoModelNumber;

    public static string Serial => Settings.CaptuvoDevice.CaptuvoSerialNumber;

    public static string FirmwareRevision => Settings.CaptuvoDevice.CaptuvoFirmwareRevision;

    public static string HardwareRevision => Settings.CaptuvoDevice.CaptuvoHardwareRevision;

    public static string Manufacturer => Settings.CaptuvoDevice.CaptuvoManufacturer;

    public static string SdkBuild => Settings.CaptuvoDevice.SDKbuildNumber;

    public static string SdkShortVersion => Settings.CaptuvoDevice.SDKshortVersion;

    public static string SdkFullVersion => Settings.CaptuvoDevice.SDKfullVersion;

    public static bool Debug => Settings.CaptuvoDevice.Debug;

}

#endif

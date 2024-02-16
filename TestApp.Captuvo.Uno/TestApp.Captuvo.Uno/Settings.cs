using System;
namespace TestApp.Captuvo.Uno;

public static class Settings
{
#if IOS
    static CaptuvoSDK.Captuvo? _CaptuvoDevice;
    internal static CaptuvoSDK.Captuvo CaptuvoDevice => _CaptuvoDevice ??= CaptuvoSDK.Captuvo.SharedCaptuvoDevice;
    static Scanner? _Scanner;
    internal static Scanner Scanner => _Scanner ??= new Scanner();
    static PowerManagement? _PowerManagement;
    internal static PowerManagement PowerManagement => _PowerManagement ??= new PowerManagement();
#endif


}


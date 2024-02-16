

namespace TestApp.Captuvo.Uno;

public sealed partial class MainPage : Page
{
    const string StartText = "START CAPTUVO";
    const string StopText = "STOP CAPTUVO";

    public MainPage()
    {
        InitializeComponent();

#if IOS
        Settings.Scanner.DataReceived += OnScannerDataReceived;
#endif
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        Task.Run(UpdatePowerTextBlocksAsync);
        UpdateHardwareTextBlocks();
    }

    private void OnScannerDataReceived(object? sender, string e)
    {
        _dataTextBlock.Text = "Data Received: [" + e + "] at " + DateTime.Now;
    }

    private void OnButtonClick(object sender, RoutedEventArgs e)
    {
#if IOS
        if ((string)_button.Content == StartText)
        {
            _button.Content = StopText;
            var status = Settings.Scanner.Start();
            _statusTextBlock.Text = "Connection Status: " + status.ToString();
        }
        else
        {
            _button.Content = StartText;
            Settings.Scanner.Stop();
            _statusTextBlock.Text = "Connection Status: " + "Disconnected";
        }
#endif
    }

    async void OnGetBatteryInfoButtonClick(object sender, RoutedEventArgs e)
            => await UpdatePowerTextBlocksAsync();

    async Task UpdatePowerTextBlocksAsync()
    {
#if IOS
        var status = Settings.PowerManagement.Start();
        _batteryConnection.Text = "Power Manager: " + status.ToString();
        _batteryStatusTextBlock.Text = "Battery Status:" + PowerManagement.BatteryStatus.ToString();
        _chargeStatusTextBlock.Text = "Charge Status: " + PowerManagement.ChargeStatus.ToString();
        var info = await Settings.PowerManagement.GetBatteryInfoAsync();
        _batteryPercentTextBlock.Text = "Battery %: " + info?.Percentage.ToString();
        _batteryVoltageTextBlock.Text = "Battery V: " + info?.Voltage.ToString();
        _batteryTemperatureTextBlock.Text = "Battery °K: " + info?.Temperture.ToString();
        _batteryRemainCapacityTextBlock.Text = "Battery Capacity: " + info?.RemainCapacity + " / " + info?.TotalCapacity;
        System.Diagnostics.Debug.WriteLine("");
        Settings.PowerManagement.Stop();
        _batteryConnection.Text = "Power Manager: " + "Disconnected";
#else
        await Task.CompletedTask;
#endif
    }

    void UpdateHardwareTextBlocks()
    {
#if IOS
        _hwNameTextBlock.Text = "Name: " + Device.Name;
        _hwModelTextBlock.Text = "Model: " + Device.Model;
        _hwSerialTextBlock.Text = "Serial: " + Device.Serial;
        _hwFirmwareTextBlock.Text = "Firmware: " + Device.FirmwareRevision;
        _hwRevisionTextBlock.Text = "Revision: " + Device.HardwareRevision;
        _hwManufacturerTextBlock.Text = "Mfgr: " + Device.Manufacturer;
        _hwSdkBuildTextBlock.Text = "SDK Build: " + Device.SdkBuild;
        _hwSdkFullVersionTextBlock.Text = "SDK Version: " + Device.SdkFullVersion;
        _hwSdkShortVersionTextBlock.Text = "SDK Version: " + Device.SdkShortVersion;
        _hwDebug.Text = "Debug: " + Device.Debug.ToString();
#endif
    }


}

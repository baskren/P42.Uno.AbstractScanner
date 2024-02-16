using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AbstractScanner.NetStandard.Hardware;

namespace TestApp.Captuvo
{
    public partial class MainPage : ContentPage
    {
        const string StartText = "START CAPTUVO";
        const string StopText = "STOP CAPTUVO";

        public MainPage()
        {
            InitializeComponent();

            _button.Text = StartText;

            AbstractScanner.NetStandard.Hardware.Scanner.DataReceived += OnScannerDataReceived;

            if (Xamarin.Forms.Device.RuntimePlatform == Xamarin.Forms.Device.iOS)
                Padding = new Thickness(5, 25, 5, 5);

            PowerManagement.ChargeStatusChanged += (sender, e) => _chargeStatusLabel.Text = "Charge Status: " + PowerManagement.ChargeStatus.ToString();
            PowerManagement.BatteryStatusChanged += (s, e) => _batteryStatusLabel.Text = "Battery Status:" + PowerManagement.BatteryStatus.ToString();


        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            UpdatePowerLabels();
            UpdateHardwareLabels();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (_button.Text == StartText)
            {
                _button.Text = StopText;
                var status = AbstractScanner.NetStandard.Hardware.Scanner.Start();
                _statusLabel.Text = "Connection Status: " + status.ToString();
            }
            else
            {
                _button.Text = StartText;
                AbstractScanner.NetStandard.Hardware.Scanner.Stop();
                _statusLabel.Text = "Connection Status: " + "Disconnected";
            }
        }

        private async void OnGetBatteryInfoButtonClicked(object sender, EventArgs e)
            => await UpdatePowerLabels();


        void OnScannerDataReceived(object sender, string e)
        {
            _dataLabel.Text = "Data Received: [" + e + "] at " + DateTime.Now;
        }

        async Task UpdatePowerLabels()
        {
            var status = PowerManagement.Start();
            _batteryConnection.Text = "Power Manager: " + status.ToString();
            _batteryStatusLabel.Text = "Battery Status:" + PowerManagement.BatteryStatus.ToString();
            _chargeStatusLabel.Text = "Charge Status: " + PowerManagement.ChargeStatus.ToString();
            var info = await PowerManagement.GetBatteryInfoAsync();
            _batteryPercentLabel.Text = "Battery %: " + info?.Percentage.ToString();
            _batteryVoltageLabel.Text = "Battery V: " + info?.Voltage.ToString();
            _batteryTemperatureLabel.Text = "Battery °K: " + info?.Temperture.ToString();
            _batteryRemainCapacityLabel.Text = "Battery Capacity: " + info?.RemainCapacity + " / " + info?.TotalCapacity;
            System.Diagnostics.Debug.WriteLine("");
            PowerManagement.Stop();
            _batteryConnection.Text = "Power Manager: " + "Disconnected";
        }

        void UpdateHardwareLabels()
        {
            _hwNameLabel.Text = "Name: " + AbstractScanner.NetStandard.Hardware.Device.Name;
            _hwModelLabel.Text = "Model: " + AbstractScanner.NetStandard.Hardware.Device.Model;
            _hwSerialLabel.Text = "Serial: " + AbstractScanner.NetStandard.Hardware.Device.Serial;
            _hwFirmwareLabel.Text = "Firmware: " + AbstractScanner.NetStandard.Hardware.Device.FirmwareRevision;
            _hwRevisionLabel.Text = "Revision: " + AbstractScanner.NetStandard.Hardware.Device.HardwareRevision;
            _hwManufacturerLabel.Text = "Mfgr: " + AbstractScanner.NetStandard.Hardware.Device.Manufacturer;
            _hwSdkBuildLabel.Text = "SDK Build: " + AbstractScanner.NetStandard.Hardware.Device.SdkBuild;
            _hwSdkFullVersionLabel.Text = "SDK Version: " + AbstractScanner.NetStandard.Hardware.Device.SdkFullVersion;
            _hwSdkShortVersionLabel.Text = "SDK Version: " + AbstractScanner.NetStandard.Hardware.Device.SdkShortVersion;
            _hwDebug.Text = "Debug: " + AbstractScanner.NetStandard.Hardware.Device.Debug.ToString();
        }
    }
}

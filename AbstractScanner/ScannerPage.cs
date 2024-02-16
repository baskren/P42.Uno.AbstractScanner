using System;
using Xamarin.Essentials;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZXing.Net.Mobile.Uno;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Controls;
using P42.Uno.Markup;

namespace AbstractScanner
{
    public static class ScannerPage
    {
        #region Methods
        public static async Task<ZXing.Result> ScanAsync()
        {
            var completionTask = new TaskCompletionSource<ZXing.Result>();
            if (Platform.MainWindow.Content is Microsoft.UI.Xaml.Controls.Frame rootFrame)
            {
                rootFrame.Navigate(typeof(InternalScannerPage), completionTask);
                //rootFrame.Navigate(typeof(TestPage));
            }
            return await completionTask.Task;
        }
        #endregion

    }

    [Bindable]
    public partial class InternalScannerPage : ZXing.Net.Mobile.Uno.ZXingScannerPage
    {

        //const string TorchOnString = "〉〉⚡〈〈";
        //static readonly string TorchOffString = OperatingSystem.IsAndroid()
        //            ? "_ ⚡ _"
        //            : "_ _ ⚡ _ _";

        #region Fields
        static ZXing.Mobile.MobileBarcodeScanningOptions _options = new ZXing.Mobile.MobileBarcodeScanningOptions
        {
            AutoRotate = false,
            DelayBetweenAnalyzingFrames = 5,
            DelayBetweenContinuousScans = 5,
            PossibleFormats = new List<ZXing.BarcodeFormat>
                    {
                        (ZXing.BarcodeFormat)0xFFFFF
                    }
        };

        TaskCompletionSource<ZXing.Result> ScanTaskCompletionSource; // = new TaskCompletionSource<ZXing.Result>();

        /*
        AppBarButton TorchButton = new AppBarButton()
            .Label(TorchOffString)
            .Icon(new FontIcon()
                .Glyph("\uE945")
                //.FontFamily("ms-appx:///AbstractScanner/Assets/Fonts/SegoeMDL2#Segoe MDL2 Assets")
                .FontFamily(Microsoft.UI.Xaml.Application.Current.Resources["SymbolThemeFontFamily"] as Microsoft.UI.Xaml.Media.FontFamily)
            );
        */

        public bool IsActive { get; private set; }
        #endregion


        #region Constructor / Disposer
        public InternalScannerPage() : base(_options) //, _overlay)
        {
            Padding = global::Uno.UI.Toolkit.VisibleBoundsPadding.WindowPadding;
            Title = "BARCODE SCAN";
            //TorchButton.AddClickHandler(OnTorchButtonClicked);
            //AddSecondaryButton(TorchButton);
        }

        #endregion


        #region Event Handlers

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is TaskCompletionSource<ZXing.Result> tcs)
                ScanTaskCompletionSource = tcs;
            else
                throw new Exception("InnerScannerPage was somehow instantiated without a TaskCompletionSource!");

            base.OnNavigatedTo(e);
            IsActive = true;
            
            OnScanResult += ScannerPage_OnScanResult;

            if (OperatingSystem.IsAndroid())
                P42.Utils.Timer.StartTimer(TimeSpan.FromSeconds(0.25), () =>
                {
                    Inititialize();
                    return false;
                });
            else
                Inititialize();
            //UpdateTorchLabel();
        }

        void Inititialize()
        {
            if (Preferences.Get("IsScanTorchOn", false))
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    ToggleTorch();
                    //UpdateTorchLabel();
                });
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            IsActive = false;
            base.OnNavigatedFrom(e);
            OnScanResult -= ScannerPage_OnScanResult;
            ScanTaskCompletionSource?.TrySetResult(null);
        }

        async void ScannerPage_OnScanResult(ZXing.Result result)
        {
            ScanTaskCompletionSource.TrySetResult(result);
            ScanTaskCompletionSource = null;
            GoBack();
            await Task.Delay(5);
        }

        /*
        private void OnTorchButtonClicked(object sender, EventArgs e)
        {
            ToggleTorch();
            Preferences.Set("IsScanTorchOn", !Preferences.Get("IsScanTorchOn", false));
            UpdateTorchLabel();
        }

        void UpdateTorchLabel()
        {
            var isOn = Preferences.Get("IsScanTorchOn", false);
            System.Diagnostics.Debug.WriteLine("IsTorchOn=[" + isOn + "]");
            TorchButton.Label = isOn
                ? TorchOnString
                : TorchOffString;
        }
        */
        #endregion



    }
}

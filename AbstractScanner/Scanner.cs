using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractScanner.NetStandard.Hardware;
using ZXing.Net.Mobile.Uno;

namespace AbstractScanner
{
    public static class Scanner
    {

        #region Fields
        static TaskCompletionSource<string> ScanTaskCompletionSource;
        #endregion


        #region Events
        public static event EventHandler<Device> Connected;
        public static event EventHandler<string> DataReceived;
        #endregion


        #region Methods
        public static async Task<string> Scan()
        {
            ScanTaskCompletionSource = new TaskCompletionSource<string>();
            if (AbstractScanner.NetStandard.Hardware.Scanner.Start() is NetStandard.Hardware.ConnectionStatus status && status.IsConnected())
            {
                Connected?.Invoke(null, Device.Captuvo);
                // use Captuvo
                AbstractScanner.NetStandard.Hardware.Scanner.DataReceived += OnCaptuvoDataReceived;
            }
            /*
            else
            {
#if ANDROID
                var os = "Android";
#else
                var os = "iOS";
#endif
                await P42.Uno.Controls.Toast.CreateAsync($"Cannot start camera scanner.  Go to the {os} Settings app to verify that Camera permissions have been granted to this app.");
                return string.Empty;
            }
            */
            
            Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(async () =>
            {
                P42.Uno.Controls.Popups.Hide();
                    
                Connected?.Invoke(null, Device.ZXing);
                var result = await ScannerPage.ScanAsync();
                if (!string.IsNullOrEmpty(result?.Text))
                    DataReceived?.Invoke(AbstractScanner.Device.ZXing, result.Text.Trim());
                    
                P42.Uno.Controls.Popups.Show();
                Disconnect();

                ScanTaskCompletionSource.SetResult(result?.Text?.Trim());
            });
            

            return await ScanTaskCompletionSource.Task;
        }

        private static void OnCaptuvoDataReceived(object sender, string e)
        {
            DataReceived?.Invoke(null, e?.Trim());
            ScanTaskCompletionSource.SetResult(e?.Trim());
            Disconnect();
        }


        public static void Cancel()
        {
            ScanTaskCompletionSource.SetResult(string.Empty);
            Disconnect();
        }
        
        static void Disconnect()
        {
            AbstractScanner.NetStandard.Hardware.Scanner.DataReceived -= OnCaptuvoDataReceived;
            Connected?.Invoke(null, Device.None);
        }

#endregion


    }
}

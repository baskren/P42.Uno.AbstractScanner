using System;
using Android.Content;
using Android.OS;

namespace AbstractScanner.Zebra.Droid
{
    public static class Settings
    {
        static Android.App.Activity Activity;
        static string EXTRA_PROFILE_NAME;

        const string ACTION_DATAWEDGE_FROM_6_2 = "com.symbol.datawedge.api.ACTION";
        const string EXTRA_CREATE_PROFILE = "com.symbol.datawedge.api.CREATE_PROFILE";
        const string EXTRA_SET_CONFIG = "com.symbol.datawedge.api.SET_CONFIG";
        //private static string EXTRA_PROFILE_NAME = "Inventory DEMO";
        private static DataWedgeReceiver _broadcastReceiver = null;

        public static event EventHandler<string> DataReceived;

        public static void OnResume()
        {
            if (null != _broadcastReceiver)
            {
                // Register the broadcast receiver
                IntentFilter filter = new IntentFilter(DataWedgeReceiver.IntentAction);
                filter.AddCategory(DataWedgeReceiver.IntentCategory);
                Android.App.Application.Context.RegisterReceiver(_broadcastReceiver, filter);
            }
        }

        public static void OnPause()
        {
            if (null != _broadcastReceiver)
            {
                // Unregister the broadcast receiver
                Android.App.Application.Context.UnregisterReceiver(_broadcastReceiver);
            }
        }

        public static void Initiate(Android.App.Activity activity, string profileName = null)
        {

            _broadcastReceiver = new DataWedgeReceiver();
            _broadcastReceiver.ScanDataReceived += (s, scanData) =>
            {
                DataReceived?.Invoke(null, scanData);
            };

            if (string.IsNullOrWhiteSpace(profileName))
                profileName = activity.PackageName + ".ZebraScannerProfile";

            EXTRA_PROFILE_NAME = profileName;
            Activity = activity;

            SendDataWedgeIntentWithExtra(ACTION_DATAWEDGE_FROM_6_2, EXTRA_CREATE_PROFILE, profileName);

            //  Now configure that created profile to apply to our application
            Bundle profileConfig = new Bundle();
            profileConfig.PutString("PROFILE_NAME", EXTRA_PROFILE_NAME);
            profileConfig.PutString("PROFILE_ENABLED", "true"); //  Seems these are all strings
            profileConfig.PutString("CONFIG_MODE", "UPDATE");
            Bundle barcodeConfig = new Bundle();
            barcodeConfig.PutString("PLUGIN_NAME", "BARCODE");
            barcodeConfig.PutString("RESET_CONFIG", "true"); //  This is the default but never hurts to specify
            Bundle barcodeProps = new Bundle();
            barcodeConfig.PutBundle("PARAM_LIST", barcodeProps);
            profileConfig.PutBundle("PLUGIN_CONFIG", barcodeConfig);
            Bundle appConfig = new Bundle();
            appConfig.PutString("PACKAGE_NAME", Activity.PackageName);      //  Associate the profile with this app
            appConfig.PutStringArray("ACTIVITY_LIST", new string[] { "*" });
            profileConfig.PutParcelableArray("APP_LIST", new Bundle[] { appConfig });
            SendDataWedgeIntentWithExtra(ACTION_DATAWEDGE_FROM_6_2, EXTRA_SET_CONFIG, profileConfig);
            //  You can only configure one plugin at a time, we have done the barcode input, now do the intent output
            profileConfig.Remove("PLUGIN_CONFIG");
            Bundle intentConfig = new Bundle();
            intentConfig.PutString("PLUGIN_NAME", "INTENT");
            intentConfig.PutString("RESET_CONFIG", "true");
            Bundle intentProps = new Bundle();
            intentProps.PutString("intent_output_enabled", "true");
            intentProps.PutString("intent_action", DataWedgeReceiver.IntentAction);
            intentProps.PutString("intent_delivery", "2");
            intentConfig.PutBundle("PARAM_LIST", intentProps);
            profileConfig.PutBundle("PLUGIN_CONFIG", intentConfig);
            SendDataWedgeIntentWithExtra(ACTION_DATAWEDGE_FROM_6_2, EXTRA_SET_CONFIG, profileConfig);

            AbstractScanner.NetStandard.Hardware.Scanner.PlatformScanner = new Scanner();
        }

        static void SendDataWedgeIntentWithExtra(string action, string extraKey, Bundle extras)
        {
            Intent dwIntent = new Intent();
            dwIntent.SetAction(action);
            dwIntent.PutExtra(extraKey, extras);
            Activity.SendBroadcast(dwIntent);
        }

        static void SendDataWedgeIntentWithExtra(string action, string extraKey, string extraValue)
        {
            Intent dwIntent = new Intent();
            dwIntent.SetAction(action);
            dwIntent.PutExtra(extraKey, extraValue);
            Activity.SendBroadcast(dwIntent);
        }

    }
}

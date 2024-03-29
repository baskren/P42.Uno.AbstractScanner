﻿using System;
using Android.Content;

namespace AbstractScanner.Zebra.Droid
{
    [BroadcastReceiver]
    public class DataWedgeReceiver : BroadcastReceiver
    {
        // This intent string contains the source of the data as a string
        const string SOURCE_TAG = "com.motorolasolutions.emdk.datawedge.source";
        // This intent string contains the barcode symbology as a string
        const string LABEL_TYPE_TAG = "com.motorolasolutions.emdk.datawedge.label_type";
        // This intent string contains the captured data as a string
        // (in the case of MSR this data string contains a concatenation of the track data)
        const string DATA_STRING_TAG = "com.motorolasolutions.emdk.datawedge.data_string";
        // Intent Action for our operation
        public const string IntentAction = "barcodescanner.RECVR";
        public const string IntentCategory = "android.intent.category.DEFAULT";

        public event EventHandler<string> ScanDataReceived;

        public override void OnReceive(Context context, Intent i)
        {
            // check the intent action is for us
            if (i.Action.Equals(IntentAction))
            {
                // define a string that will hold our output
                var Out = "";
                // get the source of the data
                var source = i.GetStringExtra(SOURCE_TAG);
                // save it to use later
                if (source == null)
                    source = "scanner";
                // get the data from the intent
                var data = i.GetStringExtra(DATA_STRING_TAG);
                // let's define a variable for the data length
                int data_len = 0;
                // and set it to the length of the data
                if (data != null)
                    data_len = data.Length;
                // check if the data has come from the barcode scanner
                if (source.Equals("scanner"))
                {
                    // check if there is anything in the data
                    if (data != null && data.Length > 0)
                    {
                        // we have some data, so let's get it's symbology
                        var sLabelType = i.GetStringExtra(LABEL_TYPE_TAG);
                        // check if the string is empty
                        if (sLabelType != null && sLabelType.Length > 0)
                        {
                            // format of the label type string is LABEL-TYPE-SYMBOLOGY
                            // so let's skip the LABEL-TYPE- portion to get just the symbology
                            sLabelType = sLabelType.Substring(11);
                        }
                        else
                        {
                            // the string was empty so let's set it to "Unknown"
                            sLabelType = "Unknown";
                        }

                        // let's construct the beginning of our output string
                        Out = data.ToString() + "\r\n";
                    }
                }

                ScanDataReceived?.Invoke(this, Out);
            }
        }
    }
}

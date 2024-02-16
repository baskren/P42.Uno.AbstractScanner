using System;
using AbstractScanner.NetStandard.Hardware;
using Android.Provider;

namespace AbstractScanner.Zebra.Droid
{
    public class Scanner : AbstractScanner.NetStandard.Hardware.IScanner
    {
        bool isEnabled;

        public Scanner()
        {
            AbstractScanner.Zebra.Droid.Settings.DataReceived += OnDataReceived;
        }

        private void OnDataReceived(object sender, string e)
        {
            if (isEnabled)
            {
                DataReceived?.Invoke(this, e);
                RawDataReceived?.Invoke(this, System.Text.Encoding.UTF8.GetBytes(e));
            }
        }

        public TriggerKeyStatus TriggerKeyStatus => throw new NotImplementedException();

        public event EventHandler<string> DataReceived;
        public event EventHandler<byte[]> RawDataReceived;



        public ConnectionStatus Enable()
        {
            isEnabled = true;
            return ConnectionStatus.StatusConnected;
        }

        public ConnectionStatus Start()
        {
            isEnabled = true;
            return ConnectionStatus.StatusConnected;
        }

        public void Stop()
        {
            isEnabled = false;
        }
    }
}

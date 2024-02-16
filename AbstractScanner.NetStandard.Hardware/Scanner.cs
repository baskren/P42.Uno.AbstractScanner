using System;

namespace AbstractScanner.NetStandard.Hardware
{
    public static class Scanner
    {
        static IScanner _platformScanner;
        internal static IScanner PlatformScanner
        {
            get => _platformScanner;
            set
            {
                if (_platformScanner != null)
                {
                    _platformScanner.DataReceived -= OnDataReceived;
                    _platformScanner.RawDataReceived -= OnRawDataReceived;
                }
                _platformScanner = value;
                if (_platformScanner != null)
                {
                    _platformScanner.DataReceived += OnDataReceived;
                    _platformScanner.RawDataReceived += OnRawDataReceived;
                }
            }
        }

        public static ConnectionStatus? Start() => PlatformScanner?.Start();

        public static ConnectionStatus? Enable() => PlatformScanner?.Enable();

        public static void Stop() => PlatformScanner?.Stop();

        
        public static event EventHandler<string> DataReceived;

        public static event EventHandler<byte[]> RawDataReceived;

        private static void OnRawDataReceived(object sender, byte[] e)
             => RawDataReceived?.Invoke(sender, e);


        private static void OnDataReceived(object sender, string e)
            => DataReceived?.Invoke(sender, e);

    }
}

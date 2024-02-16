using System;
namespace AbstractScanner.NetStandard.Hardware
{
    public interface IScanner
    {
        ConnectionStatus Start();

        ConnectionStatus Enable();

        void Stop();

        event EventHandler<string> DataReceived;

        event EventHandler<byte[]> RawDataReceived;

        TriggerKeyStatus TriggerKeyStatus { get; }
    }

}

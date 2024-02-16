using System;
using AbstractScanner.NetStandard.Hardware;
namespace AbstractScanner.Captuvo.iOS
{
    public static class BatteryDetailInfoExtentions
    {
        public static BatteryDetailInfo ToAbstract(this CaptuvoSDK.cupertinoBatteryDetailInfo cupertinoBattery)
        {
            if (cupertinoBattery == null)
                return null;
            var result = new BatteryDetailInfo
            {
                Valid = cupertinoBattery.Valid,
                Percentage = cupertinoBattery.Percentage,
                RemainCapacity = cupertinoBattery.RemainCapacity,
                TotalCapacity = cupertinoBattery.TotalCapacity,
                Temperture = (float)cupertinoBattery.Temperture,
                Voltage = (float)cupertinoBattery.Voltage
            };
            return result;
        }
    }
}

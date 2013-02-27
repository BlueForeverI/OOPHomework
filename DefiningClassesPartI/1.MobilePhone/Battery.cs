using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.MobilePhone
{
    /// <summary>
    /// Stores information about the phone battery type
    /// </summary>
    enum BatteryType
    {
        LiIon,
        LiPo,
        NiMH,
        NiCd
    }

    /// <summary>
    /// Stores information about the phone battery characteristics
    /// </summary>
    class Battery
    {
        public string Model { get; private set; }
        public int? HoursIdle { get; private set; }
        public int? HoursTalk { get; private set; }
        public BatteryType? BatteryType { get; private set; }

        public Battery(string model, int? hoursIdle = null, int? hoursTalk = null,
            BatteryType? batteryType = null)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }
    }
}

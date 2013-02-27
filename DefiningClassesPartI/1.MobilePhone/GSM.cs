using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.MobilePhone
{
    /// <summary>
    /// Stores general information about the mobile phone
    /// </summary>
    class GSM
    {
        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        public double? Price { get; private set; }
        public string Owner { get; private set; }
        public Battery BatteryCharacteristics { get; private set; }
        public Display DisplayCharacteristics { get; private set; }
        public static GSM IPhone4S { get { return iphone4s; } }

        /// <summary>
        /// Call log
        /// </summary>
        public List<Call> CallHistory { get; private set; }

        /// <summary>
        /// Static field to hold Iphone4S characteristics
        /// </summary>
        private static GSM iphone4s = new GSM("IPhone 4S", "Apple",
            1000.0, "Georgi Georgiev", 
            new Battery("Standard", 200, 14, BatteryType.LiPo),
            new Display(3.5, 16000000));

        public GSM(string model, string manufacturer, double? price = null, 
            string owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.BatteryCharacteristics = battery;
            this.DisplayCharacteristics = display;
            this.CallHistory = new List<Call>();
        }

        /// <summary>
        /// Adds a call to the call log
        /// </summary>
        /// <param name="call">The call to add</param>
        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        /// <summary>
        /// Removes a call from the call log
        /// </summary>
        /// <param name="call">The call to remove</param>
        public void RemoveCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        /// <summary>
        /// Clears the call log
        /// </summary>
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        /// <summary>
        /// Calculates the total price of all calls in the log
        /// </summary>
        /// <param name="pricePerMinute">Price of one minute of talking</param>
        /// <returns>The total price of all calls</returns>
        public double GetTotalPriceOfCalls(double pricePerMinute)
        {
            int totalMinutes = (from c in this.CallHistory
                                select c.Duration).Sum()  /60;

            return pricePerMinute * totalMinutes;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Model: {0}", this.Model));
            sb.AppendLine(string.Format("Manufacturer: {0}", this.Manufacturer));
            sb.AppendLine(string.Format("Price: {0}", this.Price));
            sb.AppendLine(string.Format("Owner: {0}", this.Owner));
            sb.AppendLine("Battery Info:");
            sb.AppendLine(string.Format("\tModel: {0}", this.BatteryCharacteristics.Model));
            sb.AppendLine(string.Format("\tHours Idle: {0}", this.BatteryCharacteristics.HoursIdle));
            sb.AppendLine(string.Format("\tHours Talk: {0}", this.BatteryCharacteristics.HoursTalk));
            sb.AppendLine(string.Format("\tType: {0}", this.BatteryCharacteristics.BatteryType));
            sb.AppendLine("Display Info:");
            sb.AppendLine(string.Format("\tDisplay Size: {0} inches", this.DisplayCharacteristics.Size));
            sb.AppendLine(string.Format("\tNumber of Colors: {0}", this.DisplayCharacteristics.NumberOfColors));

            return sb.ToString();
        }
    }
}

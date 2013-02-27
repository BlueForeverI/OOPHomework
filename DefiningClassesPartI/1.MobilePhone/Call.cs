using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.MobilePhone
{
    /// <summary>
    /// Stores information about calls
    /// </summary>
    class Call
    {
        public string Date { get; private set; }
        public string Time { get; private set; }
        public string DialedNumber { get; private set; }
        public int Duration { get; private set; }

        public Call(string dateTime, string dialedNumber, int duration)
        {
            DateTime date = DateTime.Parse(dateTime);
            this.Date = string.Format("{0}.{1}.{2}", date.Day, date.Month, date.Year);
            this.Time = string.Format("{0}:{1}:{2}", date.Hour, date.Minute, date.Second);
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Date: {0}", this.Date));
            sb.AppendLine(string.Format("Time: {0}", this.Time));
            sb.AppendLine(string.Format("Dialed Number: {0}", this.DialedNumber));
            sb.AppendLine(string.Format("Duration: {0}", this.Duration));

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.MobilePhone
{
    /// <summary>
    /// Stores information about the phone display characteristics
    /// </summary>
    class Display
    {
        public double Size { get; private set; }
        public long? NumberOfColors { get; private set; }

        public Display(double size, long? numberOfColors = null)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
    }
}

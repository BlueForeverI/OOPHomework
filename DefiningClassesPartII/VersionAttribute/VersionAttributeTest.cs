using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VersionAttribute
{
    /// <summary>
    /// Tests the custom Version attribute
    /// </summary>
    [Version(3, 1)]
    class VersionAttributeTest
    {
        static void Main(string[] args)
        {
            Type type = typeof (VersionAttributeTest);
            VersionAttribute attribute = type.GetCustomAttributes(false)[0] as VersionAttribute;

            Console.WriteLine("Major Version: " + attribute.Major);
            Console.WriteLine("Minor Versoin: " + attribute.Minor);
        }
    }
}

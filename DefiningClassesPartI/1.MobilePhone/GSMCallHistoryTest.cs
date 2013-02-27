using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.MobilePhone
{
    /// <summary>
    /// A class to test the phone call log
    /// </summary>
    class GSMCallHistoryTest
    {
        public static void ShowGSMCallHistoryTest()
        {
            GSM gsm = new GSM("Xperia S", "Sony", 350, "Nikolay Dimitrov",
                              new Battery("Standard", 420, 25, BatteryType.LiIon),
                              new Display(4.3, 16000000));

            //fill the call log
            gsm.AddCall(new Call("14.11.2012 12:50", "0888121314", 120));
            gsm.AddCall(new Call("16.11.2012 20:35", "0888156714", 317));
            gsm.AddCall(new Call("17.11.2012 17:21", "0886987651", 135));

            Console.WriteLine("Call history information:");
            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine("{0}\n", call);
            }

            //calculate total price
            double pricePerMinute = 0.37;
            Console.WriteLine("Total price of the calls: {0}", 
                gsm.GetTotalPriceOfCalls(pricePerMinute));

            //get and remove the longest call
            Call longestCall = (from c in gsm.CallHistory
                                orderby c.Duration
                                select c).Last();
            gsm.RemoveCall(longestCall);

            Console.WriteLine("Longest call removed, total price: {0}", 
                gsm.GetTotalPriceOfCalls(pricePerMinute));

            //clear call history
            gsm.ClearCallHistory();
            Console.WriteLine("Call history cleared; call history: ");
            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine("{0}\n", call);
            }
        }
    }
}

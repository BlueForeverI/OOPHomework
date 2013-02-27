using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.MobilePhone
{
    class GSMTest
    {
        public static void ShowGSMTest()
        {
            //create a few instances of the GSM class
            GSM[] phones = new GSM[]
                                {
                                    new GSM("Xperia X10", "Sony", 270, "Petar Petrov",
                                            new Battery("Standard", 400, 20, BatteryType.LiPo),
                                            new Display(4.0, 265000)),

                                    new GSM("Xperia S", "Sony", 350, "Nikolay Dimitrov",
                                            new Battery("Standard", 420, 25, BatteryType.LiIon),
                                            new Display(4.3, 16000000)),

                                    new GSM("Galaxy S3", "Samsung", 700, "Ivan Ivanov",
                                            new Battery("Standard", 450, 30, BatteryType.LiPo),
                                            new Display(4.5, 16000000)),
                                };

            Console.WriteLine("Information about some GSMs: ");
            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
            }

            Console.WriteLine("IPhone 4S Information:\n{0}", GSM.IPhone4S);
        }
    }
}

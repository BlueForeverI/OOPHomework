using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.ExecutingTimer
{
    class TimerTest
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(MethodToExecute, 1);

            Console.WriteLine("Press X to exit");
            timer.Start();

            // just let the timer call the method
            while (Console.ReadKey().Key != ConsoleKey.X)
            {
                
            }

            timer.Stop();
        }

        // method to be executed every t seconds
        private static void MethodToExecute()
        {
            Console.WriteLine("This is called after every interval");
        }
    }
}

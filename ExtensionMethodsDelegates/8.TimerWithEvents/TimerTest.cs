using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.TimerWithEvents
{
    class TimerTest
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(1);
            timer.Started += Started;
            timer.Executed += Executed;
            timer.Stopped += Stopped;

            timer.Start();

            // Press X to exit
            while(Console.ReadKey().Key != ConsoleKey.X)
            {
                
            }

            timer.Stop();
        }

        private static void Started(EventArgs e)
        {
            Console.WriteLine("Timer started");
        }

        private static void Executed(EventArgs e)
        {
            Console.WriteLine("Executed");
        }

        private static void Stopped(EventArgs e)
        {
            Console.WriteLine("Timer stopped");
        }
    }
}

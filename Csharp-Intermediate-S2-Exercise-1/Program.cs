using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Csharp_Intermediate_S2_Exercise_1
{
    class Program {

        // Design a class called Stopwatch.The job of this class is to simulate a stopwatch.It should
        // provide two methods: Start and Stop.We call the start method first, and the stop method next.
        // Then we ask the stopwatch about the duration between start and stop. Duration should be a
        // value in TimeSpan.Display the duration on the console.

        // We should also be able to use a stopwatch multiple times. So we may start and stop it and then
        // start and stop it again. Make sure the duration value each time is calculated properly.

        // We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
        // start time). So the class should throw an InvalidOperationException if its started twice.


    
        public static int secondsCount = 0;
        public static Timer aTmr = new Timer(1000);

        static void Main(string[] args)
        {
            aTmr.Elapsed += ATmr_Elapsed;
            aTmr.Enabled = true;
            aTmr.AutoReset = true;
            aTmr.Start();
            Console.ReadKey();
            stopTimer(secondsCount);

            

        }

        private static void ATmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            while(secondsCount < 5)
            {
                secondsCount++;
                Console.WriteLine(secondsCount + " Seconds");
            }
        }

        public static void stopTimer(int seconds)
        {
            if (seconds == 5)
            {
                aTmr.Stop();
            }
        }
    }
}

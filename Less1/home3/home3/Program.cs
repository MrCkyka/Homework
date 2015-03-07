using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace home3
{
    class Program
    {
        static int Sek = 0;

        static void Main(string[] args)
        {
            TimerCallback timercallback = new TimerCallback(TimerTick);
            Timer timer = new Timer(timercallback);
            Console.WriteLine("Press any key...");
            Thread.Sleep(1000);
            Console.WriteLine("\nRUN!!!\n");
            timer.Change(1000, 1000); 
            Console.ReadKey(); 
            Console.Clear();
            Console.WriteLine("Nice! Your time = {0} sekond(s)\n\n",Sek);
            timer.Dispose();
            Thread.Sleep(30000);
        }

        static void TimerTick(object obj)
        {
            Sek++;
            
            if (Sek >= 10)
            {
                Timer timemachine = (Timer)obj;
                timemachine.Dispose();
                Console.WriteLine("What's problem man? Can't find \"ANY KEY\"?");
            }

        }
    }
}

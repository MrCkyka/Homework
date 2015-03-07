using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.IO;

namespace home2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParameterizedThreadStart threadstart = new ParameterizedThreadStart(Funk);
            //ArrayList arr = new ArrayList(new string[] { "one", "two", "three", "4", "5" });

            //foreach (object obj in arr)
            //{
            //    Thread thread = new Thread(threadstart);
            //    thread.Start(obj);
            //}
            Bank NewBank = new Bank();
            NewBank.Money = 9999;
            NewBank.Name = "New Bank";
            NewBank.Percent = 99;
            Console.WriteLine("Any key...");
            Console.ReadKey();
        }

        static void Funk(object obj)
        {
            Console.WriteLine(obj.ToString());
            Thread.Sleep(500);
        }

       
    }
}

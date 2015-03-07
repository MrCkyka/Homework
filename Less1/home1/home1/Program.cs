using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace home1
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart threadstart = new ParameterizedThreadStart(Funk);
            ArrayList arr = new ArrayList(new string[]{"one","two","three","4","5"});

            foreach (object obj in arr)
            {
                Thread thread = new Thread(threadstart);
                thread.Start(obj);
            }

            Console.ReadKey();
        }

        static void Funk(object obj)
        {
               Console.WriteLine(obj.ToString());
               Thread.Sleep(500);                    
        }
    }
}

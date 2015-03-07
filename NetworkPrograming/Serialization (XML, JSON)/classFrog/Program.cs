using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace classFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            Frog frog = new Frog();
            frog.name = "dds";
            frog.age = 42;
            frog.par = new int[] { 4, 5, 6 };

            string output = JsonConvert.SerializeObject(frog);
            Frog2 deserializedfrog = JsonConvert.DeserializeObject<Frog2>(output);

            Console.WriteLine(output);
            
            Console.WriteLine(deserializedfrog);
            Console.WriteLine(deserializedfrog.frogname);
            Console.WriteLine(deserializedfrog.age);
            Console.WriteLine(deserializedfrog.par[1]);
          
        }
    }
}

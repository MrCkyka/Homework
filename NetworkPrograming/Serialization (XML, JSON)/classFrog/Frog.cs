using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace classFrog
{
    class Frog
    {
        public int age;
        public string name;
        public int[] par;


    }
    class Frog2
    {
        public int age;
        public int[] par;
        [JsonProperty("name")]
        public string frogname;
        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home1._01
{
    public interface Factory
    {
        String GetRead();
        String GetReadLine();

        String GetWrite(string text);
        String GetWriteLine(string text);

    }

    public class FactoryCSharp : Factory
    {
        public String GetRead()
        {
            return "string text=Console.Read();";
        }
        public String GetReadLine()
        {
            return "string text=Console.ReadLine();";
        }
        public String GetWrite(string text)
        {
            return "Console.Write(\"" + text + "\");";
        }
        public String GetWriteLine(string text)
        {
            return "Console.WriteLine(\"" + text + "\");";
        }
    }

    public class FactoryCPlus : Factory
    {
        public String GetRead()
        {
            return "cin>>text;";
        }
        public String GetReadLine()
        {
            return "cin>>text;";
        }
        public String GetWrite(string text)
        {
            return "cout<<\""+text+"\";";
        }
        public String GetWriteLine(string text)
        {
            return "cout<<\""+text+"\"<<\"\\n\"";
        }
    }
}

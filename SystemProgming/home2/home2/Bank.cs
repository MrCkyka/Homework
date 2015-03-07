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
    class Bank
    {
        private static int BankNamber = 0;
        private string FailName;
        private int money;
        private string name;
        private int percent;


        public Bank()
        {
            BankNamber++;
            money = 10000;
            percent = 30;
            name = "Bank " + BankNamber.ToString();
            FailName = name + ".txt";
            FileInfo file = new FileInfo(FailName);
            if (file.Exists == true)
            {
                file.Delete();
            }
            StreamWriter write_text;
            write_text = file.CreateText();
            write_text.WriteLine("Name = {0}, Money={1} , Percent={2}", name, money, percent);
            write_text.Close();
        }

        public int Money
        {
            get { return money; }
            set
            {
                StreamWriter write_text;
                FileInfo file = new FileInfo(FailName);
                write_text = file.AppendText();
                write_text.WriteLine("\nChanged! old Money={0}, now Money={1}", money, value);
                write_text.Close();
                money = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                StreamWriter write_text;
                FileInfo file = new FileInfo(FailName);
                write_text = file.AppendText();
                write_text.WriteLine("\nChanged! old Name={0} , now Name={1}", name, value);
                write_text.Close();
                name = value;
            }
        }
        public int Percent
        {
            get { return percent; }
            set
            {
                StreamWriter write_text;
                FileInfo file = new FileInfo(FailName);
                write_text = file.AppendText();
                write_text.WriteLine("\nChanged! old Percent={0} , now Percent={1}", percent, value);
                write_text.Close();
                percent = value;
            }
        }
    }
}

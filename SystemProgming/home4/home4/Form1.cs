using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace home4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string a;
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                a = p.Id+" : "+p.ProcessName +Environment.NewLine;
                textBox1.Text += a;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}

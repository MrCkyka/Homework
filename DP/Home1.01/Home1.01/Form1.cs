using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home1._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Read");
            comboBox1.Items.Add("ReadLine");
            comboBox1.Items.Add("Write");
            comboBox1.Items.Add("WriteLine");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                textBox1.Visible = false;
            }
            else textBox1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
               FactoryCSharp CFactory = new FactoryCSharp();
               switch (comboBox1.SelectedIndex)
               {
                   case 0:
                       textBox2.Clear();
                       textBox2.AppendText(CFactory.GetRead());
                       break;
                   case 1:
                       textBox2.Clear();
                       textBox2.AppendText(CFactory.GetReadLine());
                       break;
                   case 2:
                       textBox2.Clear();
                       textBox2.AppendText(CFactory.GetWrite(textBox1.Text));
                       break;
                   case 3:
                       textBox2.Clear();
                       textBox2.AppendText(CFactory.GetWriteLine(textBox1.Text));
                       break;
               }
            }
            else
            {
                FactoryCPlus CFactory = new FactoryCPlus();
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        textBox2.Clear();
                        textBox2.AppendText(CFactory.GetRead());
                        break;
                    case 1:
                        textBox2.Clear();
                        textBox2.AppendText(CFactory.GetReadLine());
                        break;
                    case 2:
                        textBox2.Clear();
                        textBox2.AppendText(CFactory.GetWrite(textBox1.Text));
                        break;
                    case 3:
                        textBox2.Clear();
                        textBox2.AppendText(CFactory.GetWriteLine(textBox1.Text));
                        break;
                }
            }
        }
    }
}
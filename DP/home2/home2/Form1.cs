﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var tripleBuilder = new OfficePC();
            var gaminigBuilder = new GamePC();
            var shopForYou = new BuyPC();
            if (radioButton1.Checked)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

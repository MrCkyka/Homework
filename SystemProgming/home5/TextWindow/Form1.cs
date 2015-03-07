using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
namespace TextWindow
{
    public partial class Form1 : Form
    {
        /*ссылка на модуль, из которого быдем вызывать методы*/
        Module DrawerModule { get; set; }
        /*объект от которого будем вызывать методы*/
        object Drawer;
        public Form1(Module drawer, object targetWindow)
        {
            DrawerModule = drawer;
            Drawer = targetWindow;
            InitializeComponent();
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    /*вызываем метд SetText главного окна приложения TextDrawer*/
        //    DrawerModule.GetType("TextDrawer.Form1").GetMethod("SetText").Invoke(Drawer, new object[]{textBox1.Text});
        //}

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            /*вызываем метд Move главного окна приложения TextDrawer*/
            DrawerModule.GetType("TextDrawer.Form1").GetMethod("Move").Invoke(Drawer, new object[] { new Point(this.Location.X, this.Location.Y + this.Height), this.Width });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String A;
            A = numericUpDown1.Value + "," + numericUpDown2.Value + "," + numericUpDown3.Value + "," 
                + numericUpDown4.Value + "," + numericUpDown5.Value + "," + numericUpDown6.Value + "," 
                + numericUpDown7.Value;
            DrawerModule.GetType("TextDrawer.Form1").GetMethod("SetText").Invoke(Drawer, new object[] {A});

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

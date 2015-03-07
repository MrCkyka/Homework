using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading; 

namespace PortsScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Scan()
        {
            int StartPort = Convert.ToInt32(numericUpDown1.Value);
            int EndPort = Convert.ToInt32(numericUpDown2.Value);
            int i;

            
            listView1.Items.Clear();


            IPAddress IpAddr = IPAddress.Parse("127.0.0.1");
            for (i = StartPort; i <= EndPort; i++)
            {
                IPEndPoint IpEndP = new IPEndPoint(IpAddr, i);
                Socket MySoc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IAsyncResult asyncResult = MySoc.BeginConnect(IpEndP, new AsyncCallback(ConnectCallback), MySoc);
                                
                if (!asyncResult.AsyncWaitHandle.WaitOne(30, false))
                {
                    MySoc.Close();
                    listView1.Items.Add(i.ToString());
                    listView1.Items[i - StartPort].SubItems.Add("Closed");                     
                }
                else
                {
                    MySoc.Close();
                    listView1.Items.Add(i.ToString());
                    listView1.Items[i - StartPort].SubItems.Add("Opened");  
                }
            }
        }


        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                Socket SockClient = (Socket)ar.AsyncState;
                SockClient.EndConnect(ar);               
            }
            catch (Exception e)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scan();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

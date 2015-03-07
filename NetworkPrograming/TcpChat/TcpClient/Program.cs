using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SendMessageFromSocket(11000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }

        static void SendMessageFromSocket(int port)
        {
            byte[] bytes = new byte[1024];
                        
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);
            Socket Sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            Sender.Connect(ipEndPoint);

            Console.Write("Write your message: ");
            string message = Console.ReadLine();
            byte[] msg = Encoding.UTF8.GetBytes(message);
            int bytesSent = Sender.Send(msg);
            int bytesRec = Sender.Receive(bytes);

            Console.WriteLine("\n{0}\n", Encoding.UTF8.GetString(bytes, 0, bytesRec));
            
            if (message.IndexOf("EXIT") == -1)
                SendMessageFromSocket(port);
            Sender.Shutdown(SocketShutdown.Both);
            Sender.Close();
            Console.WriteLine("\nPlease close the window");
        }
    }
}

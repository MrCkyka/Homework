using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net;
using System.Net.Mail;

namespace ftp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //InitializeComponent();
            //SmtpClient client = new SmtpClient();
            //client.Host = "smtp.yandex.ru";
            //client.Port = 587;
            //client.EnableSsl=true;

            //client.Credentials = new NetworkCredential("namepodlec@ya.ru", "Gbdhu7@G21zm1n9251");
            ////client.Credentials = new NetworkCredential("smtp.yandex.ru", "xiiGuzm@niya");

            //MailMessage post = new MailMessage("namepodlec@ya.ru", "namepodlec@ya.ru");
            //post.Subject = "post";
            //post.Body = "message";
            
            //client.Timeout = 3000;
            //client.UseDefaultCredentials = false;
            //client.Send(post);

            InitializeComponent();
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;


            client.Credentials = new NetworkCredential("nameckyka@gmail.com", "xiiGuzm@niya");

            MailMessage post = new MailMessage("nameckyka@gmail.com", "nameckyka@gmail.com");
            post.Subject = "post";
            post.Body = "message";
        
            client.Timeout = 3000;
            client.UseDefaultCredentials = false;
            client.Send(post);


        }
    }
}

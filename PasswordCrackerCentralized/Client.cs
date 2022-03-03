using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCrackerCentralized
{
    class Client
    {
        private const int Port = 7777;
        public Client()
        {

        }

        public void start()
        {
            TcpClient Client = new TcpClient("LocalHost", Port);
            using (StreamWriter sw = new StreamWriter(Client.GetStream()))
            {
                
                
                sw.AutoFlush = true;
                string Hello = "Hello";
                //string helloString = 



            }

        }






    }
}

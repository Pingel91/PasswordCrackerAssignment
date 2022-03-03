using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCrackerCentralized
{
    class Server
    {
        private const int Port = 7777;
        public Server()
        {
            
        }

        public void start()
        {
            TcpListener listener = new TcpListener(Port);
            listener.Start();

            while (true)
            {
                TcpClient socket = listener.AcceptTcpClient();
                Task.Run(
                    () =>
                    {
                        TcpClient tmpSocket = socket;
                        //DoClient(tmpSocket);
                    }
                );
            }
        }

        private void DoClient(TcpClient socket)
        {
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
               
            }
            socket?.Close();
        }


    }
}

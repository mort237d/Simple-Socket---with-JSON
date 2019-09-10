using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using ModelLib;

namespace Assignment_A___PlainClient
{
    class Client
    {
        public void Start()
        {
            Car tesla = new Car(){Color = Color.Red, Model = "Tesla", RegNo = "EL23400" };

            using (TcpClient socket = new TcpClient("localhost", 1001))
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                sw.WriteLine(tesla.ToString());
                sw.Flush();

                Console.WriteLine(tesla.ToString());
            }
        }
    }
}

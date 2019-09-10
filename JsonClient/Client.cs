using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using ModelLib;
using Newtonsoft.Json;

namespace JsonClient
{
    internal class Client
    {
        public void Start()
        {
            Car tesla = new Car() { Color = Color.Green, Model = "Tesla", RegNo = "JsonCar4" };

            using (TcpClient socket = new TcpClient("localhost", 1002))
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                sw.WriteLine(tesla.ToString());
                sw.Flush();

                Console.WriteLine(JsonConvert.SerializeObject(tesla));
            }
        }
    }
}
using System;

namespace JsonServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server s = new Server();
            s.Start();
        }
    }
}

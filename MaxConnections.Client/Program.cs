using System;
using System.Threading;
using System.Threading.Tasks;

namespace MaxConnections.Client
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Started");

            while (true)
            {
                Task.Run(() =>
                {
                    var proxy = new ConnectionServiceProxy();
                    proxy.Test();
                });

                Thread.Sleep(250);
            }
        }
    }
}
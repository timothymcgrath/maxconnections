using System;
using System.ServiceModel;
using MaxConnections.Shared;

namespace MaxConnections.Server
{
    public class Program
    {
        private static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(ConnectionService)))
            {
                host.Open();

                Console.WriteLine("Started");
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
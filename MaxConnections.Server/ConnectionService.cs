using System;
using System.ServiceModel;
using System.Threading;
using MaxConnections.Shared;

namespace MaxConnections.Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ConnectionService
        : IConnectionService
    {
        private static int _counter;
        private static readonly object Lock = new object();

        public void Test()
        {
            lock (Lock)
            {
                _counter++;
            }

            Console.WriteLine($"Active Calls {_counter}");
            Thread.Sleep(30000);

            lock (Lock)
            {
                _counter--;
            }
        }
    }
}
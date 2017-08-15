using System.ServiceModel;
using MaxConnections.Shared;

namespace MaxConnections.Client
{
    public class ConnectionServiceProxy : ClientBase<IConnectionService>, IConnectionService
    {
        public void Test()
        {
            base.Channel.Test();
        }
    }
}
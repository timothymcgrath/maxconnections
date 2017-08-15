using System.ServiceModel;

namespace MaxConnections.Shared
{
    [ServiceContract]
    public interface IConnectionService
    {
        [OperationContract]
        void Test();
    }
}
using RestAndGrpcApp.Protos;

namespace RestAndGrpcApp.Server.Services
{

    /// <summary>
    /// EchoService
    /// </summary>
    public class EchoServiceImpl() : EchoService.EchoServiceBase, IEchoService
    {
        /// <summary>
        /// Echo method
        /// </summary>
        /// <returns></returns>
        public string Echo(string request)
        {
            return $"Hello from EchoService {request}";
        }
    }
}

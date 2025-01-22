using Grpc.Core;
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
        public override Task<EchoResponse> Echo(EchoRequest request, ServerCallContext context)
        {
            var response = new EchoResponse() { Message= $"Response {request.Message}" };

            return Task.FromResult(response);
        }
    }
}

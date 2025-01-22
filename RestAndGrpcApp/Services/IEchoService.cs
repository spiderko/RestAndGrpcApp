using Grpc.Core;
using RestAndGrpcApp.Protos;

namespace RestAndGrpcApp.Server.Services
{
    public interface IEchoService
    {
        Task<EchoResponse> Echo(EchoRequest request, ServerCallContext context);
    }
}
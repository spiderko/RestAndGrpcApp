using Grpc.Core;
using RestAndGrpcApp.Protos;

namespace RestAndGrpcApp.Server.Services {
  public class EngineServiceImpl() : EngineService.EngineServiceBase {
    public override Task<JobCreateResponse> JobCreate(JobCreateRequest request, ServerCallContext context) {
    
    }
  }
}
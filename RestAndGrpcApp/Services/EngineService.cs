using Grpc.Core;
using RestAndGrpcApp.Protos;

namespace RestAndGrpcApp.Server.Services {
  public class EngineServiceImpl() : EngineService.EngineServiceBase {
    public override JobCreateResponse JobCreate(JobCreateRequest) {
    
    }
  }
}
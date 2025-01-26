using Google.Api;
using Grpc.Core;
using RestAndGrpcApp.Protos;

namespace RestAndGrpcApp.Server.Services {
    public class EngineServiceImpl() : Engine.EngineBase
    {
        public override async Task CreateJob(
            JobCreateRequest request, 
            IServerStreamWriter<JobCreateResponse> responseStream, 
            ServerCallContext context)
        {
            var stage = new string[] { "Preparing...", "Calculating...", "Preparing dependencies...", "Working...", "Finishing...", "Done!" };
            for (var i = 0; i <= 5; i++)
            {
                await responseStream.WriteAsync(new JobCreateResponse() { IsFinished = i == 5, Progress = i * 20, Message = stage[i] });
                await Task.Delay(TimeSpan.FromSeconds(2));
            }
        }
    }
}
namespace RestAndGrpcApp.Server.Services
{
    public interface IEchoService
    {
        string Echo(string request);
    }
}
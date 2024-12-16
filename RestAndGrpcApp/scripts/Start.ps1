dotnet publish ..\RestAndGrpcApp.Server.csproj --output bin\Output

Push-Location ..

docker-compose up -d --build

Pop-Location
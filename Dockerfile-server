# Stage 1: Build Stage
FROM    mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

# restore
COPY    ["RestAndGrpcApp/RestAndGrpcApp.Server.csproj", "RestAndGrpcApp/"]
COPY    ["RestAndGrpcApp.Shared/RestAndGrpcApp.Shared.csproj", "RestAndGrpcApp.Shared/"]
RUN     dotnet restore 'RestAndGrpcApp/RestAndGrpcApp.Server.csproj'

# build
COPY    . .
WORKDIR "/app/RestAndGrpcApp"
RUN     dotnet build 'RestAndGrpcApp.Server.csproj' -c Release -o /app/build

## Stage 2: Publish Stage
FROM build AS publish
RUN dotnet publish 'RestAndGrpcApp.Server.csproj' -c Release -o /app/publish

# Stage 3: Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
ENV ASPNETCORE_HTTP_PORTS=4999
ENV ASPNETCORE_HTTP_PORTS=5000
EXPOSE 4999
EXPOSE 5000
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestAndGrpcApp.Server.dll"]
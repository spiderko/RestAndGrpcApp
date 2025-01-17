cd..
protoc ./RestAndGrpcApp.Shared/Protos/weatherForecast.proto --js_out=import_style=commonjs:. --grpc-web_out=import_style=typescript,mode=grpcwebtext:.
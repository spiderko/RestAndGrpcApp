cd..
protoc -I=. ./RestAndGrpcApp.Shared/Protos/*.proto --grpc-web_out=import_style=typescript,mode=grpcwebtext:.
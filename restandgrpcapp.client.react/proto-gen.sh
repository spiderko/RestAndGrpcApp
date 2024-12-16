cd..
protoc -I=. ./RestAndGrpcApp.Shared/Protos/*.proto --grpc-web_out=import_style=typescript,mode=grpcwebtext:./restandgrpcapp.client.react/src/proto
cd restandgrpcapp.client.react
protoc -I=../RestAndGrpcApp.Shared/Protos ../RestAndGrpcApp.Shared/Protos/*.proto --js_out=import_style=commonjs:./protos --grpc-web_out=import_style=typescript,mode=grpcwebtext:./protos
import './WeatherForecast_Grpc.css';
import type { EchoRequest, EchoResponse } from '../../protos/echo';
import { EchoServiceClient } from '../../protos/echo.client';
import { GrpcWebFetchTransport } from "@protobuf-ts/grpcweb-transport";
import type { GrpcWebOptions } from '@protobuf-ts/grpcweb-transport';
function WeatherForecast_Grpc() {
    const EnvoyURL = "http://localhost:8000";
    const handleClick = async () => {
        console.log('Connecting to GRPC...');
        const TIMEOUT = Date.now() + 2000;
        let options: GrpcWebOptions = {
            baseUrl: EnvoyURL,
            timeout: TIMEOUT,
            format: 'binary',
            meta: {}
        };
        const transport = new GrpcWebFetchTransport(options);
        const client = new EchoServiceClient(transport);
        let request: EchoRequest = {
            message: 'Hello from React!'
        };

        let {response }= client.echo(request, options);
/*        let response: EchoResponse = await call.response;*/
        console.log('Getting response...');
        console.log(response);
    };

  return (
      <div className="weather-forecast-main">
          <h1>Weather</h1>
          <p>This component demonstrates showing data sent by GRPC service.</p>
          <button onClick={handleClick}>Load Weather</button>
    </div>
  )
}



export default WeatherForecast_Grpc;

import './WeatherForecast_Grpc.css';
import type { WeatherForecastRequest, GrpcWeatherForecasts } from '../../protos/weatherForecast';
import { WeatherForecastGrpcServiceClient } from '../../protos/weatherForecast.client';
import { GrpcWebFetchTransport } from "@protobuf-ts/grpcweb-transport";
import type { GrpcWebOptions } from '@protobuf-ts/grpcweb-transport';
import { TableGrpc } from './TableGrpc';
import { useState } from 'react';

function WeatherForecast_Grpc() {
    const [weather, setWeather] = useState<any[]>();
    const [timer, setTimer] = useState('');
    const EnvoyURL = "http://localhost:8000";

    const handleClick = async () => {
        const startTime = Date.now();

        const TIMEOUT = Date.now() + 2000;
        let options: GrpcWebOptions = {
            baseUrl: EnvoyURL,
            timeout: TIMEOUT,
            format: 'binary',
            meta: {}
        };
        const transport = new GrpcWebFetchTransport(options);
        const client = new WeatherForecastGrpcServiceClient(transport);
        let request: WeatherForecastRequest = {
            qty: 1000
        };

        let call = client.getWeatherForecastsByQty(request, options);
        let response: GrpcWeatherForecasts = await call.response;
        setWeather(response.forecasts);

        const endTime = Date.now();
        setTimer(`1000 records returned via GRPC API in ${endTime - startTime} ms`);
    };

  return (
      <div className="weather-forecast-main">
          <h1>Weather</h1>
          <p>This component demonstrates showing data sent by GRPC service.</p>
          <p>{timer}</p>
          <button onClick={handleClick}>Load Weather</button>
          {weather ? TableGrpc(weather) : null}
    </div>
  )
}

export default WeatherForecast_Grpc;

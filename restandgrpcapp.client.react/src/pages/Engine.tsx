import './WeatherForecast_Grpc.css';
import type { JobCreateRequest } from '../../protos/engine';
import { EngineClient } from '../../protos/engine.client';
import { GrpcWebFetchTransport } from "@protobuf-ts/grpcweb-transport";
import type { GrpcWebOptions } from '@protobuf-ts/grpcweb-transport';
import { useState } from 'react';

function Engine() {
    const EnvoyURL = "http://localhost:8000";
    const [textToShow, setTextToShow] = useState("");

    const handleClick = async () => {
        const TIMEOUT = Date.now() + 2000;
        let options: GrpcWebOptions = {
            baseUrl: EnvoyURL,
            timeout: TIMEOUT,
            format: 'binary',
            meta: {}
        };
        const transport = new GrpcWebFetchTransport(options);
        const client = new EngineClient(transport);
        let request: JobCreateRequest = {
            id: 1,
            jobTitle: "Test Job",
        };

        const stream = client.createJob(request, options);

        for await (const response of stream.responses) {
            setTextToShow(`Message: ${response.message}`)
        }
    };

  return (
      <div className="weather-forecast-main">
          <h1>Engine</h1>
          <p>This component demonstrates showing data sent by GRPC server streaming service.</p>
          <button onClick={handleClick}>Start</button>
          <p>{textToShow}</p>
    </div>
  )
}

export default Engine;

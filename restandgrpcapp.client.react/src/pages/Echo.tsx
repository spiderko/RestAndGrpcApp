import { EchoRequest, EchoResponse } from '../../../RestAndGrpcApp.Shared/Protos/echo_pb';
import { EchoServiceClient } from '../../../RestAndGrpcApp.Shared/Protos/EchoServiceClientPb'; }
import './WeatherForecast_Rest.css'
import { useState } from 'react';

function Echo() {
    const [echo, setEcho] = useState('');
    const [timer, setTimer] = useState('');

    const handleClick = () => {
        const startTime = Date.now();
        const echoService = new EchoServiceClient('http://localhost:8080');
        var request = new EchoRequest();
        request.setMessage('Hello World!');
        echoService.echo(request, {}, (err, response: EchoResponse) => {
            if (err) {
                console.log(err);
            } else {
                setEcho(response.getMessage());
            }
        });
        const endTime = Date.now();
        setTimer(`1000 records returned via Rest API in ${endTime - startTime} ms`);
    };

  return (
      <div className="weather-forecast-main">
          <h1>Weather</h1>
          <p>This component demonstrates showing data sent by REST service.</p>
          <p>{timer}</p>
          <button onClick={handleClick}>Load Weather</button>
          {echo ? <p>{echo}</p> : null}
    </div>
  )
}

export default Echo;
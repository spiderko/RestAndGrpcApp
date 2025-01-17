import './WeatherForecast_Grpc.css'
import { WeatherForecastGrpcServiceClient } from '../../protos/WeatherForecastServiceClientPb';
import { WeatherForecastRequest } from '../../protos/weatherForecast_pb';

function WeatherForecast_Grpc() {
    const client = new WeatherForecastGrpcServiceClient('http://localhost:5000');
    const request = new WeatherForecastRequest();
    request.setQty(5);
    client.getWeatherForecasts(request, {}, (err, response) => {
        if (err) {
            console.error(err);
            return;
        }
        console.log(response.toObject());
    });

  return (
      <div className="weather-forecast-main">
          <h1>Weather</h1>
          <p>This component demonstrates showing data sent by GRPC service.</p>
          <button>Load Weather</button>
    </div>
  )
}

export default WeatherForecast_Grpc;

import { WeatherForecastGrpcServiceClient } from '../../../RestAndGrpcApp.Shared/Protos/WeatherForecastServiceClientPb'; 
import { GrpcWeatherForecast, WeatherForecastRequest } from '../../../RestAndGrpcApp.Shared/Protos/weatherForecast_pb';

const weatherClient = async(qty: number) => {
    const envoyUrl = "http://localhost:8080";
    const client = new WeatherForecastGrpcServiceClient(envoyUrl);
    const request = new WeatherForecastRequest();
    request.setQty(qty);

    const response = await client.getWeatherForecasts(request, {});
    console.log(response);
    const div = document.getElementById("response");

    if (div) div.innerText = getTable(response.getForecastsList());
}

const getTable = (forecasts: Array<GrpcWeatherForecast>) : string => {

    let table = '<table>';

    forecasts.forEach(forecast => {
        table += '<tr>';
        table += `<td>${forecast.getDate()?.toDate()}</td>`;
        table += `<td>${forecast.getTemperaturec()}</td>`;
        table += `<td>${forecast.getTemperaturef()}</td>`;
        table += `<td>${forecast.getSummary()?.getValue() }</td>`;
        table += '</tr>';
    });

    table += '</table>';

    return table;
};

function WeatherClientImpl() {
    
    const onClickGreet = () => {
        weatherClient(100);
    };

    return (
        <div>
            <button onClick={onClickGreet}>greet</button>
            <div id="response"></div>
        </div>
    );
}

export default WeatherClientImpl;



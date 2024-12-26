import axios from 'axios';
import './WeatherForecast_Rest.css'
import { useState } from 'react';

function WeatherForecast_Rest() {
    const [weather, setWeather] = useState([]);
    const [timer, setTimer] = useState('');

    const handleClick = () => {
        const startTime = Date.now();
        axios.get('http://localhost:4999/Rest/WeatherForecast/1000')
            .then(data => {
                setWeather(data.data.forecasts);
                const endTime = Date.now();
                setTimer(`1000 records returned via Rest API in ${endTime - startTime} ms`);
            })
            .catch(error => console.log(error));
    };

  return (
      <div className="weather-forecast-main">
          <h1>Weather</h1>
          <p>This component demonstrates showing data sent by REST service.</p>
          <p>{timer}</p>
          <button onClick={handleClick}>Load Weather</button>
          {weather ? CreateTable(weather) : null}
    </div>
  )
}

export default WeatherForecast_Rest;


export function CreateTable(weather: any) {
    return (
        <div>
            <table>
                <thead>
                <tr className="table-header">
                    <th>Date</th>
                    <th>Temp. (C)</th>
                    <th>Temp. (F)</th>
                    <th>Summary</th>
                </tr>
                </thead>
                <tbody>
                    {weather.map((item: any) => <tr>
                        <td>{new Date(item.date).toLocaleDateString('en-UK')}</td>
                        <td>{item.temperatureC}</td>
                        <td>{item.temperatureF}</td>
                        <td>{item.summary}</td>
                    </tr>)}
                </tbody>
            </table>
        </div>
    )
}
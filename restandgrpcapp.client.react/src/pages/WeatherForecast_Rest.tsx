import axios from 'axios';
import './WeatherForecast_Rest.css'
import { useState } from 'react';
import { TableRest } from './TableRest';

function WeatherForecast_Rest() {
    const [weather, setWeather] = useState([]);
    const [timer, setTimer] = useState('');
    const url = "http://localhost:4999/Rest/WeatherForecast/1000";

    const handleClick = () => {
        const startTime = Date.now();
        axios.get(url)
            .then(data => {
                setWeather(data.data.forecasts);
                console.log(weather);

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
          {weather ? TableRest(weather) : null}
    </div>
  )
}

export default WeatherForecast_Rest;

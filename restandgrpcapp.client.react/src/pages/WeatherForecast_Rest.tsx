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
          {weather ? weather.map((item: any) => <p>{item.summary}</p>) : null}
    </div>
  )
}

export default WeatherForecast_Rest;

type WeatherForecast = {
    id: number;
    date: string;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}




export function TableRest(weather: WeatherForecast[]) {

    const ToDate = (date: string) => {
        return new Date(date).toLocaleDateString('en-GB');
    }

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
                    {weather.map((item: WeatherForecast) => <tr key={item.id}>
                        <td>{ToDate(item.date)}</td>
                        <td>{item.temperatureC}</td>
                        <td>{item.temperatureF}</td>
                        <td>{item.summary}</td>
                    </tr>)}
                </tbody>
            </table>
        </div>
    );
}

import type { GrpcWeatherForecast } from '../../protos/weatherForecast';

export function TableGrpc(weather: GrpcWeatherForecast[]) {
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
                    {weather.map((item: GrpcWeatherForecast) => <tr key={item.id}>
                        <td>{item.date?.nanos}</td>
                        <td>{item.temperatureC}</td>
                        <td>{item.temperatureF}</td>
                        <td>{item.summary?.value}</td>
                    </tr>)}
                </tbody>
            </table>
        </div>
    );
}

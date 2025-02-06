import type { GrpcWeatherForecast } from '../../protos/weatherForecast';

export function TableGrpc(weather: GrpcWeatherForecast[]) {

    const ToDate = (seconds: number | undefined) => {
        return new Date(seconds ? seconds * 1000 : 0).toLocaleDateString('en-GB');
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
                    {weather.map((item: GrpcWeatherForecast) => <tr key={item.id}>
                        <td>{ToDate(item.date?.seconds)}</td>
                        <td>{item.temperatureC}</td>
                        <td>{item.temperatureF}</td>
                        <td>{item.summary?.value}</td>
                    </tr>)}
                </tbody>
            </table>
        </div>
    );
}

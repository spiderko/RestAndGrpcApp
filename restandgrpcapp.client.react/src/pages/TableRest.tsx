export function TableRest(weather: any[]) {
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
                    {weather.map((item: any) => <tr key={item.id}>
                        <td>{item.date}</td>
                        <td>{item.temperatureC}</td>
                        <td>{item.temperatureF}</td>
                        <td>{item.summary}</td>
                    </tr>)}
                </tbody>
            </table>
        </div>
    );
}

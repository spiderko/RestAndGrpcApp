interface WeatherTableProps {
    date: Date;
    summary: string;
    temperatureC: number;
    temperatureF: number;
}


export const WeatherTable = ({
    date,
    summary,
    temperatureC,
    temperatureF
}: WeatherTableProps) => {

  return (
      <div>
          <p>{date.toUTCString()}</p>
          <p>{summary}</p>
          <p>{temperatureC}</p>
          <p>{temperatureF}</p>
      </div>
  )
}

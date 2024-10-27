# Grpc and Rest Api service

This simple app demonstrates how to create a gRPC and REST API service in a single ASP.NET Core application. The gRPC service is implemented using the `WeatherForecast` service and the REST API service is implemented using the `WeatherForecastController`.

## Build and run the sample

After the application runs, navigate to http://localhost:4999/swagger in your web browser to access the Swagger UI. Expand "WeatherForecast" accordion and click on "Try it out" -> "Execute" and it should return something similar like this below:

```json
{
  "forecasts": [
    {
      "date": {
        "seconds": 1719418653,
        "nanos": 113660700
      },
      "temperatureC": 19,
      "temperatureF": 0,
      "summary": "Chilly"
    },
    {
      "date": {
        "seconds": 1719505053,
        "nanos": 114087500
      },
      "temperatureC": -5,
      "temperatureF": 0,
      "summary": "Mild"
    },
    {
      "date": {
        "seconds": 1719591453,
        "nanos": 114088500
      },
      "temperatureC": 22,
      "temperatureF": 0,
      "summary": "Balmy"
    },
    {
      "date": {
        "seconds": 1719677853,
        "nanos": 114088600
      },
      "temperatureC": -10,
      "temperatureF": 0,
      "summary": "Hot"
    }
  ]
}
```

You can also test your gRPC service by expanding "/v1/WeatherForecast" accordion and click on "Try it out" -> "Execute". It should retrun similiar result as above.
Call in this case is made using HTTP/1.1 protocol.

For the gRPC piece which uses HTTP/2.0 protocol, you can use Postman (https://www.postman.com/). Create new gRPC request in Postman and import the `weatherForecast.proto` file to the client and enter the server address as `grpc://localhost:5000`.
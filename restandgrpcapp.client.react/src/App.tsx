import WeatherForecast_Grpc from './pages/WeatherForecast_Grpc';
import Root from "./routes/root";
import WeatherForecast_Rest from './pages/WeatherForecast_Rest';
import { createBrowserRouter, RouterProvider } from 'react-router-dom';
import ErrorPage from './pages/ErrorPage';
import Home from './pages/Home';
import Engine from './pages/Engine';

function App() {
    const router = createBrowserRouter([{
        path: '/',
        element: <Root />,
        errorElement: <ErrorPage />,
        children: [
            {
                path: '',
                element: <Home />,
            },
            {
              path: 'weatherforecast-rest',
              element: <WeatherForecast_Rest />,
            },
            {
              path: 'weatherforecast-grpc',
              element: <WeatherForecast_Grpc />,
            },
            {
                path: 'engine',
                element: <Engine />,
            }
        ]
    }]);

  return (
      <>
        <RouterProvider router={router} />
    </>
  )
}

export default App

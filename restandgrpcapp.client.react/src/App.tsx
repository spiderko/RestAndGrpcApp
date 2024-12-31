import WeatherForecast_Grpc from './pages/WeatherForecast_Grpc';
import Root from "./routes/root";
import WeatherForecast_Rest from './pages/WeatherForecast_Rest';
import { createBrowserRouter, RouterProvider } from 'react-router-dom';
import ErrorPage from './pages/ErrorPage';
import Home from './pages/Home';
import Echo from './pages/Echo';

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
                path: 'echo-grpc',
                element: <Echo />,
            },
            {
              path: 'weatherforecast-rest',
              element: <WeatherForecast_Rest />,
            },
            {
              path: 'weatherforecast-grpc',
              element: <WeatherForecast_Grpc />,
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

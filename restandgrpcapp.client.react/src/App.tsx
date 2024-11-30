import Sidebar from './components/Siderbar'
import WeatherForecast_Grpc from './pages/WeatherForecast_Grpc'
import Home from './pages/Home'
import WeatherForecast_Rest from './pages/WeatherForecast_Rest'
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';

function App() {

  return (
    <>
      <Router>
        <Sidebar />
          <Routes>
            <Route path="/home" element={<Home/>} />
              <Route path="/WeatherForecastGrpc" element={<WeatherForecast_Grpc/>} />
              <Route path="/WeatherForecastRest" element={<WeatherForecast_Rest />} />
            </Routes>
      </Router>
    </>
  )
}

export default App

import { Link } from 'react-router'
import './Sidebar.css'
import { FaBars } from "react-icons/fa";
import { GoHomeFill } from "react-icons/go";

function Sidebar() {

  return (
      <div className="main">
        <div className="sidebar">
          <nav className='nav-menu active'>
            <ul className="nav-menu-items">
            <li className="nav-text">
                <Link to="/">
                  <GoHomeFill /> <span>Home</span>
                </Link>
            </li>
              <li className="nav-text">
                <Link to="/WeatherForecast-Grpc">
                  <FaBars /> <span>Weather GRPC</span>
                </Link>
              </li>
              <li className="nav-text">
                <Link to="/WeatherForecast-Rest">
                  <FaBars /><span> Weather REST</span>
                </Link>
              </li>
            </ul>
              </nav>
          </div>
    </div>
  )
}

export default Sidebar;

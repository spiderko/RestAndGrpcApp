import { Link } from 'react-router'
import './Sidebar.css'
import { FaBars } from "react-icons/fa";
import { AiFillHome } from 'react-icons/ai';
import { BsFillPlusSquareFill } from "react-icons/bs";

function Sidebar() {

  return (
      <>
        <div className="sidebar">
          <nav className='nav-menu active'>
            <ul className="nav-menu-items">
                      <li className="nav-text">
                <Link to="/">
                  <AiFillHome/><span>Home</span>
                </Link>
            </li>
            <li className="nav-text">
                <Link to="/Counter">
                  <BsFillPlusSquareFill /><span>Counter</span>
                </Link>
            </li>
              <li className="nav-text">
                <Link to="/WeatherForecastGrpc">
                  <FaBars /> <span>Weather Forecast Grpc</span>
                </Link>
              </li>
              <li className="nav-text">
                <Link to="/WeatherForecastRest">
                  <FaBars /><span> Weather Forecast Rest</span>
                </Link>
              </li>
            </ul>
              </nav>
          </div>
    </>
  )
}

export default Sidebar;

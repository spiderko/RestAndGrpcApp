import Sidebar from "../components/Siderbar";
import { Outlet } from "react-router-dom";
import './Root.css'

export default function Root() {
    return (
        <div className="main">
          <Sidebar />
          <div id="detail">
            <Outlet />
          </div>
        </div>
    );
}
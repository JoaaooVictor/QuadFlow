import {Routes, Route } from "react-router-dom";
import AuthPage from "../features/auth/page/AuthPage";
import { HomePage } from "../pages/HomePage";
import { DashboardPage } from "../features/dashboard/page/Dashboard";

const AppRoutes = () =>{
    return(
        <Routes>
            <Route path="/dashboard" element={<DashboardPage/>}/>
            <Route path="/auth" element={<AuthPage/>}/>
            <Route path="/" element={<HomePage/>}/>
        </Routes>
    )
}

export default AppRoutes;
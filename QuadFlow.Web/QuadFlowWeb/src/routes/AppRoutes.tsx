import {Routes, Route } from "react-router-dom";
import AuthPage from "../features/auth/pages/AuthPage";
import { HomePage } from "../pages/HomePage";

const AppRoutes = () =>{
    return(
        <Routes>
            <Route path="/auth" element={<AuthPage/>}/>
            <Route path="/" element={<HomePage/>}/>
        </Routes>
    )
}

export default AppRoutes;
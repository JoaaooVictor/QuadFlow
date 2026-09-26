import { Routes, Route, BrowserRouter } from "react-router-dom";
import { AuthPage }  from "../features/auth/page/AuthPage";
import { HomePage } from "../pages/HomePage";
import { DashboardPage } from "../features/dashboard/page/Dashboard";
import { ComandasPage } from "../features/comandas/page/ComandasPage";
import { DashboardLayout } from "../layouts/DashboardLayout";

export const AppRoutes = () => {
    return (
        <BrowserRouter>
            <Routes>
                <Route path="/" element={<HomePage />} />
                <Route path="/auth" element={<AuthPage />} />

                <Route element={<DashboardLayout />}>
                    <Route path="/dashboard" element={<DashboardPage />} />
                    <Route path="/comandas" element={<ComandasPage />} />
                </Route>
            </Routes>
        </BrowserRouter>
    )
}

export default AppRoutes;
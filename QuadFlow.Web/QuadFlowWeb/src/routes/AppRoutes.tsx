import { Routes, Route, BrowserRouter } from "react-router-dom";
import { AuthPage }  from "../features/auth/page/AuthPage";
import { HomePage } from "../pages/HomePage";
import { DashboardPage } from "../features/dashboard/page/DashboardPage";
import { ComandasPage } from "../features/comandas/page/ComandasPage";
import { DashboardLayout } from "../layouts/DashboardLayout";
import { ProdutosPage } from "../features/produtos/page/ProdutosPage";
import { AgendaPage } from "../features/agenda/page/AgendaPage";
import { PlanosPage } from "../features/planos/page/PlanosPage";
import { ConfiguracaoPage } from "../features/configuracao/page/ConfiguracaoPage";

export const AppRoutes = () => {
    return (
        <BrowserRouter>
            <Routes>
                <Route path="/" element={<HomePage />} />
                <Route path="/auth" element={<AuthPage />} />

                <Route element={<DashboardLayout />}>
                    <Route path="/dashboard" element={<DashboardPage />} />
                    <Route path="/comandas" element={<ComandasPage />} />
                    <Route path="/produtos" element={< ProdutosPage />} />
                    <Route path="/agenda" element={< AgendaPage/>} />
                    <Route path="/planos" element={< PlanosPage/>} />
                    <Route path="/configuracao" element={< ConfiguracaoPage/>} />
                </Route>
            </Routes>
        </BrowserRouter>
    )
}

export default AppRoutes;
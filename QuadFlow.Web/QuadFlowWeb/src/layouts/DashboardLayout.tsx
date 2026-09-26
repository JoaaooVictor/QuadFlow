import { Outlet } from "react-router-dom"
import { Header } from "../components/header/Header"
import { SideBar } from "../components/sidebar/Sidebar"

export const DashboardLayout = () => {
    return (
        <div className="flex min-h-screen">
            <SideBar />
            <div className="flex flex-1 flex-col">
                <Header />
                <main className="flex-1">
                    <Outlet />
                </main>
            </div>
        </div>
    )
}
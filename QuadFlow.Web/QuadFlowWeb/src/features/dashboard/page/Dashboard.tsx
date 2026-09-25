import { SideBar } from "../../../components/sidebar/Sidebar"

export const DashboardPage = () =>{
    return (
        <div className="flex min-h-screen">
            <SideBar/>
            <div className="flex-1">
                <header className="h-16 bg-blue-100">
                </header>
                <main>
                </main>
            </div>
        </div>
    )
}
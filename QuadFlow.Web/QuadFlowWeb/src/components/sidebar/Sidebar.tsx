import { Button } from "../button/Button";
import { SideBarItem } from "./SidebarItem"
import { ClipboardList, CalendarPlus, Hamburger, House, CircleDollarSign, Settings, LogOut } from "lucide-react";
import { useNavigate } from "react-router-dom";

export const SideBar = () => {
    const navigate = useNavigate();

    function handleLogout() {
        localStorage.removeItem('token');
        navigate('/auth');
    }

    return (
        <aside className="flex w-60 flex-col bg-[#3E5C76]">
            <header className="w-full py-4 text-center text-3xl">
                <h1 className="text-white">Quad<strong className="text-[#F0EBD8]">Flow</strong></h1>
            </header>
            <nav>
                <ul className="flex flex-col">
                    <li>
                        <SideBarItem
                            title="Dashboard"
                            icon={<House />}
                            to='/dashboard'
                        />
                    </li>
                    <li>
                        <SideBarItem
                            title="Comandas"
                            icon={<ClipboardList />}
                            to='/comandas'
                        />
                    </li>
                    <li>
                        <SideBarItem
                            title="Agenda"
                            icon={<CalendarPlus />}
                            to='/agenda'
                        />
                    </li>
                    <li>
                        <SideBarItem
                            title="Produtos"
                            icon={<Hamburger />}
                            to='/produtos'
                        />
                    </li>
                    <li>
                        <SideBarItem
                            title="Planos"
                            icon={<CircleDollarSign />}
                            to='/planos'
                        />
                    </li>
                    <li>
                        <SideBarItem
                            title="Configurações"
                            icon={<Settings />}
                            to='/configuracao'
                        />
                    </li>
                </ul>
            </nav>
            <div className="mt-auto">
                <Button
                    title="Sair"
                    titleColor="text-white"
                    icon={<LogOut size={20} />}
                    onClick={handleLogout}
                />
            </div>
        </aside>
    )
}
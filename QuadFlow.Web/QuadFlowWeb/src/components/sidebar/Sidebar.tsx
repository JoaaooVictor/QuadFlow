import { SideBarItem } from "./SidebarItem"
import { ClipboardList, CalendarPlus, Hamburger, House, CircleDollarSign, Settings} from "lucide-react";

export const SideBar = () => {
    return (
        <aside className="flex w-60 flex-col bg-blue-900">
            <header className="w-full py-4 border text-center text-xl">
                <h1 className="text-white">Quad<strong className="text-blue-800">Flow</strong></h1>
            </header>

            <nav>
                <ul className="flex flex-col">
                    <li><SideBarItem title="Dashboard" icon={<House />} /></li>
                    <li><SideBarItem title="Comandas" icon={<ClipboardList />} /></li>
                    <li><SideBarItem title="Agenda" icon={<CalendarPlus />} /></li>
                    <li><SideBarItem title="Produtos" icon={<Hamburger/>} /></li>
                    <li><SideBarItem title="Planos" icon={<CircleDollarSign/>} /></li>
                    <li><SideBarItem title="Configurações" icon={<Settings/>} /></li>

                </ul>
            </nav>
        </aside>
    )
}
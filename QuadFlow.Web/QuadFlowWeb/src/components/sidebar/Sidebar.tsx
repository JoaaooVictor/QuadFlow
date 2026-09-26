import { SideBarItem } from "./SidebarItem"
import { ClipboardList, CalendarPlus, Hamburger, House, CircleDollarSign, Settings} from "lucide-react";

export const SideBar = () => {
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
                        />
                    </li>
                    <li>
                        <SideBarItem 
                            title="Comandas" 
                            icon={<ClipboardList />} 
                        />
                    </li>
                    <li>
                        <SideBarItem 
                            title="Agenda" 
                            icon={<CalendarPlus />} 
                        />
                    </li>
                    <li>
                        <SideBarItem 
                            title="Produtos" 
                            icon={<Hamburger/>} 
                        />
                        </li>
                    <li>
                        <SideBarItem 
                            title="Planos" 
                            icon={<CircleDollarSign/>} 
                        />
                    </li>
                    <li>
                        <SideBarItem 
                            title="Configurações" 
                            icon={<Settings/>} 
                        />
                    </li>
                </ul>
            </nav>
            <div>
                <h1 className="text-center">Logout</h1>
            </div>
        </aside>
    )
}
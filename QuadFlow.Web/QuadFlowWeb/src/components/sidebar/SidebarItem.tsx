import { Link } from "react-router-dom";
import type { SidebarItemProps } from "./SidebarItemProps";

export const SideBarItem = ({ title, icon, to }: SidebarItemProps) => {
    return (
        <Link to={to} className="flex w-full items-center gap-3 rounded-md px-6 py-2 hover:bg-[#F0EBD8]"        >
            <p className="text-white">{icon}</p>
            <span className="text-white">{title}</span>
        </Link>
    );
};
import type { SidebarItemProps } from "./SidebarItemProps"

export const SideBarItem = ({ title, icon }: SidebarItemProps) => {
    return (
        <button className="flex w-full items-center gap-3 rounded-md px-6 py-2 hover:bg-blue-100">
            {icon}
            <span className="text-white">{title}</span>
        </button>
    );
};
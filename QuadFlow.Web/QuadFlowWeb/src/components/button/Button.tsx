import type { ButtonProps } from "./ButtonProps"

export const Button = ({ title, titleColor, bgColor, icon, onClick}: ButtonProps) =>{
    return(
        <button onClick={onClick} className={`${bgColor} flex items-center gap-3 rounded-md px-6 py-2 w-full hover:bg-[#F0EBD8]`}>
            <p className={titleColor}>{icon}</p>
            <p className={titleColor}>{title}</p>
        </button>
    )
}
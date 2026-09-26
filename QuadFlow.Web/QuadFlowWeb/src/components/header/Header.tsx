import { UserCircle2 } from "lucide-react"

export const Header = () => {
    return (
        <header className="w-full border-b border-gray-200 bg-white">
            <div className="flex justify-end">
                <button className="px-7 py-5">
                    {<UserCircle2 size={30}/>}
                </button>
            </div> 
        </header>
    )
}
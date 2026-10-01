import { NavbarItem } from "./NavbarItem"
const Navbar = () => {
    return (
        <nav className="flex gap-4 justify-end bg-gray-600 w-full p-4">
            <NavbarItem title="Entrar" to={'/auth'} />
            <NavbarItem title="Sobre" to={'/sobre'} />
        </nav>
    )
}

export default Navbar
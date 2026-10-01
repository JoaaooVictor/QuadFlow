import { NavbarItem } from "./NavbarItem"
const Navbar = () => {
    return (
        <nav className="flex gap-4 justify-end bg-gray-600 w-full p-4">
            <NavbarItem title="Início" to={'#inicio'} />
            <NavbarItem title="Sobre" to={'#sobre'} />
            <NavbarItem title="Recursos" to={'#recurso'} />
            <NavbarItem title="Contato" to={'#sobre'} />
        </nav>
    )
}

export default Navbar
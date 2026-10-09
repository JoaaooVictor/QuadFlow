import { NavbarItem } from "./NavbarItem"
const Navbar = () => {
    return (
        <nav className="fixed left-0 top-0 z-50 w-full shadow-md flex gap-12 justify-center bg-[#3E5C76] w-full p-4">
            <NavbarItem title="Início" to={'#hero'} />
            <NavbarItem title="Sobre" to={'#sobre'} />
            <NavbarItem title="Recursos" to={'#recursos'} />
            <NavbarItem title="Contato" to={'#sobre'} />
        </nav>
    )
}

export default Navbar
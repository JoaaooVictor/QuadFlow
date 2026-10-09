import type { NavbarItemProps } from './NavbarItemProps'

export const NavbarItem = ({ title, to }: NavbarItemProps) => {
    return (
        <a href={to}>
            <p className='text-white  hover:text-black'> {title}</p>
        </a>
    )
}
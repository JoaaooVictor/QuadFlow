import type { NavbarItemProps } from './NavbarItemProps'

export const NavbarItem = ({title, to}: NavbarItemProps) => {
    return (
        <a className='text-white' href={to}>
            {title}
        </a>
  )
}
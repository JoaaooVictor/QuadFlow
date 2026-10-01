import { Link } from 'react-router-dom'
import type { NavbarItemProps } from './NavbarItemProps'

export const NavbarItem = ({title, to}: NavbarItemProps) => {
    return (
        <a href={to}>
            {title}
        </a>
  )
}
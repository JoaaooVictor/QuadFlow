import { Link } from 'react-router-dom'
import type { NavbarItemProps } from './NavbarItemProps'

export const NavbarItem = ({title, to}: NavbarItemProps) => {
    return (
        <ul>
            <li className='px-6 py-1 rounded border border-gray-200 hover:bg-white'>
                <Link to={to}>{title}</Link>    
            </li>
        </ul>
  )
}
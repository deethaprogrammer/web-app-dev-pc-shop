// import Button from '../Button'
import Searchbar from '../Searchbar';
import NavbarButton from './NavbarButton';
import { Link } from "react-router-dom";

import logo from '../../assets/images/logo.png';
import DropdownMenu from './DropdownMenu';



export default function Navbar(){


    return(
        <>
            <nav className='flex items-center justify-between px-4 py-2 bg-olive-600'>
                <div className='flex items-center gap-3'>
                    <Link to="/" className="button">
                        <img className='h-10 rounded-full ml-2' src={logo} alt="logos" />
                    </Link>
                    <NavbarButton title='Create' page='/create'/>
                    <NavbarButton title='Pre builts' page='/prebuilts'/>
                    <NavbarButton title='Community' page='/community'/>
                </div>

                <div className='flex items-center gap-3'>
                    <Searchbar />
                    <DropdownMenu />
                </div>
            </nav>
        </>
    )
}
import {useState} from 'react';
import { BiMenu, BiX } from "react-icons/bi";
import { IconContext } from "react-icons";
import 
{
    Nav,
    NavbarContainer,
    NavLogo,
    NavIcon,
    MenuIcon,
    Menu,
    MenuItem,
    MenuLink
} from './Navbar.styles';

export const Navbar = () => {
    const [click, setClick] = useState(false);
    const handleClick = () => setClick(!click);
    const closeMenu = () => setClick(false);
    
    return (
        <div>
            <IconContext.Provider value={{ color: '#fff'}}>
                <Nav>
                    <NavbarContainer>
                        <NavLogo to="/">
                            <NavIcon/>
                            <h4>Thai Amadeus</h4>
                        </NavLogo>
                        <MenuIcon onClick={handleClick}>
                            {click ? <BiX/> : <BiMenu/>}
                        </MenuIcon>

                        <Menu onClick={handleClick} click={click}>
                            <MenuItem>
                                <MenuLink onClick={closeMenu} to="/">Home</MenuLink>
                            </MenuItem>
                            <MenuItem>
                                <MenuLink onClick={closeMenu} to="/newandevent">News</MenuLink>
                            </MenuItem>
                            <MenuItem>
                                <MenuLink onClick={closeMenu} to="/recipe">Helpdesk</MenuLink>
                            </MenuItem>
                            <MenuItem>
                                <MenuLink onClick={closeMenu} to="/recipe">Training</MenuLink>
                            </MenuItem>
                            <MenuItem>
                                <MenuLink onClick={closeMenu} to="/recipe">Technical Support</MenuLink>
                            </MenuItem>
                            <MenuItem>
                                <MenuLink onClick={closeMenu} to="/recipe">Careers</MenuLink>
                            </MenuItem>
                            <MenuItem>
                                <MenuLink onClick={closeMenu} to="/contactus">Contact Us</MenuLink>
                            </MenuItem>
                        </Menu>

                    </NavbarContainer>

                </Nav>
            </IconContext.Provider>
        </div>
    )
}
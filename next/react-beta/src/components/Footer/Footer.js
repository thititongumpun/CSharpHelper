import {
    FooterSection,
    FooterContainer,
    FooterLinkContainer,
    FooterLinksWrapper,
    FooterLinks,
    FooterLinkTitle,
    FooterLink,
    FooterCopyRight
} from './Footer.styles';
export const Footer = () => {
    return (
        <div>
            <FooterSection>
                <FooterContainer>
                    <FooterLinkContainer>
                        <FooterLinksWrapper>
                            <FooterLinks>
                                <FooterLinkTitle>Our industries</FooterLinkTitle>
                                <FooterLink to='/'>Travel agencies</FooterLink>
                                <FooterLink to='/'>Corporations</FooterLink>
                                <FooterLink to='/'>Car rental</FooterLink>
                                <FooterLink to='/'>Hotels</FooterLink>
                            </FooterLinks>
                            <FooterLinks>
                                <FooterLinkTitle>Services</FooterLinkTitle>
                                <FooterLink to='/about'>How it works</FooterLink>
                                <FooterLink to='/'>Meal prep kit</FooterLink>
                                <FooterLink to='/'>Gift cards</FooterLink>
                                <FooterLink to='/'>Orders</FooterLink>
                            </FooterLinks>

                        </FooterLinksWrapper>
                        <FooterLinksWrapper>
                            <FooterLinks>
                                <FooterLinkTitle>Resources</FooterLinkTitle>
                                <FooterLink to='/'>Kitchenware</FooterLink>
                                <FooterLink to='/'>Recipes</FooterLink>
                                <FooterLink to='/'>FAQ &amp; Support</FooterLink>
                                <FooterLink to='/'>Affiliate Program</FooterLink>
                            </FooterLinks>
                            <FooterLinks>
                                <FooterLinkTitle>Contact</FooterLinkTitle>
                                <FooterLink to='/'>Instagram</FooterLink>
                                <FooterLink to='/'>Facebook</FooterLink>
                                <FooterLink to='/'>Youtube</FooterLink>
                                <FooterLink to='/'>Linkedin</FooterLink>
                            </FooterLinks>
                        </FooterLinksWrapper>
                    </FooterLinkContainer>
                    <FooterCopyRight to='https://github.com/muchirijane'> &copy; Copyright 2021, Designed and coded with 💛 by </FooterCopyRight>
                </FooterContainer>
            </FooterSection>
            
        </div>
    );
}
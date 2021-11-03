import { Textfit } from "react-textfit";
import {
  HeroContainer,
  HeroContent,
  HeroContentText,
  HeroTitle,
  HeroSubTitle,
  HeroText,
} from "./AboutUs.styles";

export const AboutUs = ({ title, body }) => {
  return (
    <div>
      <HeroContainer>
        <HeroContent>
          <HeroContentText>
            <HeroTitle> AboutUs </HeroTitle>
            <HeroSubTitle>{title}</HeroSubTitle>
            <HeroText>
              <Textfit mode="multi">{body}</Textfit>
            </HeroText>
          </HeroContentText>
        </HeroContent>
      </HeroContainer>
    </div>
  );
};

import { AboutUs } from "../../components/ContactUs/AboutUs";
import { aboutUs } from "../data/about";

export const About = () => {
  return (
    <AboutUs title={aboutUs.title} body={aboutUs.body} />
  );
}
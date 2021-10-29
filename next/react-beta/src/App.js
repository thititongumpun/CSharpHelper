import './App.css';
import GlobalStyles from './components/GlobalStyles';
import { Navbar } from './components/Navbar/Navbar';
import {BrowserRouter as Router,Switch,Route} from "react-router-dom";
import {ImageCarousel} from './components/Carousel/ImageCarousel';
import {News} from './components/News/News'
import {Footer} from './components/Footer/Footer';

function App() {
  return (
    <Router>
      <GlobalStyles/>
      <Navbar />
      <ImageCarousel />
      <News />
      <Footer />
    </Router>
  );
}

export default App;

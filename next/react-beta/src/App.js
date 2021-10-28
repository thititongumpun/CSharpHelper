import './App.css';
import GlobalStyles from './components/GlobalStyles';
import { Navbar } from './components/Navbar/Navbar';
import {BrowserRouter as Router,Switch,Route} from "react-router-dom";
import {ImageCarousel} from './components/Carousel/ImageCarousel';

function App() {
  return (
    <Router>
      <GlobalStyles/>
      <Navbar />
      <ImageCarousel />
    </Router>
  );
}

export default App;

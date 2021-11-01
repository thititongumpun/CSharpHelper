import './App.css';
import GlobalStyles from './components/GlobalStyles';
import { Navbar } from './components/Navbar/Navbar';
import {BrowserRouter as Router,Switch,Route} from "react-router-dom";
import {Footer} from './components/Footer/Footer';
import {Home} from './pages/Home/Home';
import {NewAndEvents} from './pages/News/NewAndEvents';
import {About} from './pages/ContactUs/About';

function App() {
  return (
    <Router>
      <GlobalStyles/>
      <Navbar />
        <Switch>
          <Route exact path="/" component={Home} />
          <Route exact path="/newandevent" component={NewAndEvents} />
          <Route exact path="/contactus" component={About} />
        </Switch>
      <Footer />
    </Router>
  );
}

export default App;

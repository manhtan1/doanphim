import logo from './logo.svg';
import './App.css';

import Navbar from './Components/Navbar';
import Body from './Components/Body';
import Container from './Components/Container';
import Footer from './Components/Footer';

function App() {
  return (
    <div className="App">
        <Navbar/>
        <Body/>
        <Container/>
        <Footer/>
    </div>
  );
}

export default App;

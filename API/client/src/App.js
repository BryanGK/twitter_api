import React from 'react';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import Navbar from './components/Navbar'
import Home from './pages/Home';
import Search from './pages/Search';
import Random from './pages/Random';
import Footer from './components/Footer';
import './styles/App.css';

function App() {
    return (
        <Router>
            <Navbar />
            <Switch>
                <Route path="/search">
                    <Search />
                </Route>
                <Route path="/random">
                    <Random />
                </Route>
                <Route path="/">
                    <Home />
                </Route>
            </Switch>
            <Footer />
        </Router>);
}

export default App
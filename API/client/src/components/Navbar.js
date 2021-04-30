import React from 'react';
import { ReactComponent as TwitterLogo } from '../images/Twitter_Logo.svg';
import { Link } from 'react-router-dom';

function Navbar() {
    return (
        <div className="container-fluid">
            <nav className="navbar fixed-top navbar-expand-md navbar-light bg-light shadow mb-5 bg-body rounded">
                <span className="navbar-brand" href="/">
                    Happy-Tweet
                            <TwitterLogo className="twitter-icon" />
                </span>
                <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span className="navbar-toggler-icon"></span>
                </button>
                <div className="collapse navbar-collapse" id="navbarNav">
                    <ul className="navbar-nav nav-links">
                        <li className="nav-item">
                            <Link className="nav-link" to="/">Home</Link>
                        </li>
                        <li className="nav-item">
                            <Link className="nav-link" to="/search">Search</Link>
                        </li>
                        <li className="nav-item">
                            <Link className="nav-link" to="/random">Random</Link>
                        </li>
                    </ul>
                </div>
            </nav>
        </div>
    )
}

export default Navbar;
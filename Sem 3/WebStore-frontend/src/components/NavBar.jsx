import React, { useEffect, useState } from 'react';
import './NavBar.css'
import TokenManager from '../api/TokenManager';
import { Link } from 'react-router-dom';

function Navbar() {
  const [claims, setClaims] = useState(TokenManager.getClaims());

  const handleLogout = () => {
    TokenManager.clear();
    setClaims(null);
    setCustomerDetails(null);
  }

  useEffect(() => {
    setClaims(TokenManager.getClaims());
  }, []); // depending if user is logged in different navbar components load like profile page

  return (
    <div className="navbar">

      <div className="subnav">
        <button className="subnavbtn">
          <Link to="/">Home</Link>
        </button>
      </div>

      <div className="subnav">
        <button className="subnavbtn">
          <Link to="/products">Products</Link> <i className="fa fa-caret-down"></i>
        </button>
        <div className="subnav-content">
          <a href="#company">Furniture</a>
          <a href="#team">Tools</a>
        </div>
      </div>

      <div className="subnav login-btn">
        {claims ? (
          <div className="subnav">
            <button className="subnavbtn">
              <Link to="/products">Personal Menu</Link> <i className="fa fa-caret-down"></i>
            </button>
            <div className="subnav-content">
              <Link to="/profile">Profile</Link>
              <Link to="/" onClick={handleLogout}>Logout</Link>
            </div>
          </div>
        ) : (
          <button className="subnavbtn">
            <Link to="/login">Login</Link>
          </button>
        )}
      </div>
    </div>
  );
}

export default Navbar;

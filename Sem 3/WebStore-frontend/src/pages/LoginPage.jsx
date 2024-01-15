import React, { useState, useEffect } from 'react';
import LoginForm from '../components/LoginForm';
import TokenManager from '../api/TokenManager';
import AuthAPI from '../api/AuthAPI';
import { useNavigate } from 'react-router-dom';

function LoginPage() {
  const navigate = useNavigate();
  const [claims, setClaims] = useState(TokenManager.getClaims());

  useEffect(() => {
    setClaims(TokenManager.getClaims());
  }, [claims]);

  const handleLogin = (username, password) => {
    AuthAPI.login(username, password)
      .catch(() => alert("Login failed!"))
      .then(claims => {
        setClaims(claims);
        navigate('/');
        alert("Successfuly logged in!");
      })
      .catch(error => console.error(error));
  }

  return (
    <div>
      <h1>My App</h1>
        <LoginForm onLogin={handleLogin} />
    </div>
  );
}

export default LoginPage;

import React, { useState, useEffect } from 'react';
import TokenManager from '../api/TokenManager';
import CustomerAPI from '../api/CustomerAPI';
import CustomerDetails from '../components/CustomerDetails';

function ProfilePage() {
  const [claims, setClaims] = useState(TokenManager.getClaims());
  const [customerDetails, setCustomerDetails] = useState(null);

  const getCustomerDetails = () => {
    const claims = TokenManager.getClaims();
    if (claims?.roles?.includes('CUSTOMER') && claims?.customerId) {
      CustomerAPI.getCustomer(claims.customerId)
        .then(customer => setCustomerDetails(customer))
        .catch(error => console.error(error));
    }
  };

  useEffect(() => {
    getCustomerDetails();
  }, [claims]);

  return (
    <div>
      {claims ? (
        <div>
          <p>Welcome, {claims.sub}</p>
          {customerDetails && <CustomerDetails customerDetails={customerDetails} />}
          <br />
        </div>
      ) : (
        <h1>User not authenticated. Please log in.</h1>
      )}
    </div>
  );
}

export default ProfilePage;
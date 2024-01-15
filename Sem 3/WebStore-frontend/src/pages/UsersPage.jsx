import React, { useState, useEffect } from 'react';
import UserList from '../components/UserList';
import UserAPI from '../api/UserAPI';

function UsersPage() {
  const [users, setUsers] = useState([]);

  useEffect(() => {
    UserAPI.getUsers()
    .then(result => {setUsers(result.data.users)})
  }, []);
  return (
    <div className="container">
            <div className="inner">
                <UserList users={users} />
            </div>
        </div>
  );
  
}

export default UsersPage;

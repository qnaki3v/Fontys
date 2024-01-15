import React from "react"
import User from './User';

function UserList(props) {

  return (
    <ul>
      {props.users.map(user => (
        <User key={user.id} user={user} />
      ))}
    </ul>
  )
}

export default UserList;
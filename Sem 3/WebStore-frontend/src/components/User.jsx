import React from "react"
import styles from "./User.css"
function User(props) {

    return (
        <li className={styles.user}>
            {props.user.firstName} {props.user.lastName}, Age: {props.user.age}
        </li>
    )
}

export default User;
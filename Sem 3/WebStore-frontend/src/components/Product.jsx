import React from "react"
import styles from "./Product.css"
function Product(props) {

    return (
        <li className={styles.product}>
            {props.product.name} {props.product.category}, Price: {props.product.price}
        </li>
    )
}

export default Product;
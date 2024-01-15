import React from "react"
import ProductCard from "./ProductCard";

function ProductList({products}) {
  console.log("Products:", products);

  return (
    <ul>
      {products.map(product => (
        <ProductCard key={product.id} productId={product.id} title={product.name} description={product.category} imageSrc={product.imageUrl}/>
      ))}
    </ul>
  )
}

export default ProductList;
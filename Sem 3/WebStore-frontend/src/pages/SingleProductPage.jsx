import React, { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';
import ProductAPI from '../api/ProductAPI';

const ProductPage = () => {
  const { productId } = useParams();
  console.log('Product ID:', productId);
  const [product, setProduct] = useState(null);

  useEffect(() => {
    ProductAPI.getProduct(productId)
      .then(result => {
        console.log('API Response:', result.data); // Log the entire response data
        setProduct(result.data);
      })
      .catch(error => {
        console.error('Error fetching product details:', error);
      });
  }, [productId]);

  return (
    <div>
      {product ? (
        <>
          <h1>{product.name}</h1>
          <img src={product.imageUrl} alt={product.name} style={{ maxWidth: '100%', maxHeight: '400px' }} />
          <p>Price: ${product.price}</p>
          {/* ... other properties */}
        </>
      ) : (
        <p>Loading...</p>
      )}
    </div>
  );
};

export default ProductPage;

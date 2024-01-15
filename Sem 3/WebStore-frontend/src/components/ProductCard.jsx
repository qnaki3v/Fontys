import React from 'react';
import { Card } from 'antd';
import { Link } from 'react-router-dom';
const { Meta } = Card;

const ProductCard = ({ productId, title, description, imageSrc }) => (
  
  <Link to={`/products/${productId}`}>
    <Card
      hoverable
      style={{ width: 240, margin: '16px' }}
      cover={
        <img
          alt={title}
          style={{ height: '200px', objectFit: 'cover' }}
          src={imageSrc}
        />}
    >
      <Meta title={title} description={description} />
    </Card>
  </Link>
);

export default ProductCard;

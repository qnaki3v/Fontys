import React, { useState, useEffect } from 'react';
import ProductList from '../components/ProductList';
import FilterBox from '../components/ProductFilter';
import ProductAPI from '../api/ProductAPI';
import { Col, Row } from 'antd';
import ProductFilter from '../components/ProductFilter';

function ProductsPage() {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    ProductAPI.getProducts()
      .then(result => { setProducts(result.data.products) })
  }, []);

  const handleFilterSubmit = filterValues => {
    ProductAPI.getProducts(filterValues.category, filterValues.minPrice, filterValues.maxPrice)
      .then(result => { setProducts(result.data.products) })
  };
 

  return (
    <>
      <Row>
        <Col span={6}>
          <div style={{ textAlign: 'center', padding: '50px', paddingTop: '90px' }}>
            <ProductFilter onFilterSubmit={handleFilterSubmit} />
          </div>
        </Col>
        <Col span={18}><ProductList products={products} /></Col>
      </Row>
    </>
  );
}

export default ProductsPage;

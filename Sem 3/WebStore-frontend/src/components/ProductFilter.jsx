// ProductFilter.js
import React, { useState } from 'react';
import { Select, Input, Button, Form } from 'antd';

const { Option } = Select;

const ProductFilter = ({ onFilterSubmit }) => {
  const [form] = Form.useForm();
  const [selectedCategory, setSelectedCategory] = useState(null);

  const handleCategoryChange = value => {
    setSelectedCategory(value === 'null' ? null : value);
  };

  const handleSubmit = values => {
    // Pass the filter values to the parent component
    onFilterSubmit({
      category: selectedCategory,
      minPrice: values.minPrice,
      maxPrice: values.maxPrice,
    });
  };

  return (
    <Form form={form} onFinish={handleSubmit}>
      <Form.Item name="category" label="Category">
        <Select placeholder="Select a category" onChange={handleCategoryChange}>
          <Option value="null">Select category</Option>
          <Option value="Furniture">Furniture</Option>
          <Option value="Tools">Tools</Option>
          {/* Add more categories as needed */}
        </Select>
      </Form.Item>
      <Form.Item name="minPrice" label="Min Price">
        <Input type="number" placeholder="Enter min price" />
      </Form.Item>
      <Form.Item name="maxPrice" label="Max Price">
        <Input type="number" placeholder="Enter max price" />
      </Form.Item>
      <Form.Item>
        <Button type="primary" htmlType="submit">
          Filter
        </Button>
      </Form.Item>
    </Form>
  );
};

export default ProductFilter;

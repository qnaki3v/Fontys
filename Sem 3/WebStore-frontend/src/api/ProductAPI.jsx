import axios from 'axios';

const ProductAPI = {
    getProduct: (id) => axios.get(`http://localhost:8080/products/${id}`),
    getProducts: (category, minPrice, maxPrice) => axios.get("http://localhost:8080/products", {params: { category, minPrice, maxPrice },}),
    createProduct: newProduct => axios.post("http://localhost:8080/products", {id: newProduct,category: newProduct, name: newProduct, price: newProduct}),
    deleteProduct: () => axios.delete("http://localhost:8080/products/{{productId}}"),
    updateProduct: () => axios.put("http://localhost:8080/products/{{id}}")
}

export default ProductAPI;
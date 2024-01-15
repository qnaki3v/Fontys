package nl.fontys.s3.business;

import nl.fontys.s3.domain.*;

import java.util.Optional;

public interface ProductService {
    CreateProductResponse createProduct(CreateProductRequest request);
    void deleteProduct(Integer productId);
    Optional<Product> getProduct(Integer productId);
    GetAllProductsResponse getProducts(GetAllProductsRequest request);
    void updateProduct(UpdateProductRequest request);
}

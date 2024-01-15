package nl.fontys.s3.business.impl;

import com.mysql.cj.util.StringUtils;
import lombok.AllArgsConstructor;
import nl.fontys.s3.business.ProductService;
import nl.fontys.s3.business.specification.ProductSpecification;
import nl.fontys.s3.converters.ProductConverter;
import nl.fontys.s3.domain.*;
import nl.fontys.s3.persistence.ProductRepository;
import nl.fontys.s3.persistence.entity.ProductEntity;
import org.springframework.data.jpa.domain.Specification;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
@AllArgsConstructor
public class ProductServiceImpl implements ProductService {
    private final ProductRepository productRepository;
    @Override
    public CreateProductResponse createProduct(CreateProductRequest request) {
        ProductEntity newProduct = ProductEntity.builder()
                .category(request.getCategory())
                .name(request.getName())
                .price(request.getPrice())
                .imageUrl(request.getImageUrl())
                .build();

        ProductEntity savedProduct = productRepository.save(newProduct);

        return CreateProductResponse.builder()
                .product(savedProduct)
                .build();
    }

    @Override
    public void deleteProduct(Integer productId) {
        this.productRepository.deleteById(Long.valueOf(productId));
    }

    @Override
    public Optional<Product> getProduct(Integer productId) {
        return productRepository.findById(Long.valueOf(productId)).map(ProductConverter::convert);
    }

    @Override
    public GetAllProductsResponse getProducts(GetAllProductsRequest request) {
        Specification<ProductEntity> spec = ProductSpecification.filterBy(request.getCategory(),request.getMinPrice(),request.getMaxPrice());

        List<Product> products = productRepository.findAll(spec)
                .stream()
                .map(ProductConverter::convert)
                .toList();

        return GetAllProductsResponse.builder()
                .products(products)
                .build();
    }

    @Override
    public void updateProduct(UpdateProductRequest request) {
        Optional<ProductEntity> productOptional = productRepository.findById(Long.valueOf(request.getId()));

        ProductEntity product = productOptional.get();

        product.setCategory(request.getCategory());
        product.setName(request.getName());
        product.setPrice(request.getPrice());
        product.setImageUrl(request.getImageUrl());

        productRepository.save(product);
    }
}

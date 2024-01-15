package nl.fontys.s3.business.impl;

import nl.fontys.s3.converters.ProductConverter;
import nl.fontys.s3.domain.*;
import nl.fontys.s3.persistence.ProductRepository;
import nl.fontys.s3.persistence.entity.ProductEntity;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.junit.jupiter.MockitoExtension;

import java.math.BigDecimal;
import java.util.List;
import java.util.Optional;

import static org.junit.jupiter.api.Assertions.*;
import static org.mockito.ArgumentMatchers.any;
import static org.mockito.Mockito.*;

@ExtendWith(MockitoExtension.class)
class ProductServiceImplTest {
    @Mock
    private ProductRepository productRepository;
    @InjectMocks
    private ProductServiceImpl productService;
    @Test
    void createProduct_shouldCreateProduct() {
        // Arrange
        CreateProductRequest request = new CreateProductRequest(1,"Electronics", "Laptop", BigDecimal.valueOf(999.99));
        ProductEntity savedProductEntity = ProductEntity.builder()
                .id(1)
                .category(request.getCategory())
                .name(request.getName())
                .price(request.getPrice())
                .build();
        when(productRepository.save(any(ProductEntity.class))).thenReturn(savedProductEntity);

        // Act
        CreateProductResponse response = productService.createProduct(request);

        // Assert
        assertEquals(savedProductEntity, response.getProduct());
        verify(productRepository, times(1)).save(any(ProductEntity.class));
    }

    @Test
    void deleteProduct_shouldDeleteProduct() {
        // Arrange
        Integer productId = 1;

        // Act
        productService.deleteProduct(productId);

        // Assert
        verify(productRepository, times(1)).deleteById(1L);
    }

    @Test
    void getProduct_existingProduct_shouldReturnProduct() {
        // Arrange
        Integer productId = 1;
        ProductEntity productEntity = ProductEntity.builder()
                .id(1)
                .category("Electronics")
                .name("Laptop")
                .price(BigDecimal.valueOf(999.99))
                .build();
        when(productRepository.findById(1L)).thenReturn(Optional.of(productEntity));

        // Act
        Optional<Product> result = productService.getProduct(productId);

        // Assert
        assertEquals(ProductConverter.convert(productEntity), result.get());
    }

    @Test
    void getProducts_shouldReturnAllProducts() {
        // Arrange
        List<ProductEntity> productEntities = List.of(
                ProductEntity.builder().id(1).category("Electronics").name("Laptop").price(BigDecimal.valueOf(999.99)).build(),
                ProductEntity.builder().id(2).category("Clothing").name("T-Shirt").price(BigDecimal.valueOf(19.99)).build()
        );
        when(productRepository.findAll()).thenReturn(productEntities);

        // Act
        GetAllProductsResponse response = productService.getProducts();

        // Assert
        assertEquals(productEntities.size(), response.getProducts().size());
    }

    @Test
    void updateProduct_shouldUpdateProduct() {
        // Arrange
        UpdateProductRequest request = new UpdateProductRequest(1, "Electronics", "New Laptop", BigDecimal.valueOf(1099.99));
        ProductEntity existingProductEntity = ProductEntity.builder()
                .id(1)
                .category("Electronics")
                .name("Laptop")
                .price(BigDecimal.valueOf(999.99))
                .build();
        when(productRepository.findById(1L)).thenReturn(Optional.of(existingProductEntity));
        when(productRepository.save(any(ProductEntity.class))).thenReturn(existingProductEntity);

        // Act
        productService.updateProduct(request);

        // Assert
        assertEquals(request.getCategory(), existingProductEntity.getCategory());
        assertEquals(request.getName(), existingProductEntity.getName());
        assertEquals(request.getPrice(), existingProductEntity.getPrice());
        verify(productRepository, times(1)).findById(1L);
        verify(productRepository, times(1)).save(any(ProductEntity.class));
    }
}

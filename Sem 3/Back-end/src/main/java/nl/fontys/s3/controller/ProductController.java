package nl.fontys.s3.controller;

import jakarta.validation.Valid;
import lombok.AllArgsConstructor;
import nl.fontys.s3.business.impl.ProductServiceImpl;
import nl.fontys.s3.domain.*;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.math.BigDecimal;
import java.util.Optional;

@CrossOrigin
@RestController
@RequestMapping("/products")
@AllArgsConstructor
public class ProductController {
    private final ProductServiceImpl productService;

    @GetMapping("{id}")
    public ResponseEntity<Product> getProduct(@PathVariable(value = "id") final Integer id) {
        final Optional<Product> productOptional = productService.getProduct(id);
        if (productOptional.isEmpty()) {
            return ResponseEntity.notFound().build();
        }
        return ResponseEntity.ok().body(productOptional.get());
    }
    @GetMapping
    public ResponseEntity<GetAllProductsResponse> getAllProducts(@RequestParam(value = "category", required = false) String category,
                                                                 @RequestParam(value = "minPrice", required = false) BigDecimal minPrice,
                                                                 @RequestParam(value = "maxPrice", required = false) BigDecimal maxPrice) {
        GetAllProductsRequest request = GetAllProductsRequest.builder().category(category).minPrice(minPrice).maxPrice(maxPrice).build();
        GetAllProductsResponse response = productService.getProducts(request);

        return ResponseEntity.ok((response));
    }

    @DeleteMapping("{productId}")
    public ResponseEntity<Void> deleteProduct(@PathVariable int productId) {
        productService.deleteProduct(productId);
        return ResponseEntity.noContent().build();
    }

    @PostMapping()
    public ResponseEntity<CreateProductResponse> createProduct(@RequestBody @Valid CreateProductRequest request) {
        CreateProductResponse response = productService.createProduct(request);
        return ResponseEntity.status(HttpStatus.CREATED).body(response);
    }

    @PutMapping("{id}")
    public ResponseEntity<Void> updateProduct(@PathVariable("id") Integer id,
                                               @RequestBody @Valid UpdateProductRequest request) {
        request.setId(id);
        productService.updateProduct(request);
        return ResponseEntity.noContent().build();
    }
}

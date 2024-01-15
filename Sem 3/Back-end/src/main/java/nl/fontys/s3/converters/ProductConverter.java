package nl.fontys.s3.converters;

import nl.fontys.s3.domain.Product;
import nl.fontys.s3.persistence.entity.ProductEntity;

public class ProductConverter {
    public static Product convert(ProductEntity productEntity) {
        return Product.builder()
                .id(productEntity.getId())
                .category(productEntity.getCategory())
                .name(productEntity.getName())
                .price(productEntity.getPrice())
                .imageUrl(productEntity.getImageUrl())
                .build();
    }
}

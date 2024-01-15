package nl.fontys.s3.domain;

import lombok.Builder;
import lombok.Data;
import nl.fontys.s3.persistence.entity.ProductEntity;

@Data
@Builder
public class CreateProductResponse {
    private ProductEntity product;
}

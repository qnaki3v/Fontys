package nl.fontys.s3.business.specification;

import lombok.AllArgsConstructor;
import lombok.NoArgsConstructor;
import nl.fontys.s3.domain.Product;
import nl.fontys.s3.persistence.entity.ProductEntity;
import org.springframework.data.jpa.domain.Specification;

import java.math.BigDecimal;
@NoArgsConstructor
public class ProductSpecification {
    public static Specification<ProductEntity> filterBy(String category, BigDecimal priceFrom, BigDecimal priceTo) {
        return Specification
                .where(hasCategory(category))
                .and(hasPriceGreaterThan(priceFrom))
                .and(hasPriceLessThan(priceTo));
    }
    public static Specification<ProductEntity> hasCategory (String category){
        return (root, query, criteriaBuilder) -> category == null || category.isEmpty() ? criteriaBuilder.conjunction() : criteriaBuilder.equal(root.get("category"), category);
    };
    public static Specification<ProductEntity> hasPriceGreaterThan(BigDecimal priceFrom) {
        return (root, query, criteriaBuilder) -> priceFrom == null ? criteriaBuilder.conjunction() : criteriaBuilder.greaterThan(root.get("price"), priceFrom);
    }
    public static Specification<ProductEntity> hasPriceLessThan(BigDecimal priceTo) {
        return (root, query, criteriaBuilder) -> priceTo == null ? criteriaBuilder.conjunction() : criteriaBuilder.lessThan(root.get("price"), priceTo);
    }
}

package nl.fontys.s3.persistence;

import jakarta.annotation.Nullable;
import nl.fontys.s3.business.specification.ProductSpecification;
import nl.fontys.s3.persistence.entity.ProductEntity;
import org.springframework.data.jpa.domain.Specification;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.JpaSpecificationExecutor;
import org.springframework.stereotype.Repository;

import java.util.List;
@Repository
public interface ProductRepository extends JpaRepository<ProductEntity, Long>, JpaSpecificationExecutor<ProductEntity> {
    List<ProductEntity> findAll(@Nullable Specification<ProductEntity> spec);
}

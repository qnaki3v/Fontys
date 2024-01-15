package nl.fontys.s3.persistence;

import nl.fontys.s3.persistence.entity.PostcodeEntity;
import org.springframework.data.jpa.repository.JpaRepository;


public interface PostcodeRepository extends JpaRepository<PostcodeEntity, Long> {
    boolean existsByCode(String code);
}

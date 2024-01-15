package nl.fontys.s3.persistence;

import nl.fontys.s3.persistence.entity.PostcodeEntity;
import nl.fontys.s3.persistence.entity.CustomerEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface CustomerRepository extends JpaRepository<CustomerEntity, Long> {
    boolean existsByBSN(String bsn);
    List<CustomerEntity> findAllByPostcode(PostcodeEntity postcode);
}

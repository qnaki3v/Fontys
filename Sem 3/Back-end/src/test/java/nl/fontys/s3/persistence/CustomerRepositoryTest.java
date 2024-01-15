package nl.fontys.s3.persistence;

import jakarta.persistence.EntityManager;
import nl.fontys.s3.persistence.entity.PostcodeEntity;
import nl.fontys.s3.persistence.entity.CustomerEntity;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.jdbc.AutoConfigureTestDatabase;
import org.springframework.boot.test.autoconfigure.orm.jpa.DataJpaTest;
import org.springframework.test.context.junit.jupiter.SpringExtension;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertNotNull;

@ExtendWith(SpringExtension.class)
@DataJpaTest
@AutoConfigureTestDatabase(replace = AutoConfigureTestDatabase.Replace.NONE)
public class CustomerRepositoryTest {
    @Autowired
    private EntityManager entityManager;
    @Autowired
    private CustomerRepository customerRepository;
    @Test
    void save_shouldSaveUserWithAllFields() {
        PostcodeEntity postcode = PostcodeEntity.builder().code("1234AB").build();
        entityManager.persist(postcode);
        CustomerEntity user = CustomerEntity.builder().
                BSN("123456789").
                firstName("TestName").
                lastName("TestSecondName").
                age(33).
                postcode(postcode).build();
        CustomerEntity savedUser = customerRepository.save(user);
        assertNotNull(savedUser.getId());
        savedUser = entityManager.find(CustomerEntity.class, savedUser.getId());
        CustomerEntity expectedUser = CustomerEntity.builder().
                id(savedUser.getId()).
                BSN(savedUser.getBSN()).
                firstName(savedUser.getFirstName()).
                lastName(savedUser.getLastName()).
                age(savedUser.getAge()).
                postcode(savedUser.getPostcode()).build();
        assertEquals(expectedUser, savedUser);
    }
}

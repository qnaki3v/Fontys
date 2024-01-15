package nl.fontys.s3.persistence;

import jakarta.persistence.EntityManager;
import nl.fontys.s3.persistence.entity.PostcodeEntity;
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
public class PostcodeRepositoryTest {
    @Autowired
    private EntityManager entityManager;
    @Autowired
    private PostcodeRepository postcodeRepository;
    @Test
    void save_shouldSaveUserWithAllFields() {
        PostcodeEntity postcode = PostcodeEntity.builder().code("1234AB").build();
        PostcodeEntity savedPostcode = postcodeRepository.save(postcode);
        assertNotNull(savedPostcode.getId());
        savedPostcode = entityManager.find(PostcodeEntity.class, savedPostcode.getId());
        PostcodeEntity expectedPostcode = PostcodeEntity.builder().id(savedPostcode.getId()).code(savedPostcode.getCode()).build();
        assertEquals(expectedPostcode, savedPostcode);
    }
}

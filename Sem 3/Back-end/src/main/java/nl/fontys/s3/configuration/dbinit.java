package nl.fontys.s3.configuration;

import lombok.AllArgsConstructor;
import nl.fontys.s3.business.CustomerService;
import nl.fontys.s3.domain.CreateCustomerRequest;
import nl.fontys.s3.persistence.PostcodeRepository;
import nl.fontys.s3.persistence.UserRepository;
import nl.fontys.s3.persistence.entity.PostcodeEntity;
import nl.fontys.s3.persistence.entity.RoleEnum;
import nl.fontys.s3.persistence.entity.UserEntity;
import nl.fontys.s3.persistence.entity.UserRoleEntity;
import org.springframework.boot.context.event.ApplicationReadyEvent;
import org.springframework.context.event.EventListener;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Component;

import java.util.Set;

@Component
@AllArgsConstructor
public class dbinit {

    private PostcodeRepository postcodeRepository;
    private UserRepository userRepository;
    private PasswordEncoder passwordEncoder;
    private CustomerService customerService;

    @EventListener(ApplicationReadyEvent.class)
    public void populate() {
        if (isEmpty()) {
            insertPostcode();
            insertAdminUser();
            insertCustomer();
        }
    }
    private boolean isEmpty() {
        return userRepository.count() == 0;
    }
    private void insertAdminUser() {
        UserEntity adminUser = UserEntity.builder()
                .username("admin@EWS.nl")
                .password(passwordEncoder.encode("yanipw"))
                .build();
        UserRoleEntity adminRole = UserRoleEntity.builder().role(RoleEnum.ADMIN).user(adminUser).build();
        adminUser.setUserRoles(Set.of(adminRole));
        userRepository.save(adminUser);
    }
    private void insertCustomer() {
        CreateCustomerRequest createCustomerRequest = CreateCustomerRequest.builder()
                .BSN("123123123")
                .password("1234pw")
                .firstName("Linda")
                .lastName("123")
                .age(1)
                .postcodeId(1L)
                .build();
        customerService.createCustomer(createCustomerRequest);
    }
    private void insertPostcode() {
        postcodeRepository.save(PostcodeEntity.builder().code("1234AB").build());
    }
}

package nl.fontys.s3.business.impl;

import nl.fontys.s3.business.exception.InvalidCredentialsException;
import nl.fontys.s3.configuration.security.token.AccessTokenEncoder;
import nl.fontys.s3.configuration.security.token.impl.AccessTokenImpl;
import nl.fontys.s3.domain.LoginRequest;
import nl.fontys.s3.domain.LoginResponse;
import nl.fontys.s3.persistence.UserRepository;
import nl.fontys.s3.persistence.entity.*;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.junit.jupiter.MockitoExtension;
import org.springframework.security.crypto.password.PasswordEncoder;

import java.util.HashSet;
import java.util.Set;

import static org.junit.jupiter.api.Assertions.assertNotNull;
import static org.junit.jupiter.api.Assertions.assertThrows;
import static org.mockito.ArgumentMatchers.any;
import static org.mockito.Mockito.when;

@ExtendWith(MockitoExtension.class)
class LoginUseCaseImplTest {

    @Mock
    private UserRepository userRepository;

    @Mock
    private PasswordEncoder passwordEncoder;

    @Mock
    private AccessTokenEncoder accessTokenEncoder;

    @InjectMocks
    private LoginUseCaseImpl loginUseCase;

    @Test
    void login_SuccessfulWhenAdmin() {
        // Arrange
        Long id = 1L;
        String username = "testUser@EWS.nl";
        String password = "testPassword";
        Set<UserRoleEntity> userRoles = new HashSet<>();
        userRoles.add(UserRoleEntity.builder().role(RoleEnum.ADMIN).build());

        UserEntity userEntity = UserEntity.builder()
                .id(id)
                .username(username)
                .password(passwordEncoder.encode(password))
                .userRoles(userRoles)
                .build();

        when(userRepository.findByUsername(username)).thenReturn(userEntity);
        when(passwordEncoder.matches(password, userEntity.getPassword())).thenReturn(true);
        when(accessTokenEncoder.encode(any(AccessTokenImpl.class))).thenReturn("mockedAccessToken"); // Set the expected return value

        // Act
        LoginRequest loginRequest = new LoginRequest(username, password);
        LoginResponse loginResponse = loginUseCase.login(loginRequest);

        // Assert
        assertNotNull(loginResponse);
        assertNotNull(loginResponse.getAccessToken());
        // You may add more specific assertions based on your implementation
    }
    @Test
    void login_SuccessfulWhenCustomer() {
        // Arrange
        Long id = 1L;
        String username = "testUser@EWS.nl";
        String password = "testPassword";
        Set<UserRoleEntity> userRoles = new HashSet<>();
        userRoles.add(UserRoleEntity.builder().role(RoleEnum.CUSTOMER).build());

        PostcodeEntity postcodeEntity = PostcodeEntity.builder().id(1L).code("12345").build();

        CustomerEntity customerEntity = CustomerEntity.builder()
                .BSN("123123123")
                .firstName("Test")
                .lastName("Customer")
                .age(20)
                .postcode(postcodeEntity).build();

        UserEntity userEntity = UserEntity.builder()
                .id(1L)
                .username("testUser@EWS.nl")
                .password(passwordEncoder.encode("testPassword"))
                .userRoles(userRoles)
                .customer(customerEntity)
                .build();

        when(userRepository.findByUsername(username)).thenReturn(userEntity);
        when(passwordEncoder.matches(password, userEntity.getPassword())).thenReturn(true);
        when(accessTokenEncoder.encode(any(AccessTokenImpl.class))).thenReturn("mockedAccessToken"); // Set the expected return value

        // Act
        LoginRequest loginRequest = new LoginRequest(username, password);
        LoginResponse loginResponse = loginUseCase.login(loginRequest);

        // Assert
        assertNotNull(loginResponse);
        assertNotNull(loginResponse.getAccessToken());
    }
    @Test
    void login_UserNotFound_ThrowsInvalidCredentialsException() {
        // Arrange
        String username = "nonExistentUser";
        String password = "testPassword";

        when(userRepository.findByUsername(username)).thenReturn(null);

        // Act and Assert
        assertThrows(InvalidCredentialsException.class, () -> {
            LoginRequest loginRequest = new LoginRequest(username, password);
            loginUseCase.login(loginRequest);
        });
    }

    @Test
    void login_PasswordMismatch_ThrowsInvalidCredentialsException() {
        // Arrange
        String username = "testUser";
        String correctPassword = "correctPassword";
        String incorrectPassword = "incorrectPassword";

        UserEntity userEntity = UserEntity.builder()
                .username(username)
                .password(passwordEncoder.encode(correctPassword))
                .build();

        when(userRepository.findByUsername(username)).thenReturn(userEntity);
        when(passwordEncoder.matches(incorrectPassword, userEntity.getPassword())).thenReturn(false);

        // Act and Assert
        assertThrows(InvalidCredentialsException.class, () -> {
            LoginRequest loginRequest = new LoginRequest(username, incorrectPassword);
            loginUseCase.login(loginRequest);
        });
    }
}
package nl.fontys.s3.business.impl;

import nl.fontys.s3.business.exception.BSNAlreadyExistsException;
import nl.fontys.s3.business.exception.InvalidPostcodeException;
import nl.fontys.s3.business.exception.InvalidCustomerException;
import nl.fontys.s3.business.exception.UnauthorizedDataAccessException;
import nl.fontys.s3.configuration.security.token.AccessToken;
import nl.fontys.s3.domain.*;
import nl.fontys.s3.persistence.PostcodeRepository;
import nl.fontys.s3.persistence.CustomerRepository;
import nl.fontys.s3.persistence.UserRepository;
import nl.fontys.s3.persistence.entity.PostcodeEntity;
import nl.fontys.s3.persistence.entity.CustomerEntity;
import nl.fontys.s3.persistence.entity.RoleEnum;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.junit.jupiter.MockitoExtension;
import org.springframework.security.crypto.password.PasswordEncoder;

import java.util.Arrays;
import java.util.List;
import java.util.Optional;

import static org.junit.jupiter.api.Assertions.*;
import static org.mockito.ArgumentMatchers.any;
import static org.mockito.Mockito.*;

@ExtendWith(MockitoExtension.class)
class CustomerServiceImplTest {
    @Mock
    private CustomerRepository customerRepository;
    @Mock
    private PostcodeRepository postcodeRepository;
    @Mock
    private UserRepository userRepository;
    @Mock
    private PasswordEncoder passwordEncoder;
    @Mock
    private AccessToken requestAccessToken;
    @InjectMocks
    private CustomerServiceImpl customerService;

    @Test
    void createCustomer() {
        // Arrange
        CreateCustomerRequest request = new CreateCustomerRequest(1L,"123456789", "password123",
                "John", "Doe", 1L, 25);
        PostcodeEntity postcodeEntity = PostcodeEntity.builder().id(1L).code("12345").build();
        CustomerEntity newCustomerEntity = CustomerEntity.builder()
                .BSN(request.getBSN())
                .firstName(request.getFirstName())
                .lastName(request.getLastName())
                .postcode(postcodeEntity)
                .age(request.getAge())
                .build();

        when(customerRepository.existsByBSN(request.getBSN())).thenReturn(false);
        when(postcodeRepository.findById(1L)).thenReturn(Optional.of(postcodeEntity));
        when(customerRepository.save(any(CustomerEntity.class))).thenReturn(newCustomerEntity);

        // Act
        CreateCustomerResponse response = customerService.createCustomer(request);

        // Assert
        assertNotNull(response);
        assertEquals(newCustomerEntity, response.getUser());
    }
    @Test
    void createCustomer_shouldThrowException_whenBSNAlreadyExists() {
        CreateCustomerRequest request = createTestRequest();

        when(customerRepository.existsByBSN(any())).thenReturn(true);

        assertThrows(BSNAlreadyExistsException.class, () -> customerService.createCustomer(request));
    }
    @Test
    void createCustomer_shouldThrowException_whenInvalidPostcode() {
        CreateCustomerRequest request = createTestRequest();

        when(postcodeRepository.findById(any())).thenReturn(Optional.empty());

        assertThrows(InvalidPostcodeException.class, () -> customerService.createCustomer(request));
    }
    @Test
    void deleteCustomer() {
        // Arrange
        Long userId = 1L;

        // Act
        customerService.deleteCustomer(userId);

        // Assert
        verify(customerRepository, times(1)).deleteById(1L);
    }
    @Test
    void getCustomer_Success() {
        //Arrange
        when(requestAccessToken.hasRole(RoleEnum.ADMIN.name())).thenReturn(false);
        Long customerId = 1L;
        when(requestAccessToken.getCustomerId()).thenReturn(customerId);
        CustomerEntity customerEntity = CustomerEntity.builder().id(1L).BSN("123456789").build();
        when(customerRepository.findById(1L)).thenReturn(Optional.of(customerEntity));

        // Act
        Optional<Customer> result = customerService.getCustomer(customerId);

        // Assert
        assertTrue(result.isPresent());
        assertEquals(customerEntity.getBSN(), result.get().getBSN());
        verify(customerRepository, times(1)).findById(1L);
    }
    @Test
    void getCustomer_Unauthorized() {
        // Arrange
        when(requestAccessToken.hasRole(RoleEnum.ADMIN.name())).thenReturn(false);
        Long loggedInCustomerId = 1L;
        Long requestedCustomerId = 2L;
        when(requestAccessToken.getCustomerId()).thenReturn(loggedInCustomerId);

        // Act and Assert
        assertThrows(UnauthorizedDataAccessException.class, () -> {
            customerService.getCustomer(requestedCustomerId);
        });

        // Assert that findById is not called
        verify(customerRepository, never()).findById(any());
    }
    @Test
    void getCustomer_SuccessAdmin() {
        // Arrange
        when(requestAccessToken.hasRole(RoleEnum.ADMIN.name())).thenReturn(true);
        Long requestedCustomerId = 2L;

        CustomerEntity customerEntity = CustomerEntity.builder().id(requestedCustomerId).BSN("123456789").build();
        when(customerRepository.findById(requestedCustomerId)).thenReturn(Optional.of(customerEntity));

        // Act
        Optional<Customer> result = customerService.getCustomer(requestedCustomerId);

        // Assert
        assertTrue(result.isPresent());
        assertEquals(customerEntity.getBSN(), result.get().getBSN());
        verify(customerRepository, times(1)).findById(requestedCustomerId);
    }
    @Test
    void getCustomers() {
        // Arrange
        List<CustomerEntity> userEntities = Arrays.asList(
                CustomerEntity.builder().id(1L).BSN("123456789").build(),
                CustomerEntity.builder().id(2L).BSN("987654321").build()
        );
        when(customerRepository.findAll()).thenReturn(userEntities);

        // Act
        GetAllCustomersResponse result = customerService.getCustomers(new GetAllCustomersRequest());

        // Assert
        assertNotNull(result);
        assertEquals(userEntities.size(), result.getCustomers().size());
        verify(customerRepository, times(1)).findAll();
    }

    @Test
    void updateCustomer_Success() {
        // Arrange
        UpdateCustomerRequest request = new UpdateCustomerRequest(1L, "john_doe", "password123",
                "John", "Doe", 1, 30);
        PostcodeEntity postcodeEntity = PostcodeEntity.builder().id(1L).code("12345").build();
        CustomerEntity existingCustomerEntity = CustomerEntity.builder().id(1L).BSN("123456789")
                .firstName("John").lastName("Doe").postcode(postcodeEntity).age(30).build();

        when(customerRepository.findById(1L)).thenReturn(Optional.of(existingCustomerEntity));
        when(postcodeRepository.findById(1L)).thenReturn(Optional.of(postcodeEntity));
        when(customerRepository.save(any(CustomerEntity.class))).thenReturn(existingCustomerEntity);

        // Act
        customerService.updateCustomer(request);

        // Assert
        verify(customerRepository, times(1)).findById(1L);
        verify(postcodeRepository, times(1)).findById(1L);
        verify(customerRepository, times(1)).save(any(CustomerEntity.class));

        // Verify user values are updated
        assertEquals(request.getFirstName(), existingCustomerEntity.getFirstName());
        assertEquals(request.getLastName(), existingCustomerEntity.getLastName());
        assertEquals(request.getAge(), existingCustomerEntity.getAge());
        assertEquals(postcodeEntity, existingCustomerEntity.getPostcode());
    }

    @Test
    void updateCustomer_InvalidUserException() {
        // Arrange
        UpdateCustomerRequest request = new UpdateCustomerRequest(1L, "john_doe", "password123",
                "John", "Doe", 30, 1);
        when(customerRepository.findById(1L)).thenReturn(Optional.empty());

        // Act & Assert
        assertThrows(InvalidCustomerException.class, () -> customerService.updateCustomer(request));
        verify(customerRepository, times(1)).findById(1L);
        verify(postcodeRepository, times(0)).findById(anyLong());
        verify(customerRepository, times(0)).save(any(CustomerEntity.class));
    }

    @Test
    void updateCustomer_InvalidPostcodeException() {
        // Arrange
        UpdateCustomerRequest request = new UpdateCustomerRequest(1L, "john_doe", "password123",
                "John", "Doe", 30, 1);
        CustomerEntity existingCustomerEntity = CustomerEntity.builder().id(1L).BSN("123456789").build();
        when(customerRepository.findById(1L)).thenReturn(Optional.of(existingCustomerEntity));
        when(postcodeRepository.findById(30L)).thenReturn(Optional.empty());

        // Act & Assert
        assertThrows(InvalidPostcodeException.class, () -> customerService.updateCustomer(request));
        verify(customerRepository, times(1)).findById(1L);
        verify(postcodeRepository, times(1)).findById(30L);
        verify(customerRepository, times(0)).save(any(CustomerEntity.class));
    }
//    @Test
//    void equals_shouldReturnTrue_whenFieldsHaveSameValue() {
//        CreateCustomerRequest requestOne = createTestRequest();
//        CreateCustomerRequest requestTwo = createTestRequest();
//        assertEquals(requestOne,requestTwo);
//    }
//    @Test
//    void equals_shouldReturnFalse_whenFieldsHaveDifferentValue() {
//        CreateCustomerRequest requestOne = createTestRequest();
//        CreateCustomerRequest requestTwo = createTestRequest();
//        requestTwo.setFirstName("Different name");
//        assertNotEquals(requestOne,requestTwo);
//    }
    private CreateCustomerRequest createTestRequest() {
        CreateCustomerRequest createCustomerRequest = new CreateCustomerRequest();
        createCustomerRequest.setId(1L);
        createCustomerRequest.setBSN("123456789");
        createCustomerRequest.setPassword("passwordTest");
        createCustomerRequest.setFirstName("Yani");
        createCustomerRequest.setLastName("Test");
        createCustomerRequest.setPostcodeId(1L);
        createCustomerRequest.setAge(20);
        return createCustomerRequest;
    }
}

package nl.fontys.s3.business.impl;

import lombok.AllArgsConstructor;
import nl.fontys.s3.business.CustomerService;
import nl.fontys.s3.business.exception.BSNAlreadyExistsException;
import nl.fontys.s3.business.exception.InvalidPostcodeException;
import nl.fontys.s3.business.exception.InvalidCustomerException;
import nl.fontys.s3.business.exception.UnauthorizedDataAccessException;
import nl.fontys.s3.configuration.security.token.AccessToken;
import nl.fontys.s3.converters.CustomerConverter;
import nl.fontys.s3.domain.*;
import nl.fontys.s3.persistence.PostcodeRepository;
import nl.fontys.s3.persistence.CustomerRepository;
import nl.fontys.s3.persistence.UserRepository;
import nl.fontys.s3.persistence.entity.*;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Objects;
import java.util.Optional;
import java.util.Set;

@Service
@AllArgsConstructor
public class CustomerServiceImpl implements CustomerService {

    private static final String USERNAME_SUFFIX = "@EWS.nl";

    private final CustomerRepository customerRepository;
    private final UserRepository userRepository;
    private final PostcodeRepository postcodeRepository;
    private final PasswordEncoder passwordEncoder;
    private AccessToken requestAccessToken;
//transactional
    @Override
    public CreateCustomerResponse createCustomer(CreateCustomerRequest request) {
        if (customerRepository.existsByBSN(request.getBSN())) {
            throw new BSNAlreadyExistsException();
        }
        Optional<PostcodeEntity> postcode =  postcodeRepository.findById(request.getPostcodeId());
        if (postcode.isEmpty()) {
            throw new InvalidPostcodeException("POSTCODE_NOT_FOUND");
        }

        CustomerEntity savedCustomer = saveNewCustomer(request);

        saveNewUser(savedCustomer, request.getPassword());

        return CreateCustomerResponse.builder()
                .user(savedCustomer)
                .build();
    }

    @Override
    public void deleteCustomer(Long customerId) {
        this.customerRepository.deleteById(customerId);
    }

    @Override
    public Optional<Customer> getCustomer(Long customerId) {
        if (!requestAccessToken.hasRole(RoleEnum.ADMIN.name())) {
            if (!Objects.equals(requestAccessToken.getCustomerId(), customerId)) {
                throw new UnauthorizedDataAccessException("CUSTOMER_ID_NOT_FROM_LOGGED_IN_USER");
            }
        }
        return customerRepository.findById(customerId).map(CustomerConverter::convert);
    }

    @Override
    public GetAllCustomersResponse getCustomers(GetAllCustomersRequest request) {
        List<Customer> customers = customerRepository.findAll()
                .stream()
                .map(CustomerConverter::convert)
                .toList();

        return GetAllCustomersResponse.builder()
                .customers(customers)
                .build();
    }

    @Override
    public void updateCustomer(UpdateCustomerRequest request) {
        Optional<CustomerEntity> customerOptional = customerRepository.findById(request.getId());
        if (customerOptional.isEmpty()) {
            throw new InvalidCustomerException("CUSTOMER_ID_INVALID");
        }
        Optional<PostcodeEntity> postcode =  postcodeRepository.findById(Long.valueOf(request.getPostcodeId()));
        if (postcode.isEmpty()) {
            throw new InvalidPostcodeException("POSTCODE_NOT_FOUND");
        }

        CustomerEntity customer = customerOptional.get();

        customer.setFirstName(request.getFirstName());
        customer.setLastName(request.getLastName());
        customer.setAge(request.getAge());
        customer.setPostcode(postcode.get());

        customerRepository.save(customer);
    }
    private void saveNewUser(CustomerEntity customer, String password) {
        String encodedPassword = passwordEncoder.encode(password);

        UserEntity newUser = UserEntity.builder()
                .username(customer.getBSN() + USERNAME_SUFFIX)
                .password(encodedPassword)
                .customer(customer)
                .build();

        newUser.setUserRoles(Set.of(
                UserRoleEntity.builder()
                        .user(newUser)
                        .role(RoleEnum.CUSTOMER)
                        .build()));
        userRepository.save(newUser);
    }
    private CustomerEntity saveNewCustomer(CreateCustomerRequest request) {
        CustomerEntity newCustomer = CustomerEntity.builder()
                .BSN(request.getBSN())
//                .username((request.getUsername()))
//                .password(request.getPassword())
                .firstName(request.getFirstName())
                .lastName(request.getLastName())
                .postcode(PostcodeEntity.builder().id(request.getPostcodeId()).build())
                .age(request.getAge())
                .build();
        return customerRepository.save(newCustomer);
    }
}
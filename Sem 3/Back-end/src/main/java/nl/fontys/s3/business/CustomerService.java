package nl.fontys.s3.business;

import nl.fontys.s3.domain.*;

import java.util.Optional;

public interface CustomerService {
    CreateCustomerResponse createCustomer(CreateCustomerRequest request);
    void deleteCustomer(Long customerId);
    Optional<Customer> getCustomer(Long customerId);
    GetAllCustomersResponse getCustomers(GetAllCustomersRequest request);
    void updateCustomer(UpdateCustomerRequest request);


}

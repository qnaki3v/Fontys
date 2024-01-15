package nl.fontys.s3.controller;

import jakarta.annotation.security.RolesAllowed;
import jakarta.validation.Valid;
import lombok.AllArgsConstructor;
import nl.fontys.s3.business.impl.CustomerServiceImpl;
import nl.fontys.s3.domain.*;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.Optional;

@CrossOrigin
@RestController
@RequestMapping("/customers")
@AllArgsConstructor
public class CustomerController {
    private final CustomerServiceImpl customerService;

    @GetMapping("{id}")
    @RolesAllowed({"CUSTOMER", "ADMIN"})
    public ResponseEntity<Customer> getCustomer(@PathVariable(value = "id") final Long id) {
        final Optional<Customer> customerOptional = customerService.getCustomer(id);
        if (customerOptional.isEmpty()) {
            return ResponseEntity.notFound().build();
        }
        return ResponseEntity.ok().body(customerOptional.get());
    }

    @GetMapping
    @RolesAllowed({"ADMIN"})
    public ResponseEntity<GetAllCustomersResponse> getAllCustomers(@RequestParam(value = "postcode", required = false) String code) {
        GetAllCustomersRequest request = GetAllCustomersRequest.builder().postcode(code).build();
        GetAllCustomersResponse response = customerService.getCustomers(request);

        return ResponseEntity.ok(response);
    }

    @DeleteMapping("{customerId}")
    @RolesAllowed({"ADMIN"})
    public ResponseEntity<Void> deleteCustomer(@PathVariable Long customerId) {
        customerService.deleteCustomer(customerId);
        return ResponseEntity.noContent().build();
    }

    @PostMapping()
    public ResponseEntity<CreateCustomerResponse> createCustomer(@RequestBody @Valid CreateCustomerRequest request) {// bez response entity otpred
        CreateCustomerResponse response = customerService.createCustomer(request);
        return ResponseEntity.status(HttpStatus.CREATED).body(response);
    }

    @PutMapping("{id}")
    public ResponseEntity<Void> updateCustomer(@PathVariable("id") Long id,
                                               @RequestBody @Valid UpdateCustomerRequest request) {
        request.setId(id);
        customerService.updateCustomer(request);
        return ResponseEntity.noContent().build();
    }
}

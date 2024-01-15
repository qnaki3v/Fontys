package nl.fontys.s3.converters;

import nl.fontys.s3.domain.Customer;
import nl.fontys.s3.persistence.entity.CustomerEntity;

public class CustomerConverter {
    public static Customer convert(CustomerEntity customerEntity) {
        return Customer.builder()
                .id(customerEntity.getId())
                .BSN(customerEntity.getBSN())
                .firstName(customerEntity.getFirstName())
                .lastName(customerEntity.getLastName())
                .postcode(customerEntity.getPostcode())
                .age(customerEntity.getAge())
                .build();
    }
}

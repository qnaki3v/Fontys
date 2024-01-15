package nl.fontys.s3.business.impl;

import nl.fontys.s3.converters.CustomerConverter;
import nl.fontys.s3.domain.Customer;
import nl.fontys.s3.persistence.entity.PostcodeEntity;
import nl.fontys.s3.persistence.entity.CustomerEntity;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class CustomerEntityConverterTest {
    @Test
    void shouldConvertAllUserFieldsToDomain() {
        PostcodeEntity postcode = PostcodeEntity.builder().code("1234AB").build();

        CustomerEntity userToBeConverted = CustomerEntity.builder().
                BSN("123456789").
                firstName("TestName").
                lastName("TestSecondName").
                age(33).
                postcode(postcode).build();

        Customer actual = CustomerConverter.convert(userToBeConverted);

        Customer expected = Customer.builder().
                BSN("123456789").
                firstName("TestName").
                lastName("TestSecondName").
                age(33).
                postcode(postcode).build();

        assertEquals(expected, actual);
    }
}

package nl.fontys.s3.business.impl;

import nl.fontys.s3.converters.PostcodeConverter;
import nl.fontys.s3.domain.Postcode;
import nl.fontys.s3.persistence.entity.PostcodeEntity;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class PostcodeEntityConverterTest {
    @Test
    void shouldConvertAllPostcodeFieldsToDomain() {
        PostcodeEntity postcode = PostcodeEntity.builder().code("1234AB").build();
        Postcode actual = PostcodeConverter.convert(postcode);
        Postcode expected = Postcode.builder().code("1234AB").build();
        assertEquals(expected, actual);
    }

}

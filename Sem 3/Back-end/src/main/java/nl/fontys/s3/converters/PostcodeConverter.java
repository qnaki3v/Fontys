package nl.fontys.s3.converters;

import nl.fontys.s3.domain.Postcode;
import nl.fontys.s3.persistence.entity.PostcodeEntity;

public class PostcodeConverter {
    private PostcodeConverter() {

    }

    public static Postcode convert(PostcodeEntity postcode) {
        return Postcode.builder()
                .id(postcode.getId())
                .code(postcode.getCode())
                .build();
    }
}

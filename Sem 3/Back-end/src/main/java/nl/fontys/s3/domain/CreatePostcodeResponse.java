package nl.fontys.s3.domain;

import lombok.Builder;
import lombok.Data;
import nl.fontys.s3.persistence.entity.PostcodeEntity;

@Data
@Builder
public class CreatePostcodeResponse {
    private PostcodeEntity postcode;
}

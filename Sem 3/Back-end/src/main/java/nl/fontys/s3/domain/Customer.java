package nl.fontys.s3.domain;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;
import nl.fontys.s3.persistence.entity.PostcodeEntity;

@Data
@Builder
@NoArgsConstructor
@AllArgsConstructor
public class Customer {
    private Long id;
    private String BSN;
    private String firstName;
    private String lastName;
    private PostcodeEntity postcode;
    private int age;
}

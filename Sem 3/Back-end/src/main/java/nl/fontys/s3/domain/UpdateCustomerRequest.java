package nl.fontys.s3.domain;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@Builder
@AllArgsConstructor
@NoArgsConstructor
public class UpdateCustomerRequest {
    private Long id;
    private String username;
    private String password;
    private String firstName;
    private String lastName;
    private Integer postcodeId;
    private int age;
}

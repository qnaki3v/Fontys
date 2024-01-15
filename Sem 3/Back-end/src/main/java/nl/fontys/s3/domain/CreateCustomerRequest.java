package nl.fontys.s3.domain;

import lombok.*;
@Data
@Builder
@AllArgsConstructor
@NoArgsConstructor
public class CreateCustomerRequest {
    private Long id;
    private String BSN;
    private String password;
    private String firstName;
    private String lastName;
    private Long postcodeId;
    private int age;
}

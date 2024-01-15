package nl.fontys.s3.domain;

import lombok.Builder;
import lombok.Data;
import nl.fontys.s3.persistence.entity.CustomerEntity;

@Data
@Builder
public class CreateCustomerResponse {
    private CustomerEntity user;
}

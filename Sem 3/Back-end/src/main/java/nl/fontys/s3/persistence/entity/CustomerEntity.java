package nl.fontys.s3.persistence.entity;

import jakarta.persistence.*;
import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.NotNull;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.hibernate.validator.constraints.Length;

@Entity
@Table(name="customers")
@Data
@Builder
@AllArgsConstructor
@NoArgsConstructor
public class CustomerEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id")
    private Long id;

    @NotBlank
    @Length(min = 9, max = 9)
    @Column(name = "bsn")
    private String BSN;

    @NotBlank
    @Length(min = 2, max = 20)
    @Column(name = "first_name")
    private String firstName;

    @NotBlank
    @Length(min = 2, max = 20)
    @Column(name = "last_name")
    private String lastName;

    @NotNull
    @Column(name = "age")
    private int age;

    @NotNull
    @ManyToOne
    @JoinColumn(name = "postcode_id")
    private PostcodeEntity postcode;
}

package nl.fontys.s3.persistence.entity;

import jakarta.persistence.*;
import jakarta.validation.constraints.Digits;
import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.NotNull;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.hibernate.validator.constraints.Length;

import java.math.BigDecimal;

@Entity
@Table(name = "products")
@Data
@Builder
@AllArgsConstructor
@NoArgsConstructor
public class ProductEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id")
    private Integer id;

    @NotBlank
    @Length(min = 2, max = 20)
    @Column(name = "name")
    private String name;

    @NotBlank
    @Length(min = 2, max = 20)
    @Column(name = "category")
    private String category;

    @NotNull
    @Digits(integer = 12, fraction = 2)
    @Column(name = "price")
    private BigDecimal price;

    @Length(min = 2, max = 255)
    @Column(name = "image_url")
    private String imageUrl;
}

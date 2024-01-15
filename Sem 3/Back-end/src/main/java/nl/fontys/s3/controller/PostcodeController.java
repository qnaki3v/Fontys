package nl.fontys.s3.controller;

import jakarta.validation.Valid;
import lombok.AllArgsConstructor;
import nl.fontys.s3.business.impl.PostcodeServiceImpl;
import nl.fontys.s3.domain.*;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.Optional;

@CrossOrigin
@RestController
@RequestMapping("/postcodes")
@AllArgsConstructor
public class PostcodeController {
    private final PostcodeServiceImpl postcodeService;

    @GetMapping("{id}")
    public ResponseEntity<Postcode> getPostcode(@PathVariable(value = "id") final Integer id) {
        final Optional<Postcode> postcodeOptional = postcodeService.getPostcode((id));
        if (postcodeOptional.isEmpty()) {
            return ResponseEntity.notFound().build();
        }
        return ResponseEntity.ok().body(postcodeOptional.get());
    }
    @GetMapping
    public ResponseEntity<GetAllPostcodesResponse> getPostcodes() {
        return ResponseEntity.ok(postcodeService.getPostcodes());
    }

    @DeleteMapping("{postcodeId}")
    public ResponseEntity<Void> deletePostcode(@PathVariable int postcodeId) {
        postcodeService.deletePostcode(postcodeId);
        return ResponseEntity.noContent().build();
    }

    @PostMapping()
    public ResponseEntity<CreatePostcodeResponse> createPostcode(@RequestBody @Valid CreatePostcodeRequest request) {
        CreatePostcodeResponse response = postcodeService.createPostcode(request);
        return ResponseEntity.status(HttpStatus.CREATED).body(response);
    }

    @PutMapping("{id}")
    public ResponseEntity<Void> updatePostcode(@PathVariable("id") Integer id,
                                           @RequestBody @Valid UpdatePostcodeRequest request) {
        request.setId(id);
        postcodeService.updatePostcode(request);
        return ResponseEntity.noContent().build();
    }
}

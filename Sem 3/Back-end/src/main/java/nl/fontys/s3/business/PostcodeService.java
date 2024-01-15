package nl.fontys.s3.business;

import nl.fontys.s3.domain.*;

import java.util.Optional;

public interface PostcodeService {
    CreatePostcodeResponse createPostcode(CreatePostcodeRequest request);
    void deletePostcode(Integer postcodeId);
    Optional<Postcode> getPostcode(Integer postcodeId);
    GetAllPostcodesResponse getPostcodes();
    void updatePostcode(UpdatePostcodeRequest request);
}

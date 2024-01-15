package nl.fontys.s3.business.impl;

import lombok.AllArgsConstructor;
import nl.fontys.s3.business.PostcodeService;
import nl.fontys.s3.converters.PostcodeConverter;
import nl.fontys.s3.domain.*;
import nl.fontys.s3.persistence.PostcodeRepository;
import nl.fontys.s3.persistence.entity.PostcodeEntity;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
@AllArgsConstructor
public class PostcodeServiceImpl implements PostcodeService {
    private final PostcodeRepository postcodeRepository;
    @Override
    public CreatePostcodeResponse createPostcode(CreatePostcodeRequest request) {
        PostcodeEntity newPostcode = PostcodeEntity.builder()
                .code(request.getCode())
                .build();

        PostcodeEntity savedPostcode = postcodeRepository.save(newPostcode);
        return CreatePostcodeResponse.builder()
                .postcode(savedPostcode)
                .build();
    }

    @Override
    public void deletePostcode(Integer postcodeId) {
        this.postcodeRepository.deleteById(Long.valueOf(postcodeId));
    }

    @Override
    public Optional<Postcode> getPostcode(Integer postcodeId) {
        return postcodeRepository.findById(Long.valueOf(postcodeId)).map(PostcodeConverter::convert);
    }

    @Override
    public GetAllPostcodesResponse getPostcodes() {
        List<Postcode> postcodes = postcodeRepository.findAll()
                .stream()
                .map(PostcodeConverter::convert)
                .toList();

        return GetAllPostcodesResponse.builder()
                .postcodes(postcodes)
                .build();
    }

    @Override
    public void updatePostcode(UpdatePostcodeRequest request) {
        Optional<PostcodeEntity> postcodeOptional = postcodeRepository.findById(Long.valueOf(request.getId()));

//        if (postcodeOptional.isEmpty()) {
//            throw new InvalidPostcodeException();
//        }

        PostcodeEntity postcode = postcodeOptional.get();

        postcode.setCode(request.getCode());

        postcodeRepository.save(postcode);
    }
}

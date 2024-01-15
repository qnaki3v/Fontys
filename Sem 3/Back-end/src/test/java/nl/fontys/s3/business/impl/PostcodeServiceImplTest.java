package nl.fontys.s3.business.impl;

import nl.fontys.s3.domain.*;
import nl.fontys.s3.persistence.entity.PostcodeEntity;
import nl.fontys.s3.persistence.PostcodeRepository;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.junit.jupiter.MockitoExtension;

import java.util.Arrays;
import java.util.List;
import java.util.Optional;

import static org.junit.jupiter.api.Assertions.*;
import static org.mockito.ArgumentMatchers.any;
import static org.mockito.Mockito.*;

@ExtendWith(MockitoExtension.class)
class PostcodeServiceImplTest {
    @Mock
    private PostcodeRepository postcodeRepository;
    @InjectMocks
    private PostcodeServiceImpl postcodeService;
    @Test
    void createPostcode_shouldCreatePostcodeSuccessfully() {
        CreatePostcodeRequest request = new CreatePostcodeRequest(1L,"12345");
        PostcodeEntity newPostcodeEntity = PostcodeEntity.builder().id(request.getId()).code(request.getCode()).build();
        when(postcodeRepository.save(any(PostcodeEntity.class))).thenReturn(newPostcodeEntity);

        CreatePostcodeResponse response = postcodeService.createPostcode(request);

        assertNotNull(response);
        assertEquals(newPostcodeEntity, response.getPostcode());
    }

    @Test
    void deletePostcode_shouldDeletePostcodeSuccessfully() {
        doNothing().when(postcodeRepository).deleteById(any());

        postcodeService.deletePostcode(1);

        verify(postcodeRepository, times(1)).deleteById(1L);
    }

    @Test
    void getPostcode_shouldReturnPostcodeIfExists() {
        PostcodeEntity postcodeEntity = PostcodeEntity.builder().id(1L).code("12345").build();
        when(postcodeRepository.findById(1L)).thenReturn(Optional.of(postcodeEntity));

        Optional<Postcode> result = postcodeService.getPostcode(1);

        assertTrue(result.isPresent());
        assertEquals("12345", result.get().getCode());
    }

    @Test
    void getPostcodes_shouldReturnPostcodesIfNotEmpty() {
        List<PostcodeEntity> postcodeEntities = Arrays.asList(
                PostcodeEntity.builder().id(1L).code("12345").build(),
                PostcodeEntity.builder().id(2L).code("67890").build()
        );
        when(postcodeRepository.findAll()).thenReturn(postcodeEntities);

        GetAllPostcodesResponse result = postcodeService.getPostcodes();

        assertNotNull(result);
        assertEquals(postcodeEntities.size(), result.getPostcodes().size());
        verify(postcodeRepository, times(1)).findAll();
    }

    @Test
    void updatePostcode_shouldUpdateValuesOfPostcode() {

        UpdatePostcodeRequest request = new UpdatePostcodeRequest(1, "54321");
        PostcodeEntity existingPostcodeEntity = PostcodeEntity.builder().id(1L).code("12345").build();
        when(postcodeRepository.findById(1L)).thenReturn(Optional.of(existingPostcodeEntity));
        when(postcodeRepository.save(any(PostcodeEntity.class))).thenReturn(existingPostcodeEntity);

        postcodeService.updatePostcode(request);

        assertEquals(request.getCode(), existingPostcodeEntity.getCode());
    }
}

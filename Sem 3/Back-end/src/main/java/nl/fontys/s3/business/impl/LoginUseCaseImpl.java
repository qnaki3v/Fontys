package nl.fontys.s3.business.impl;

import lombok.RequiredArgsConstructor;
import nl.fontys.s3.business.LoginUseCase;
import nl.fontys.s3.business.exception.InvalidCredentialsException;
import nl.fontys.s3.configuration.security.token.AccessTokenEncoder;
import nl.fontys.s3.configuration.security.token.impl.AccessTokenImpl;
import nl.fontys.s3.domain.LoginRequest;
import nl.fontys.s3.domain.LoginResponse;
import nl.fontys.s3.persistence.UserRepository;
import nl.fontys.s3.persistence.entity.UserEntity;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@RequiredArgsConstructor
public class LoginUseCaseImpl implements LoginUseCase {
    private final UserRepository userRepository;
    private final PasswordEncoder passwordEncoder;
    private final AccessTokenEncoder accessTokenEncoder;
    @Override
    public LoginResponse login(LoginRequest loginRequest) {
        UserEntity user = userRepository.findByUsername(loginRequest.getUsername());
        if (user == null) {
            throw new InvalidCredentialsException();
        }

        if (!matchesPassword(loginRequest.getPassword(), user.getPassword())) {
            throw new InvalidCredentialsException();
        }

        String accessToken = generateAccessToken(user);
        return LoginResponse.builder().accessToken(accessToken).build();
    }

    private boolean matchesPassword(String rawPassword, String encodedPassword) {
        return passwordEncoder.matches(rawPassword, encodedPassword);
    }

    private String generateAccessToken(UserEntity user) {
        Long customerId = user.getCustomer() != null ? user.getCustomer().getId() : null;
        List<String> roles = user.getUserRoles().stream()
                .map(userRole -> userRole.getRole().toString())
                .toList();

        return accessTokenEncoder.encode(
                new AccessTokenImpl(user.getUsername(), customerId, roles));
    }
}

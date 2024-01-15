package nl.fontys.s3.business;

import nl.fontys.s3.domain.LoginRequest;
import nl.fontys.s3.domain.LoginResponse;

public interface LoginUseCase {
    LoginResponse login(LoginRequest loginRequest);
}

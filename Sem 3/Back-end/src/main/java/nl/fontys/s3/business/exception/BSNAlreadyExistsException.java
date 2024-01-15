package nl.fontys.s3.business.exception;

import org.springframework.http.HttpStatus;
import org.springframework.web.server.ResponseStatusException;

public class BSNAlreadyExistsException extends ResponseStatusException {
    public BSNAlreadyExistsException() {
        super(HttpStatus.BAD_REQUEST, "BSN_ALREADY_EXISTS");
    }
}

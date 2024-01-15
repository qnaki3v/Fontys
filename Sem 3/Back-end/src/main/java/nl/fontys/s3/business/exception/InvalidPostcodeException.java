package nl.fontys.s3.business.exception;

import org.springframework.http.HttpStatus;
import org.springframework.web.server.ResponseStatusException;

public class InvalidPostcodeException extends ResponseStatusException {
    public InvalidPostcodeException(String errorCode) {
        super(HttpStatus.BAD_REQUEST, errorCode);
    }
}

package nl.fontys.s3.configuration.security.token.impl;

import lombok.EqualsAndHashCode;
import lombok.Getter;
import nl.fontys.s3.configuration.security.token.AccessToken;

import java.util.Collection;
import java.util.Collections;
import java.util.Set;

@EqualsAndHashCode
@Getter
public class AccessTokenImpl implements AccessToken {
    private final String subject;
    private final Long customerId;
    private final Set<String> roles;

    public AccessTokenImpl(String subject, Long customerId, Collection<String> roles) {
        this.subject = subject;
        this.customerId = customerId;
        this.roles = roles != null ? Set.copyOf(roles) : Collections.emptySet();
    }

    @Override
    public boolean hasRole(String roleName) {
        return this.roles.contains(roleName);
    }
}

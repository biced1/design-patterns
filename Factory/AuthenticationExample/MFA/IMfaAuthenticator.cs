namespace DesignPatterns.Factory.AuthenticationExample.MFA;

public interface IMfaAuthenticator
{
    void Authenticate(User user);
}
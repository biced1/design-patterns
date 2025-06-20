namespace DesignPatterns.Factory.AuthenticationExample.MFA;

public class OtpAuthenticator : IMfaAuthenticator
{
    public void Authenticate(User user)
    {
        // send one time password
        // verify user enters password correctly
    }
}
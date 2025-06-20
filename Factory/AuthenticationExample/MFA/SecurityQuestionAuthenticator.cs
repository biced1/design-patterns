namespace DesignPatterns.Factory.AuthenticationExample.MFA;

public class SecurityQuestionAuthenticator : IMfaAuthenticator
{
    public void Authenticate(User user)
    {
        // ask the user a security question
        // ensure they answer correctly
    }
}
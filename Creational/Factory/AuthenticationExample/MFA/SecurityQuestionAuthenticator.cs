namespace DesignPatterns.Factory.AuthenticationExample.MFA;

/// <inheritdoc />
public class SecurityQuestionAuthenticator : IMfaAuthenticator
{
    /// <inheritdoc />
    public void Authenticate(User user)
    {
        // ask the user a security question
        // ensure they answer correctly
        user.IsLoggedIn = true;
        user.AuthenticationType = AuthenticationType.SecurityQuestion;
    }
}
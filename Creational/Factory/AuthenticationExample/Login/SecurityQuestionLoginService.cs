using Factory.AuthenticationExample.MFA;

namespace Factory.AuthenticationExample.Login;

/// <inheritdoc />
public class SecurityQuestionLoginService : LoginService
{
    /// <inheritdoc />
    protected override IMfaAuthenticator CreateMFAVerificationService()
    {
        return new SecurityQuestionAuthenticator();
    }
}
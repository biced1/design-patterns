using Factory.AuthenticationExample.MFA;

namespace Factory.AuthenticationExample.Login;

/// <inheritdoc />
public class OtpLoginService : LoginService
{
    /// <inheritdoc />
    protected override IMfaAuthenticator CreateMFAVerificationService()
    {
        return new OtpAuthenticator();
    }
}
using DesignPatterns.Factory.AuthenticationExample.MFA;

namespace DesignPatterns.Factory.AuthenticationExample.Login;

/// <inheritdoc />
public class OtpLoginService : LoginService
{
    /// <inheritdoc />
    protected override IMfaAuthenticator CreateMFAVerificationService()
    {
        return new OtpAuthenticator();
    }
}
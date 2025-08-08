using Factory.AuthenticationExample.MFA;

namespace Factory.AuthenticationExample.Login;

/// <inheritdoc />
public class BiomentricLoginService : LoginService
{
    /// <inheritdoc />
    protected override IMfaAuthenticator CreateMFAVerificationService()
    {
        return new BiometricAuthenticator();
    }
}
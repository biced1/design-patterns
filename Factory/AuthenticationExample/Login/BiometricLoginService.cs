using DesignPatterns.Factory.AuthenticationExample.MFA;

namespace DesignPatterns.Factory.AuthenticationExample.Login;

public class BiomentricLoginService : LoginService
{
    protected override IMfaAuthenticator CreateMFAVerificationService()
    {
        return new BiometricAuthenticator();
    }
}
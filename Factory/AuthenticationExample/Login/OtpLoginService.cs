using DesignPatterns.Factory.AuthenticationExample.MFA;

namespace DesignPatterns.Factory.AuthenticationExample.Login;

public class OtpLoginService : LoginService
{
    protected override IMfaAuthenticator CreateMFAVerificationService()
    {
        return new OtpAuthenticator();
    }
}
using DesignPatterns.Factory.AuthenticationExample.MFA;

namespace DesignPatterns.Factory.AuthenticationExample.Login;

public class SecurityQuestionLoginService : LoginService
{
    protected override IMfaAuthenticator CreateMFAVerificationService()
    {
        return new SecurityQuestionAuthenticator();
    }
}
using DesignPatterns.Factory.AuthenticationExample.MFA;

namespace DesignPatterns.Factory.AuthenticationExample.Login;

/// <summary>
/// Service that allows a user to login to an application.
/// </summary>
public abstract class LoginService
{
    private IMfaAuthenticator mfaAuthenticator;

    public LoginService()
    {
        mfaAuthenticator = CreateMFAVerificationService();
    }

    public void Login(User user)
    {
        mfaAuthenticator.Authenticate(user);
        //other login tasks
    }

    protected abstract IMfaAuthenticator CreateMFAVerificationService();
}
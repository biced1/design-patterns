using Factory.AuthenticationExample.MFA;

namespace Factory.AuthenticationExample.Login;

/// <summary>
/// Service that allows a user to login to an application.
/// Also is using the factory pattern. 
/// Most factory pattern implementations are in services doing other things.
/// </summary>
public abstract class LoginService
{
    private IMfaAuthenticator mfaAuthenticator;

    public LoginService()
    {
        mfaAuthenticator = CreateMFAVerificationService();
    }

    /// <summary>
    /// Allows a user to login to the application.
    /// </summary>
    /// <param name="user"></param>
    public void Login(User user)
    {
        mfaAuthenticator.Authenticate(user);
        //other login tasks
    }

    /// <summary>
    /// Creates an MFA Verification service using the factory pattern
    /// </summary>
    /// <returns></returns>
    protected abstract IMfaAuthenticator CreateMFAVerificationService();
}
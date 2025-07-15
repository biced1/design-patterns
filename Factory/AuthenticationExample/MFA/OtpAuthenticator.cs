namespace DesignPatterns.Factory.AuthenticationExample.MFA;

/// <inheritdoc />
public class OtpAuthenticator : IMfaAuthenticator
{
    /// <inheritdoc />
    public void Authenticate(User user)
    {
        // send one time password
        // verify user enters password correctly
        user.IsLoggedIn = true;
        user.AuthenticationType = AuthenticationType.OTP;
    }
}
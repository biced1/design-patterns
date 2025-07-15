namespace DesignPatterns.Factory.AuthenticationExample.MFA;

/// <inheritdoc />
public class BiometricAuthenticator : IMfaAuthenticator
{
    /// <inheritdoc />
    public void Authenticate(User user)
    {
        //scan users fingerprint
        //ensure it matches stored fingerprint
        user.IsLoggedIn = true;
        user.AuthenticationType = AuthenticationType.Biometric;
    }
}
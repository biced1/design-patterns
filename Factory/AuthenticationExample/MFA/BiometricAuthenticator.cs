namespace DesignPatterns.Factory.AuthenticationExample.MFA;

public class BiometricAuthenticator : IMfaAuthenticator
{
    public void Authenticate(User user)
    {
        //scan users fingerprint
        //ensure it matches stored fingerprint
    }
}
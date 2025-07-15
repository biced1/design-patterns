namespace DesignPatterns.Factory.AuthenticationExample.MFA;

/// <summary>
/// Service that authenticates a user with some kind of Multi-factor authentication.
/// </summary>
public interface IMfaAuthenticator
{
    /// <summary>
    /// authenticates a user with some kind of Multi-factor authentication.
    /// </summary>
    /// <param name="user">User to authenticate.</param>
    void Authenticate(User user);
}
namespace Factory.AuthenticationExample;

/// <summary>
/// A user of the system.
/// </summary>
public class User
{
    public bool IsLoggedIn { get; set; }

    public AuthenticationType AuthenticationType { get; set; }
}
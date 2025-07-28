using DesignPatterns.Factory.AuthenticationExample;
using DesignPatterns.Factory.AuthenticationExample.Login;

namespace FactoryTests.AuthenticationExample.Login;

public class LoginServiceTests
{
    private LoginService? loginService;

    [Fact]
    public void Login_WithBiometrics_LogsInSuccessfully()
    {
        loginService = new BiomentricLoginService();

        var user = new User();
        loginService.Login(user);

        Assert.True(user.IsLoggedIn);
        Assert.Equal(AuthenticationType.Biometric, user.AuthenticationType);
    }

    [Fact]
    public void Login_Otp_LogsInSuccessfully()
    {
        loginService = new OtpLoginService();

        var user = new User();
        loginService.Login(user);

        Assert.True(user.IsLoggedIn);
        Assert.Equal(AuthenticationType.OTP, user.AuthenticationType);
    }

    [Fact]
    public void Login_SecurityQuestion_LogsInSuccessfully()
    {
        loginService = new SecurityQuestionLoginService();

        var user = new User();
        loginService.Login(user);

        Assert.True(user.IsLoggedIn);
        Assert.Equal(AuthenticationType.SecurityQuestion, user.AuthenticationType);
    }
}

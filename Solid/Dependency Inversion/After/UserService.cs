namespace Solid.Dependency_Inversion.After;

public class UserService(IEmailService emailService)
{
    private readonly IEmailService _emailService = emailService;

    public void RegisterUser()
    {
        _emailService.SendEmail("Welcome!");
    }
}

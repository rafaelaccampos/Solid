namespace Solid.Dependency_Inversion.Before;

public class UserService
{
    private readonly EmailService _emailService;

    public UserService()
    {
        _emailService = new EmailService();
    }

    public void RegisterUser()
    {
        _emailService.SendEmail("Welcome!");
    }
}

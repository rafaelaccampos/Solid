namespace Solid.Dependency_Inversion.Before;

public class UserService
{
    private readonly EmailService _emailService = new();

    public void RegisterUser()
    {
        _emailService.SendEmail("Welcome!");
    }
}

namespace Solid.Dependency_Inversion.After;

public class EmailService : IEmailService
{
    public string SendEmail(string message)
    {
        return message;
    }
}

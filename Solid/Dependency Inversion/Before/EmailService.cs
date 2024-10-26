namespace Solid.Dependency_Inversion.Before;

public class EmailService
{
    public string SendEmail(string message)
    {
        return message;
    }
}

namespace Solid.Dependency_Inversion.After
{
    public class UserService
    {
        private readonly EmailService _emailService;

        public UserService(EmailService emailService)
        {
            _emailService = emailService; // Injeta a dependência através do construtor
        }

        public void RegisterUser()
        {
            _emailService.SendEmail("Welcome!");
        }
    }
}

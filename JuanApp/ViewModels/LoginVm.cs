namespace JuanApp.ViewModels
{
    public class LoginVm
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberConfirmed { get; set; }
        public string EmailConfirmed { get; set; }
    }
}

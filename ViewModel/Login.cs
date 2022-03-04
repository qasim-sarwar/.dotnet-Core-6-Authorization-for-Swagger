using System.ComponentModel.DataAnnotations;

namespace Authorization_for_Swagger.ViewModel
{
    public class Login
    {
        [Required]
        [EmailAddress]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

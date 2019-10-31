using System.ComponentModel.DataAnnotations;


namespace MusicStore.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

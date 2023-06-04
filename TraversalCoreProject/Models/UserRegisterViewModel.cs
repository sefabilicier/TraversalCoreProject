using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Please enter your namen")]
		public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your surname")]
        public string Surname { get; set; }
        
        [Required(ErrorMessage = "Please enter your username")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Please enter your mail")]
        public string Mail { get; set; }
        
        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter your password again")] //gerekli, error anında dondurelecek mesaj
        [Compare("Password", ErrorMessage = "The passwords do not match")] //şifre ile karşılaştır
        public string ConfirmPassword { get; set; }
    }
}

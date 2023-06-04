using Microsoft.AspNetCore.Http;

namespace TraversalCoreProject.Areas.Member.Models
{
    public class UserEditViewModel 
    {
        public string Name { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
        public string ConfirmPassword { get; set; }
        public string phoneNumber { get; set; }
        public string mail { get; set; }
        public IFormFile image { get; set; }
        public string imageurl { get; set; }
    }
}

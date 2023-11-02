using Microsoft.AspNetCore.Identity;

namespace DadJokes.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }

    }
}

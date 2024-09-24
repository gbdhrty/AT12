using Microsoft.AspNetCore.Identity;

namespace AT12.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
    }
}

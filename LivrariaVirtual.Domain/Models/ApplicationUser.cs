using Microsoft.AspNet.Identity.EntityFramework;

namespace LivrariaVirtual.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Cliente Cliente { get; set; }
    }

}

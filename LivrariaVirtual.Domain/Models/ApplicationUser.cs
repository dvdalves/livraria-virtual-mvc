using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaVirtual.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Cliente Cliente { get; set; }
    }

}

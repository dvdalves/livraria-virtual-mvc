using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaVirtual.Domain.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        // Chave estrangeira para o usuário do Identity
        public string ApplicationUserId { get; set; }

        // Navegação para o usuário
        public ApplicationUser ApplicationUser { get; set; }

        // Outras propriedades do cliente, como Nome, Endereço, etc.
        public string Nome { get; set; }
        //... demais campos
    }

}

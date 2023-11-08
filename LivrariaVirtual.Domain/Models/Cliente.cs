namespace LivrariaVirtual.Domain.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public string Nome { get; set; }
    }
}

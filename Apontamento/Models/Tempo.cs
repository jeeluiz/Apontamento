using Microsoft.AspNetCore.Identity;

namespace Apontamento.Models
{
    public class Tempo
    {
        public Guid Id { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Fim { get; set; }
        public String Descricao { get; set; }
    }
}

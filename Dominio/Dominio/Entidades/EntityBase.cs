using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Dominio.Entidades
{
    public class EntityBase
    {
        [Key]
        public int? Codigo { get; set; }
    }
}

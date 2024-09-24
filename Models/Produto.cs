using System.ComponentModel.DataAnnotations.Schema;

namespace AT4.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public double Preco { get; set; }
    }
}

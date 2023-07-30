using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace LEKSupply.Models
{
    public class Movimentar
    {
        [Required(ErrorMessage = "Quantidade é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Valor inválido")]
        [Display(Name = "Quantidade")]
        [Column("Quantidade")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Local é obrigatório")]
        [Display(Name = "Local")]
        [Column("Local")]
        public string? Local { get; set; }

        [Required(ErrorMessage = "Mercadoria é obrigatório")]
        [Display(Name = "Mercadorias")]
        [Column("IdMercadoria")]
        public int IdMercadoria { get; set; }

        public List<Mercadoria>? Mercadorias { get; set; }
    }


   
}

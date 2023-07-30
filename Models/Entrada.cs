using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace LEKSupply.Models
{
    [Table("Entrada")]
    public class Entrada
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Quantidade é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Valor inválido")]
        [Display(Name = "Quantidade")]
        [Column("Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Data")]
        [Column("Data")]
        public string? Data { get; set; }

        [Display(Name = "Local")]
        [Column("Local")]
        public string Local { get; set; } = "";

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string? Nome { get; set; }

        [Display(Name = "Status")]
        [Column("Status")]
        public string? Status { get; set; } = "A";

        [Display(Name = "IdMercadoria")]
        [Column("IdMercadoria")]
        public int IdMercadoria { get; set; }

    }

}

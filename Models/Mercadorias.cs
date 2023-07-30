using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using static LEKSupply.configHost;

namespace LEKSupply.Models
{
    [Table("Mercadoria")]
    public class Mercadoria
    {

        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Código")]
        [Column("Codigo")]
        public string? Codigo { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome")]
        [Column("Nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Fabricante é obrigatório")]
        [Display(Name = "Fabricante")]
        [Column("Fabricante")]
        public string? Fabricante { get; set; }

        [Required(ErrorMessage = "Tipo é obrigatório")]
        [Display(Name = "Tipo")]
        [Column("Tipo")]
        public string? Tipo { get; set; }

        [Display(Name = "Status")]
        [Column("Status")]
        public string? Status { get; set; } = "A";

        [Required(ErrorMessage = "Descrição é obrigatório")]
        [Display(Name = "Descrição")]
        [Column("Descricao")]
        public string? Descricao { get; set; }

    }

    public class CriarMercadoria
    {
        public Mercadoria Mercadoria { get; set; }
        public List<TiposMercadoria> Tipos { get; set; }
    }
}

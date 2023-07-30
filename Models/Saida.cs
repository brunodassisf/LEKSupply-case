using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LEKSupply.Models
{
    [Table("Saida")]
    public class Saida
    {
        [Display(Name = "Codigo")]
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
        public string Local { get; set; }  
        
        [Display(Name = "Nome")]
        [Column("Nome")]
        public string? Nome { get; set; }

        [Display(Name = "Status")]
        [Column("Status")]
        public string? Status { get; set; } = "A";

        [Display(Name = "IdEntrada")]
        [Column("IdEntrada")]
        public int IdEntrada { get; set; }

        [Display(Name = "IdMercadoria")]
        [Column("IdMercadoria")]
        public int? IdMercadoria { get; set; }
    }

    public class NovaSaida
    {
        public Saida Saida { get; set; }

        public List<Mercadoria> Mercadorias { get; set; }
        
    }  
    
    public class EditarSaida
    {
        public Saida Saida { get; set; }

        public Entrada Entrada { get; set; }
        
    }

}

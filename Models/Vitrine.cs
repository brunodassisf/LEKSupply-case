using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace LEKSupply.Models
{
    public class Vitrine
    {

        public int Id { get; set; }

        public int IdEntrada { get; set; }

        public int IdMercadoria { get; set; }

        public int Quantidade { get; set; }

        public List<VitrineMercadoria> Mercadorias { get; set; }
    }

    public class VitrineMercadoria
    {
        public int Id { get; set; }

        public int Quantidade { get; set; }

        public string? Codigo { get; set; }

        public string? Nome { get; set; }

        public string? Fabricante { get; set; }

        public string? Tipo { get; set; }

        public string? Status { get; set; }

        public string? Descricao { get; set; }

        public List<Entrada> Entrada { get; set; }

    }

}


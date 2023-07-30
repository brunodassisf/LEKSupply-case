using System.Reflection.Emit;

namespace LEKSupply.Models
{
    public class Home
    {
        public List<Entrada> Entradas { get; set; }
        public List<Mercadoria> Mercadorias { get; set; }
        public List<Saida> Saidas { get; set; }
    }

    public class Listas
    {
        public string[]? Label { get; set; }
        public int[]? Data { get; set; }

        public Listas()
        {
            Label = Array.Empty<string>();
            Data = Array.Empty<int>();
        }

    }

    public class DashboardListas
    {
        public Listas PorMes { get; set; }
        public Listas PorMercadoria { get; set; }

        public DashboardListas()
        {
            this.PorMes = new Listas();
            this.PorMercadoria = new Listas();
        }
    }

    public class CountMercadoriasRetorno
    {
        public List<int>? Data { get; set; }
        public List<string>? Label { get; set; }

    }

}

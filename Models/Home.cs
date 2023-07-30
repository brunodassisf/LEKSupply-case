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
        public string[]? label { get; set; }
        public int[]? data { get; set; }

    }

    public class RetornoLista
    {
        public List<int>? data { get; set; }
        public List<string>? label { get; set; }

    }

}

using LEKSupply.Context;
using LEKSupply.Models;
using System;

namespace LEKSupply
{
    public class configHost
    {
        public static string validarEntrada(string texto = "")
        {
            texto = texto.Replace("'", "");
            return texto;
        }

        public static string formatarData(string data = "")
        {
            data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return data;
        }

        public static string formatarDataGrid(string data = "")
        {
            data = Convert.ToDateTime(data).ToString("dd/MM/yyyy HH:mm");
            return data;
        }

        public static Movimentar preencherDados(LEKSupplyDbContext _context = null)
        {
            var _entradaRoot = new Movimentar();

            var _mercadoria = new List<Mercadoria>();

            _mercadoria = _context.Mercadoria.Where(m => m.Status != "X").ToList();

            _entradaRoot.Mercadorias = _mercadoria;

            return _entradaRoot;
        }

        public static string statusGrid(string _status = "")
        {
            switch (_status)
            {
                case "A":
                    _status = "Ativo";
                    break;
                case "I":
                    _status = "Inativo";
                    break;
                case "X":
                    _status = "Deletado";
                    break;
            }
            return _status;
        }

        public class Endereco
        {
            public string Nome { get; set; }
            public string Sigla { get; set; }

            public Endereco(string nome, string sigla)
            {
                Nome = nome;
                Sigla = sigla;
            }
        }

        public static List<Endereco> listaEnderecos()
        {

            var lista = new List<Endereco>();

            lista.Add(new Endereco("Acre", "AC"));
            lista.Add(new Endereco("Alagoas", "AL"));
            lista.Add(new Endereco("Amapá", "AP"));
            lista.Add(new Endereco("Amazonas", "AM"));
            lista.Add(new Endereco("Bahia", "BA"));
            lista.Add(new Endereco("Ceará", "CE"));
            lista.Add(new Endereco("Distrito Federal", "DF"));
            lista.Add(new Endereco("Espírito Santo", "ES"));
            lista.Add(new Endereco("Goiás", "GO"));
            lista.Add(new Endereco("Maranhão", "MA"));
            lista.Add(new Endereco("Mato Grosso", "MT"));
            lista.Add(new Endereco("Mato Grosso do Sul", "MS"));
            lista.Add(new Endereco("Minas Gerais", "MG"));
            lista.Add(new Endereco("Pará", "PA"));
            lista.Add(new Endereco("Paraíba", "PB"));
            lista.Add(new Endereco("Paraná", "PR"));
            lista.Add(new Endereco("Pernambuco", "PE"));
            lista.Add(new Endereco("Piauí", "PI"));
            lista.Add(new Endereco("Rio de Janeiro", "RJ"));
            lista.Add(new Endereco("Rio Grande do Norte", "RN"));
            lista.Add(new Endereco("Rio Grande do Sul", "RS"));
            lista.Add(new Endereco("Rondônia", "RO"));
            lista.Add(new Endereco("Roraima", "RR"));
            lista.Add(new Endereco("Santa Catarina", "SC"));
            lista.Add(new Endereco("São Paulo", "SP"));
            lista.Add(new Endereco("Sergipe", "SE"));
            lista.Add(new Endereco("Tocantins", "TO"));

            return lista;

        }


        public static List<TiposMercadoria> listaTiposMercadorias()
        {
            var lista = new List<TiposMercadoria>();

            lista.Add(new TiposMercadoria("Roupas"));
            lista.Add(new TiposMercadoria("Eletrônicos"));
            lista.Add(new TiposMercadoria("Brinquedos"));
            lista.Add(new TiposMercadoria("Alimentos"));
            lista.Add(new TiposMercadoria("Materiais de construção"));

            return lista;

        }

        public class TiposMercadoria
        {
            public string tipo { get; set; }

            public TiposMercadoria(string tipo)
            {
                this.tipo = tipo;
            }


        }
    }


}

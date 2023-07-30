using DocumentFormat.OpenXml.Office2010.Excel;
using LEKSupply.Context;
using LEKSupply.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Net.Mime;

namespace LEKSupply.Controllers
{
    public class HomeController : Controller

    {
        private readonly LEKSupplyDbContext _context;

        public HomeController(LEKSupplyDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {

            var _listasHome = new Home();

            _listasHome.Mercadorias = _context.Mercadoria.ToList();
            _listasHome.Entradas = _context.Entrada.ToList();
            _listasHome.Saidas = _context.Saida.ToList();


            return View(_listasHome);
        }

        [HttpGet("dashboard")]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> PreencherDashbord()
        {
            try
            {
                var _listasHome = new Home();
                var _entradas = await ListarEntradasDashboard(_listasHome);
                var _saida = await ListarSaidasDashboard(_listasHome);
                var _mercadorias = await ListarMercadoriasDashboard(_listasHome);

                var retornoAPI = new Dictionary<string, RetornoLista>();

                List<int> dataListEntrada = _entradas.data.ToList();
                List<string> labelListEntrada = _entradas.label.ToList();
                List<int> dataListSaida = _saida.data.ToList();
                List<string> labelListSaida = _saida.label.ToList();
                List<int> dataListMercadoria = _mercadorias.data.ToList();
                List<string> labelListMercadoria = _mercadorias.label.ToList();

                retornoAPI["entrada"] = new RetornoLista
                {
                    data = dataListEntrada,
                    label = labelListEntrada
                };
                retornoAPI["saida"] = new RetornoLista
                {
                    data = dataListSaida,
                    label = labelListSaida
                };
                retornoAPI["mercadoria"] = new RetornoLista
                {
                    data = dataListMercadoria,
                    label = labelListMercadoria
                };

                return new JsonResult(retornoAPI);
            }
            catch
            {
                return NotFound(new { StatusCode = 400, Descricao = "Erro na operação." });
            }
        }

        public async Task<Listas> ListarEntradasDashboard(Home _listasHome)
        {
            var _lista = new Listas();
            _listasHome.Entradas = await _context.Entrada.ToListAsync();
            Dictionary<string, int> entradasAgrupadas = new Dictionary<string, int>();

            foreach (var e in _listasHome.Entradas)
            {
                if (entradasAgrupadas.ContainsKey(e.Local))
                {
                    entradasAgrupadas[e.Local] += e.Quantidade;
                }
                else
                {
                    entradasAgrupadas.Add(e.Local, e.Quantidade);
                }
            }
            _lista.label = entradasAgrupadas.Keys.ToArray();
            _lista.data = entradasAgrupadas.Values.ToArray();

            return _lista;
        }

        public async Task<Listas> ListarSaidasDashboard(Home _listasHome)
        {
            var _lista = new Listas();
            _listasHome.Saidas = await _context.Saida.ToListAsync();
            Dictionary<string, int> saidaAgrupadas = new Dictionary<string, int>();

            foreach (var e in _listasHome.Saidas)
            {
                if (saidaAgrupadas.ContainsKey(e.Local))
                {
                    saidaAgrupadas[e.Local] += e.Quantidade;
                }
                else
                {
                    saidaAgrupadas.Add(e.Local, e.Quantidade);
                }
            }
            _lista.label = saidaAgrupadas.Keys.ToArray();
            _lista.data = saidaAgrupadas.Values.ToArray();

            return _lista;
        }

        public async Task<Listas> ListarMercadoriasDashboard(Home _listasHome)
        {
            var _lista = new Listas();
            _listasHome.Mercadorias = await _context.Mercadoria.ToListAsync();
            Dictionary<string, int> mercadoriasAgrupadas = new Dictionary<string, int>();

            foreach (var e in _listasHome.Mercadorias)
            {
                if (mercadoriasAgrupadas.ContainsKey(e.Tipo))
                {
                    mercadoriasAgrupadas[e.Tipo] += 1;
                }
                else
                {
                    mercadoriasAgrupadas.Add(e.Tipo, 1);
                }
            }
            _lista.label = mercadoriasAgrupadas.Keys.ToArray();
            _lista.data = mercadoriasAgrupadas.Values.ToArray();

            return _lista;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
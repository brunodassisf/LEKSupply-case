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
                var _saida = await ListarSaidaDashboard(_listasHome);
                var _mercadorias = await ListarMercadoriasDashboard(_listasHome);

                var retornoDashboard = new Dictionary<string, object>();

                Listas ListEntradaMercadorias = _entradas.PorMercadoria;
                Listas ListEntradaMes = _entradas.PorMes;  

                Listas ListSaidaMercadorias = _saida.PorMercadoria;
                Listas ListSaidaMes = _saida.PorMes;

                List<int> dataListMercadoria = _mercadorias.Data.ToList();
                List<string> labelListMercadoria = _mercadorias.Label.ToList();

                retornoDashboard["entrada"] = new DashboardListas
                {
                    PorMes = ListEntradaMes,
                    PorMercadoria = ListEntradaMercadorias
                };  
                retornoDashboard["saida"] = new DashboardListas
                {
                    PorMes = ListSaidaMes,
                    PorMercadoria = ListSaidaMercadorias
                };
                retornoDashboard["mercadoria"] = new CountMercadoriasRetorno
                {
                    Data = dataListMercadoria,
                    Label = labelListMercadoria
                };

                return new JsonResult(retornoDashboard);
            }
            catch
            {
                return NotFound(new { StatusCode = 400, Descricao = "Erro na operação." });
            }
        }

        public async Task<DashboardListas> ListarEntradasDashboard(Home _listasHome)
        {
            var _listaPorMercadoria = new Listas();
            var _listaPorMes = new Listas();
            var _dashboardLista = new DashboardListas();

            _listasHome.Entradas = await _context.Entrada.ToListAsync();

            Dictionary<string, int> entradasAgrupadasPorMes = new Dictionary<string, int>();
            Dictionary<string, int> entradasAgrupadasPorMercadoria = new Dictionary<string, int>();

            foreach (var e in _listasHome.Entradas)
            {
                DateTime data = DateTime.Parse(e.Data);
                int _mes = data.Month;
                string _mesExtenso = configHost.ObterNomeMesPorExtenso(_mes);

                if (entradasAgrupadasPorMes.ContainsKey(_mesExtenso))
                {
                    entradasAgrupadasPorMes[_mesExtenso] += e.Quantidade;

                }
                else
                {
                    entradasAgrupadasPorMes.Add(_mesExtenso, e.Quantidade);
                }

                if (entradasAgrupadasPorMercadoria.ContainsKey(e.Nome))
                {
                    entradasAgrupadasPorMercadoria[e.Nome] += e.Quantidade;

                }
                else
                {
                    entradasAgrupadasPorMercadoria.Add(e.Nome, e.Quantidade);
                }

            }

            _listaPorMercadoria.Label = entradasAgrupadasPorMercadoria.Keys.ToArray();
            _listaPorMercadoria.Data = entradasAgrupadasPorMercadoria.Values.ToArray();
            _listaPorMes.Label = entradasAgrupadasPorMes.Keys.ToArray();
            _listaPorMes.Data = entradasAgrupadasPorMes.Values.ToArray();

            _dashboardLista.PorMes = _listaPorMes;
            _dashboardLista.PorMercadoria = _listaPorMercadoria;

            return _dashboardLista;
        } 
        
        public async Task<DashboardListas> ListarSaidaDashboard(Home _listasHome)
        {
            var _listaPorMercadoria = new Listas();
            var _listaPorMes = new Listas();
            var _dashboardLista = new DashboardListas();

            _listasHome.Saidas = await _context.Saida.ToListAsync();

            Dictionary<string, int> saidasAgrupadasPorMes = new Dictionary<string, int>();
            Dictionary<string, int> saidasAgrupadasPorMercadoria = new Dictionary<string, int>();

            foreach (var e in _listasHome.Saidas)
            {
                DateTime data = DateTime.Parse(e.Data);
                int _mes = data.Month;
                string _mesExtenso = configHost.ObterNomeMesPorExtenso(_mes);

                if (saidasAgrupadasPorMes.ContainsKey(_mesExtenso))
                {
                    saidasAgrupadasPorMes[_mesExtenso] += e.Quantidade;

                }
                else
                {
                    saidasAgrupadasPorMes.Add(_mesExtenso, e.Quantidade);
                }

                if (saidasAgrupadasPorMercadoria.ContainsKey(e.Nome))
                {
                    saidasAgrupadasPorMercadoria[e.Nome] += e.Quantidade;

                }
                else
                {
                    saidasAgrupadasPorMercadoria.Add(e.Nome, e.Quantidade);
                }

            }

            _listaPorMercadoria.Label = saidasAgrupadasPorMercadoria.Keys.ToArray();
            _listaPorMercadoria.Data = saidasAgrupadasPorMercadoria.Values.ToArray();
            _listaPorMes.Label = saidasAgrupadasPorMes.Keys.ToArray();
            _listaPorMes.Data = saidasAgrupadasPorMes.Values.ToArray();

            _dashboardLista.PorMes = _listaPorMes;
            _dashboardLista.PorMercadoria = _listaPorMercadoria;

            return _dashboardLista;
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
            _lista.Data = mercadoriasAgrupadas.Values.ToArray();
            _lista.Label = mercadoriasAgrupadas.Keys.ToArray();

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
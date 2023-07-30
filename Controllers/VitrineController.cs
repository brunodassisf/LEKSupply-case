using LEKSupply.Context;
using LEKSupply.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LEKSupply.Controllers
{
    public class VitrineController : Controller
    {

        private readonly LEKSupplyDbContext _context;

        public VitrineController(LEKSupplyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var _vitrine = new Vitrine();
            var _vitrinerM = new List<VitrineMercadoria>();

            var Mercadorias = await _context.Mercadoria.Where(item => item.Status == "A").ToListAsync();
            var Entrada = await _context.Entrada.Where(item => item.Status == "A").ToListAsync();

            foreach (var m in Mercadorias)
            {

                _vitrinerM.Add(new VitrineMercadoria
                {
                    Codigo = m.Codigo,
                    Descricao = m.Descricao,
                    Fabricante = m.Fabricante,
                    Id = m.Id,
                    Nome = m.Nome,
                    Status = m.Status,
                    Tipo = m.Tipo,
                    Entrada = Entrada.FindAll(item => item.IdMercadoria == m.Id)

                });
            }
            _vitrine.Mercadorias = _vitrinerM;

            return View(_vitrine);
        }
    }
}

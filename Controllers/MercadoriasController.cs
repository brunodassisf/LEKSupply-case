using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LEKSupply.Context;
using LEKSupply.Models;
using OfficeOpenXml;

namespace LEKSupply.Controllers
{
    public class MercadoriasController : Controller
    {
        private readonly LEKSupplyDbContext _context;

        public MercadoriasController(LEKSupplyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
              return _context.Mercadoria != null ? 
                          View(await _context.Mercadoria.ToListAsync()) :
                          Problem("Entity set 'LEKSupplyDbContext.Mercadoria'  is null.");
        }

        public async Task<IActionResult> Detalhe(int? id)
        {
            if (id == null || _context.Mercadoria == null)
            {
                return NotFound();
            }

            var mercadoria = await _context.Mercadoria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mercadoria == null)
            {
                return NotFound();
            }

            return View(mercadoria);
        }

        public IActionResult Cadastrar()
        {
            var _criarMercadoria = new CriarMercadoria();
            _criarMercadoria.Mercadoria = new Mercadoria();
            _criarMercadoria.Tipos = configHost.listaTiposMercadorias();


            return View(_criarMercadoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastrar([Bind("Id,Codigo,Nome,Fabricante,Tipo,Descricao")] Mercadoria mercadoria)
        {
           if (ModelState.IsValid)
           {
                mercadoria.Codigo =  Guid.NewGuid().ToString();
                mercadoria.Descricao = configHost.validarEntrada(mercadoria.Descricao);
                mercadoria.Fabricante = configHost.validarEntrada(mercadoria.Fabricante);
                mercadoria.Nome = configHost.validarEntrada(mercadoria.Nome);
                mercadoria.Tipo = configHost.validarEntrada(mercadoria.Tipo);
                mercadoria.Status = "A";

               _context.Add(mercadoria);
               await _context.SaveChangesAsync();
               return RedirectToAction(nameof(Index));
           }
           return Redirect("/Mercadorias");
        }

        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null || _context.Mercadoria == null)
            {
                return NotFound();
            }

            var mercadoria = await _context.Mercadoria.FindAsync(id);
            if (mercadoria == null)
            {
                return NotFound();
            }
            return View(mercadoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Nome,Fabricante,Tipo,Descricao,Status")] Mercadoria mercadoria)
        {
            if (id != mercadoria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mercadoria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MercadoriaExists(mercadoria.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(mercadoria);
        }

        public async Task<IActionResult> Deletar(int? id)
        {
            if (id == null || _context.Mercadoria == null)
            {
                return NotFound();
            }

            var mercadoria = await _context.Mercadoria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mercadoria == null)
            {
                return NotFound();
            }

            return View(mercadoria);
        }

        [HttpPost, ActionName("Deletar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmarDelete(int id)
        {
            if (_context.Mercadoria == null)
            {
                return Problem("Entity set 'LEKSupplyDbContext.Mercadoria'  is null.");
            }
            var mercadoria = await _context.Mercadoria.FindAsync(id);

            if (mercadoria != null)
            {
                mercadoria.Status = "X";
                _context.Mercadoria.Update(mercadoria);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MercadoriaExists(int id)
        {
          return (_context.Mercadoria?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpPost]
        public async Task<FileResult> ExportarParaExcelMercadorias()
        {
            List<Mercadoria> dadosRelatorio = await _context.Mercadoria.ToListAsync();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Relatorio");

                worksheet.Cells[1, 1].Value = "Id";
                worksheet.Cells[1, 2].Value = "Codigo";
                worksheet.Cells[1, 3].Value = "Nome";
                worksheet.Cells[1, 4].Value = "Descricao";
                worksheet.Cells[1, 5].Value = "Fabricante";
                worksheet.Cells[1, 6].Value = "Tipo";
                worksheet.Cells[1, 7].Value = "Status";

                int linhaAtual = 2;
                foreach (var item in dadosRelatorio)
                {
                    worksheet.Cells[linhaAtual, 1].Value = item.Id;
                    worksheet.Cells[linhaAtual, 2].Value = item.Codigo;
                    worksheet.Cells[linhaAtual, 3].Value = item.Nome;
                    worksheet.Cells[linhaAtual, 4].Value = item.Descricao;
                    worksheet.Cells[linhaAtual, 5].Value = item.Fabricante;
                    worksheet.Cells[linhaAtual, 6].Value = item.Tipo;
                    worksheet.Cells[linhaAtual, 7].Value = configHost.statusGrid(item.Status);
                    linhaAtual++;
                }

                MemoryStream stream = new MemoryStream(package.GetAsByteArray());

                string nomeArquivo = $"mercadoria_{Guid.NewGuid()}.xlsx";

                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
            }
        }
    }
}

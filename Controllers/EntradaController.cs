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
    public class EntradaController : Controller
    {
        private readonly LEKSupplyDbContext _context;

        public EntradaController(LEKSupplyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return _context.Entrada != null ?
                        View(await _context.Entrada.ToListAsync()) :
                        Problem("Entity set 'LEKSupplyDbContext.Entrada'  is null.");
        }

        public async Task<IActionResult> Detalhe(int? id)
        {
            if (id == null || _context.Entrada == null)
            {
                return NotFound();
            }

            var entrada = await _context.Entrada
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entrada == null)
            {
                return NotFound();
            }

            return View(entrada);
        }

        public IActionResult Cadastrar()
        {
            var _entradaRoot = configHost.preencherDados(_context);
            _entradaRoot.IdMercadoria = 0;
            _entradaRoot.Local = "";

            return View(_entradaRoot);
        }     
         
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastrar([Bind("Id,Quantidade,Local,IdMercadoria,Status")] Entrada entrada)
        {
            try
            {
                var _buscarMercadoria = await _context.Mercadoria.FindAsync(entrada.IdMercadoria);

                if (_buscarMercadoria != null && entrada.Quantidade > 0 && entrada.Local != "")
                {
                    entrada.Nome = _buscarMercadoria.Nome;
                    entrada.Status = "A";
                    entrada.Data = configHost.formatarData();
                    entrada.Local = configHost.validarEntrada(entrada.Local);
                    _context.Add(entrada);
                    await _context.SaveChangesAsync();
                    ViewBag.MsgAlert = $"<span>Entrada registrada com sucesso</span>";
                }
                else
                {
                    ViewBag.MsgAlert = "Não foi encontrado a mercadoria.";
                }
            }
            catch (Exception _ex)
            {
                ViewBag.MsgAlert = _ex.Message;
            }
            var _entradaRoot = configHost.preencherDados(_context);
            _entradaRoot.IdMercadoria = 0;
            _entradaRoot.Local = "";

            return View(_entradaRoot);

        }

        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null || _context.Entrada == null)
            {
                return NotFound();
            }

            var entrada = await _context.Entrada.FindAsync(id);
            if (entrada == null)
            {
                return NotFound();
            }

            entrada.Data = configHost.formatarDataGrid(entrada.Data);

            return View(entrada);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Quantidade,Data,Local,Nome,IdMercadoria,Status")] Entrada entrada)
        {
            if (id != entrada.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entrada);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntradaExists(entrada.Id))
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
            return View(entrada);
        }

        public async Task<IActionResult> Deletar(int? id)
        {
            if (id == null || _context.Entrada == null)
            {
                return NotFound();
            }

            var entrada = await _context.Entrada
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entrada == null)
            {
                return NotFound();
            }

            return View(entrada);
        }

        [HttpPost, ActionName("Deletar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Entrada == null)
            {
                return Problem("Entity set 'LEKSupplyDbContext.Entrada'  is null.");
            }
            var entrada = await _context.Entrada.FindAsync(id);
            if (entrada != null)
            {
                entrada.Status = "X";
                _context.Entrada.Update(entrada);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntradaExists(int id)
        {
            return (_context.Entrada?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        public async Task<FileResult> ExportarParaExcelEntrada()
        {
            List<Entrada> dadosRelatorio = await _context.Entrada.ToListAsync();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Relatorio");

                worksheet.Cells[1, 1].Value = "Id";
                worksheet.Cells[1, 2].Value = "Nome";
                worksheet.Cells[1, 3].Value = "Local";
                worksheet.Cells[1, 4].Value = "Quantidade";
                worksheet.Cells[1, 5].Value = "Data";
                worksheet.Cells[1, 6].Value = "Status";

                int linhaAtual = 2;
                foreach (var item in dadosRelatorio)
                {
                    worksheet.Cells[linhaAtual, 1].Value = item.Id;
                    worksheet.Cells[linhaAtual, 2].Value = item.Nome;
                    worksheet.Cells[linhaAtual, 3].Value = item.Local;
                    worksheet.Cells[linhaAtual, 4].Value = item.Quantidade;
                    worksheet.Cells[linhaAtual, 5].Value = item.Data;
                    worksheet.Cells[linhaAtual, 6].Value = configHost.statusGrid(item.Status);
                    linhaAtual++;
                }

                MemoryStream stream = new MemoryStream(package.GetAsByteArray());

                string nomeArquivo = $"entrada_{Guid.NewGuid()}.xlsx";

                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LEKSupply.Context;
using LEKSupply.Models;
using System.Net.Mime;
using OfficeOpenXml;

namespace LEKSupply.Controllers
{
    public class SaidaController : Controller
    {
        private readonly LEKSupplyDbContext _context;

        public SaidaController(LEKSupplyDbContext context)
        {
            _context = context;
        }

        public NovaSaida ViewDadosNovaSaida()
        {
            var _novaSaida = new NovaSaida();
            var _mercadorias = new List<Mercadoria>();
            _mercadorias = _context.Mercadoria.Where(item => item.Status == "A").ToList();
            var _saida = new Saida();
            _novaSaida.Saida = _saida;
            _novaSaida.Mercadorias = _mercadorias;
            return _novaSaida;
        }

        public async Task<IActionResult> Index()
        {
            return _context.Saida != null ?
                        View(await _context.Saida.ToListAsync()) :
                        Problem("Entity set 'LEKSupplyDbContext.Saida'  is null.");
        }

        public async Task<IActionResult> Detalhe(int? id)
        {
            if (id == null || _context.Saida == null)
            {
                return NotFound();
            }

            var saida = await _context.Saida
                .FirstOrDefaultAsync(m => m.Id == id);
            if (saida == null)
            {
                return NotFound();
            }

            return View(saida);
        }

        public IActionResult Cadastrar()
        {
            return View(ViewDadosNovaSaida());
        }

        [HttpGet("buscar-entrada/{IdMercadoria}")]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> PreencherCombo(int IdMercadoria = 0)
        {
            try
            {
                var _entrada = new List<Entrada>();

                _entrada = await _context.Entrada.Where(item => item.Status == "A" && item.IdMercadoria == IdMercadoria).ToListAsync();

                return new JsonResult(_entrada);
            }
            catch
            {
                return NotFound(new { StatusCode = 400, Descricao = "Erro na operação." });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastrar([Bind("Id,Quantidade,IdMercadoria,IdEntrada")] Saida saida)
        {
            try
            {
                var _buscarMercadoria = await _context.Mercadoria.FindAsync(saida.IdMercadoria);
                var _buscarEntrada = await _context.Entrada.FindAsync(saida.IdEntrada);

                if (_buscarMercadoria != null && _buscarEntrada != null && _buscarEntrada.Quantidade >= saida.Quantidade)
                {
                    saida.Local = _buscarEntrada.Local;
                    saida.Nome = _buscarMercadoria.Nome;
                    saida.Data = configHost.formatarData();
                    await AtualizarEstoque(_buscarEntrada, saida);
                }
                else
                {
                    ViewBag.MsgAlert = "Não foi possivel cadastrar uma saida no momento, tentar novamente mais tarde";
                }
            }
            catch (Exception _ex)
            {
                ViewBag.MsgAlert = _ex.Message;
            }
            return View(ViewDadosNovaSaida());
        }

        private async Task<IActionResult> AtualizarEstoque(Entrada entrada, Saida saida)
        {
            try
            {
                entrada.Quantidade -= saida.Quantidade;
                _context.Update(entrada);
                _context.Add(saida);
                await _context.SaveChangesAsync();
                ViewBag.MsgAlert = $"Saida de {saida.Quantidade} {saida.Nome} para o {saida.Local} foi realizada com sucesso!";
            }
            catch (Exception _ex)
            {
                ViewBag.MsgAlert = _ex.Message;
            }
            return View();
        }

        public EditarSaida PreencherViewEditarSaida(Saida saida)
        {
            var _editarSaida = new EditarSaida();
            saida.Data = configHost.formatarDataGrid(saida.Data);
            var _buscarEntrada =  _context.Entrada.Find(saida.IdEntrada);

            _editarSaida.Saida = saida;
            _editarSaida.Entrada = _buscarEntrada;
            return _editarSaida;
        }

        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null || _context.Saida == null)
            {
                return NotFound();
            }

            var _editarSaida = new EditarSaida();

            var saida = await _context.Saida.FindAsync(id);

            if (saida == null)
            {
                return NotFound();
            }

            saida.Data = configHost.formatarDataGrid(saida.Data);
            var _buscarEntrada = await _context.Entrada.FindAsync(saida.IdEntrada);

            _editarSaida.Saida = saida;
            _editarSaida.Entrada = _buscarEntrada;


            return View(_editarSaida);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Quantidade,IdEntrada,Data,Nome,Local,Status,IdMercadoria")] Saida saida)
        {
            var _returnSaida = new Saida();

            if (id != saida.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var _buscarSaida = await _context.Saida.FindAsync(saida.Id);
                    var _buscarEntrada = await _context.Entrada.FindAsync(saida.IdEntrada);

                    if (saida.Quantidade != _buscarSaida.Quantidade)
                    {
                        var _calc = 0;

                        if (saida.Quantidade > _buscarSaida.Quantidade)
                        {
                            _calc = saida.Quantidade - _buscarSaida.Quantidade;
                            _buscarEntrada.Quantidade -= _calc;                         

                        } else
                        {
                            _calc = _buscarSaida.Quantidade - saida.Quantidade;
                            _buscarEntrada.Quantidade += _calc;

                        }

                        _buscarSaida.Quantidade = saida.Quantidade;
                        _buscarSaida.Data = configHost.formatarData();
                        _returnSaida = saida;

                        _context.Update(_buscarSaida);
                        _context.Update(_buscarEntrada);
                        await _context.SaveChangesAsync();

                    }

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaidaExists(saida.Id))
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
            return View(PreencherViewEditarSaida(_returnSaida));
        }

        public async Task<IActionResult> Deletar(int? id)
        {
            if (id == null || _context.Saida == null)
            {
                return NotFound();
            }

            var saida = await _context.Saida
                .FirstOrDefaultAsync(m => m.Id == id);
            if (saida == null)
            {
                return NotFound();
            }

            return View(saida);
        }

        [HttpPost, ActionName("Deletar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Saida == null)
            {
                return Problem("Entity set 'LEKSupplyDbContext.Saida'  is null.");
            }
            var saida = await _context.Saida.FindAsync(id);
            if (saida != null)
            {
                _context.Saida.Remove(saida);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaidaExists(int id)
        {
            return (_context.Saida?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        public async Task<FileResult> ExportarParaExcelSaida()
        {
            List<Saida> dadosRelatorio = await _context.Saida.ToListAsync();

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
                    worksheet.Cells[linhaAtual, 6].Value = item.Status;
                    linhaAtual++;
                }

                MemoryStream stream = new MemoryStream(package.GetAsByteArray());

                string nomeArquivo = $"saida_{Guid.NewGuid()}.xlsx";

                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
            }
        }
    }
}

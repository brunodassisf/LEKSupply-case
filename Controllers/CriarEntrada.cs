
using LEKSupply.Context;
using LEKSupply.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LEKSupply.Controllers
{
    public class CriarEntradaController : Controller
    {

        private readonly LEKSupplyDbContext _context;

        public CriarEntradaController(LEKSupplyDbContext context)
        {
            _context = context;
        }


    }
}

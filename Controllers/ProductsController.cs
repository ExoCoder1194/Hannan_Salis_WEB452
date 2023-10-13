using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLAMP_Assignment1.Models;


namespace CLAMP_Assignment1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ClampContext _context;

        public ProductsController(ClampContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var clamps = _context.Clamps.ToList();
            return View(clamps);
        }
    }
}

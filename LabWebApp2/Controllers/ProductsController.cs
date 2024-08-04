using Microsoft.AspNetCore.Mvc;
using LabWebApp2.Data;
using LabWebApp2.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LabWebApp2.Controllers
{

    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }
    }

}

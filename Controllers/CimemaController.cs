using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CimemaController : Controller
    {

        private readonly AppDbContext _context;

        public CimemaController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Cinemas.ToListAsync();
            return View(data);
        }
    }
}

using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;

        public MovieController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           // var data = _context.Movies.Include(n => n.Cimema).OrderBy(n => n.Name).ToListAsync();
            return View(/*data*/);
        }
    }
}

using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {

        private readonly AppDbContext _context;

        public ActorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()

        {

            Task<List<Actor>> data = _context.Actors.ToListAsync();
            if(data == null )
            {

            }
            return View(data);
        }
    }
}

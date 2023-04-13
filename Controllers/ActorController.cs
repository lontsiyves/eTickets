using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {

        private readonly IActorServices _services;

        public ActorController(IActorServices services)
        {
            _services = services;
        }

        public async Task<IActionResult> Index()

        {
            var data = await _services.GetActors();
            return View(data);
        }
         
        public  async Task<IActionResult> Create(Actor actor)
        {
          //  var data = await _services.Add(actor);

            return View();
        }
    }
}

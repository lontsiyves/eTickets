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

        public async Task<IActionResult> Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,profilePictureURL,Bio")] Actor actor)
        {
             if(!ModelState.IsValid)
                {
                    return View(actor);

                }
             _services.Add(actor);
            return RedirectToAction("Index");
        }

        //Get : Actor/Details/1

        [HttpGet]
        public IActionResult Details(int id)
        {
            var actor = _services.GetById(id);
            if (actor == null) return View("Empty");
            return View(actor);
        }

    }
}

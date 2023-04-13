using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorServices

 
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async  Task<IEnumerable<Actor>> GetActors()
        {
            var res = await _context.Actors.ToListAsync();

            return res;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Updata(int id, Actor actor)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Actor>> IActorServices.GetActors()
        {
            throw new NotImplementedException();
        }
    }
}

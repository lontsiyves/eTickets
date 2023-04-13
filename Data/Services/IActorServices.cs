using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IActorServices
    {
        Task<IEnumerable<Actor>> GetActors();

        Actor GetById(int id);

        void Add(Actor actor);

        void Delete(int id);

        Actor Updata(int id, Actor actor);
    }
}

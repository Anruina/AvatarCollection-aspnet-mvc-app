using eTickets.Models;

namespace eTickets.Data.Services
{
    //get data from DB
    public interface IActorsService
    {
        //read
        Task<IEnumerable<Actor>> GetAll();
        //get by id
        Actor GetById(int id);
        ///create
        void Add(Actor actor);
        //update
        Actor Update(int id, Actor newActor);
        //delete
        void Delete(int id);
    }
}

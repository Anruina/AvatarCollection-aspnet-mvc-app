using AvatarCollections.Models;

namespace AvatarCollections.Data.Services
{
    //get data from DB
    public interface IActorsService
    {
        //read
        Task<IEnumerable<Actor>> GetAllAsync();
        //get by id
        Task<Actor> GetByIdAsync(int id);
        ///create
        Task AddAsync(Actor actor);
        //update
        Task<Actor> UpdateAsync(int id, Actor newActor);
        //delete
        Task DeleteAsync(int id);
    }
}

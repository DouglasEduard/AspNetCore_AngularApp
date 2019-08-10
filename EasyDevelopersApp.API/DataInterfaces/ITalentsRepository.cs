using System.Collections.Generic;
using System.Threading.Tasks;
using EasyDevelopersApp.API.Models;

namespace EasyDevelopersApp.API.Data
{
    public interface ITalentsRepository
    {
         void Add<T>(T entity) where T: class;

         void Delete<T>(T Entity) where T: class;

         Task<bool> SaveAll();

         Task<IEnumerable<User>> GetTalents();

         Task<User> GetTalent(int id);
    }
}
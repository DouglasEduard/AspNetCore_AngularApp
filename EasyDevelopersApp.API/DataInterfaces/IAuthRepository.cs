using System.Threading.Tasks;
using EasyDevelopersApp.API.Models;

namespace EasyDevelopersApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);

         Task<User> Login(string username, string password);

         Task<bool> UserExistis(string username); 
    }
}
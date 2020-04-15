using System.Threading.Tasks;
using DateApp.api.Models;

namespace DateApp.api.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user,string Password);
        Task<User> Login(string user,string Password);
        Task<bool> UserExists(string username);

    }
}
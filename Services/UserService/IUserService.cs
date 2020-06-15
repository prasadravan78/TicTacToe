using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public interface IUserService
    {
        Task<bool> IsUserOnline(string userName);
        Task<bool> RegisterUser(User user);
    }
}
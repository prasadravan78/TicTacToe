using System.Threading.Tasks;

namespace TicTacToe.Services
{
    /// <summary>
    /// Exposes members to manage User entity.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Registers user.
        /// </summary>
        /// <param name="user">user entity</param>
        /// <returns></returns>
        Task<bool> IsUserOnline(string userName);

        /// <summary>
        /// Checks if user is online.
        /// </summary>
        /// <param name="userName">User name</param>
        /// <returns></returns>
        Task<bool> RegisterUser(User user);
    }
}
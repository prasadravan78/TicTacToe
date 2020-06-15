using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public class UserService : IUserService
    {
        public Task<bool> RegisterUser(User user)
        {
            return Task.FromResult(true);
        }

        public Task<bool> IsUserOnline(string userName)
        {
            return Task.FromResult(true);
        }
    }
}

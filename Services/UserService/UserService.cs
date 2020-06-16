using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    /// <summary>
    ///  Provides members to manage User entity.
    /// </summary>
    public class UserService : IUserService
    {
        #region Member Variables

        private bool isDisposed = false;

        #endregion Member Variables

        #region Constructors

        /// <summary>
        /// Initializes service with dependencies.
        /// </summary>
        /// <param name=""></param>
        public UserService()
        { 
        
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Registers user.
        /// </summary>
        /// <param name="user">user entity</param>
        /// <returns></returns>
        public Task<bool> RegisterUser(User user)
        {
            return Task.FromResult(true);
        }

        /// <summary>
        /// Checks if user is online.
        /// </summary>
        /// <param name="userName">User name</param>
        /// <returns></returns>
        public Task<bool> IsUserOnline(string userName)
        {
            return Task.FromResult(true);
        }

        #endregion Public Methods

        #region Private Methods

        #endregion Private Methods

        #region IDisposable Support

        #endregion IDisposable Support
    }
}

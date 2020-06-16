using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Services;
using TicTacToe.ViewModels;

namespace TicTacToe.Controllers
{
    /// <summary>
    /// Provides functionality to display and manage User and its associated functionality.
    /// </summary>
    public class UserController : Controller
    {
        #region Member Variables

        private IUserService _userService;

        #endregion Member Variables

        #region Constructors

        /// <summary>
        /// Initializes various dependencies.
        /// </summary>
        /// <param name=""></param>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Gets Index page for user.
        /// </summary>
        /// <returns>Index page for User.</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Gets user details for display.  
        /// </summary>
        /// <param name="id">User Id</param>
        /// <returns>User Detail view.</returns>
        public IActionResult UserDetails(int id = 0)
        {
            UserViewModel user = new UserViewModel();

            if (id > 0)
            {
                // TO DO Get user from DB
            }
            else
            {
                user.User = new User();
            }

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            await _userService.RegisterUser(user);

            return Content("Success");
        }

        #endregion Public Methods

        #region Private Methods

        #endregion Private Methods
    }
}

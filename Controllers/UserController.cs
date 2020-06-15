using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Services;
using TicTacToe.ViewModels;

namespace TicTacToe.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserDetails(int id=0)
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
    }
}

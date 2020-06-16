using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Services;

namespace TicTacToe.Middleware
{

    public class CommunicationMiddleware
    {
        private readonly RequestDelegate requestDelegate;
        private readonly IUserService userService;

        public CommunicationMiddleware(RequestDelegate _requestDelegate,
                                       IUserService _userService)
        {
            this.requestDelegate = _requestDelegate;
            this.userService = _userService;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await requestDelegate.Invoke(httpContext);
        }
    }
}

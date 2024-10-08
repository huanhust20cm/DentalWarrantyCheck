using Authen.Services.Interface;
using Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace Authen.Api.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices _authService;
        public UserController(IUserServices authService)
        {
            _authService = authService;
        }
        [HttpPost]
        [Route("login")]
        public async Task<bool> Auth(LoginModel loginModel)
        {
            var data = await _authService.AuthServices(loginModel);
            return data;
        }
    }
}

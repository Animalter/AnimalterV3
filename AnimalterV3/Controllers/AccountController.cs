using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Entity.Concrete.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AnimalterV3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        #region Fields
        private readonly IUserService _userService;
        #endregion

        #region Ctor
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        #region Methods
        [HttpPost("Login")]
        public async Task<AccountDto> Login(string UserName, string Password)
        {

            return _userService.Login(UserName, Password);
        }
        #endregion


    }
}

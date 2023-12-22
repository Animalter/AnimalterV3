﻿using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimalterV3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region Fields
        private readonly IUserService _userService;
        #endregion

        #region ctor
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        #region methods
        [HttpGet]
        public async Task<List<UserTbl>> GetAllUser()
        {
            return _userService.Getall();
        }
        [HttpPost]
        public async Task<IUtilityResult> AddUser(UserDto user)
        {
            return _userService.Add(user);
        }
        [HttpPut]
        public async Task<IUtilityResult> updateUser(UserDto user)
        {
            return _userService.Update(user);
        }
        [HttpDelete]
        public async Task<IUtilityResult> deleteUser(UserDto user)
        {
            return _userService.Delete(user);
        }

        #endregion
    }
}

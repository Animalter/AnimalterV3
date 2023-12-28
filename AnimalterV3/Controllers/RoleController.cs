using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimalterV3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        #region Fields
        private readonly IRoleService _roleService;
        #endregion

        #region ctor
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        #endregion

        #region methods
        [HttpGet("GetRoleById")]
        public async Task<RoleTbl> GetRoleById(int Id)
        {
            return _roleService.GetById(Id);
        }
        [HttpGet]
        public async Task<List<RoleTbl>> gettAllRole()
        {
            return _roleService.GetAll();
        }
        [HttpPost]
        public async Task<IUtilityResult> addRole(RoleDto role)
        {
            return _roleService.Add(role);
        }

        [HttpPut]
        public async Task<IUtilityResult> updateRole(RoleDto role)
        {
            return _roleService.Update(role);
        }
        [HttpDelete]
        public async Task<IUtilityResult> deleteRole(int role)
        {
            return _roleService.Delete(role);
        }

        #endregion
    }
}

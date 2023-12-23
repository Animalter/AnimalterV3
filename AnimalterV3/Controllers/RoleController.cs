//using AnimalterV3.Busssines.Abstract;
//using AnimalterV3.Dto;
//using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
//using AnimalterV3.Entity.Concrete;
//using AnimalterV3.Utilities.Abstract;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace AnimalterV3.Controllers
//{
//    [Route("[controller]")]
//    [ApiController]
//    public class RoleController : ControllerBase
//    {
//        #region Fields
//        private readonly IRoleService _roleService;
//        #endregion

//        #region ctor
//        public RoleController(IRoleService roleService)
//        {
//            _roleService = roleService;
//        }
//        #endregion

//        #region methods
//        [HttpGet]
//        public async Task<List<RoleTbl>> gettAllUser() 
//        {
//            return _roleService.GetAll();
//        }
//        [HttpPut]
//        public async Task<IUtilityResult> addUser(RoleDto role) 
//        {
//            return _roleService.Add(role);
//        }

//        [HttpPut]
//        public async Task<IUtilityResult> updateCustomer(RoleDto role)
//        {
//            return _roleService.Update(role);
//        }
//        [HttpDelete]
//        public async Task<IUtilityResult> deleterole(RoleDto role)
//        {
//            return _roleService.Delete(role);
//        }

//        #endregion
//    }
//}

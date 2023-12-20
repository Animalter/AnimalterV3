using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimalterV3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TypeeController : ControllerBase
    {
        #region Fields
        private readonly ITypeeService _typeeService;
        #endregion

        #region ctor
        public TypeeController(ITypeeService typeeService)
        {
            _typeeService = typeeService;
        }
        #endregion

        #region methods

        [HttpGet("GetTypeeById")]
        public async Task<Typee> GetTypeeById(int Id)
        {
            return _typeeService.GetById(Id);
        }
        [HttpGet]
        public async Task<List<Typee>> GetAllTypee()
        {
            return _typeeService.Getall();
        }
        [HttpPost]
        public async Task<IUtilityResult> AddTypee(TypeeDto typeeDto)
        {
            return _typeeService.Add(typeeDto);
        }
        [HttpPut]
        public async Task<IUtilityResult> updateTypee(TypeeDto typeeDto)
        {
            return _typeeService.Update(typeeDto);
        }
        [HttpDelete]
        public async Task<IUtilityResult> deleteTypee(TypeeDto typeeDto)
        {
            return _typeeService.Delete(typeeDto);
        }

        #endregion
    }
}

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
    public class GenusController : ControllerBase
    {
        #region Fields
        private readonly IGenusService _genusService;
        #endregion

        #region ctor
        public GenusController(IGenusService genusService)
        {
            _genusService = genusService;
        }
        #endregion

        #region methods
        [HttpGet("GetGenusById")]
        public async Task<Genus> GetGenusById(int Id)
        {
            return _genusService.GetById(Id);
        }

        [HttpGet]
        public async Task<List<Genus>> GetAllGenus()
        {
            return _genusService.Getall();
        }
        [HttpPost]
        public async Task<IUtilityResult> AddGenus(GenusDto genus)
        {
            return _genusService.Add(genus);
        }
        [HttpPut]
        public async Task<IUtilityResult> updateGenus(GenusDto genus)
        {
            return _genusService.Update(genus);
        }
        [HttpDelete]
        public async Task<IUtilityResult> deleteGenus(int genus)
        {
            return _genusService.Delete(genus);
        }

        #endregion


    }
}

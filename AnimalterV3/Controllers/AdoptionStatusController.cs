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
    public class AdoptionStatusController : ControllerBase
    {
        #region Fields
        private readonly IAdoptionStatusService  _adoptionStatusService;
        #endregion

        #region ctor
        public AdoptionStatusController(IAdoptionStatusService adoptionStatusService)
        {
            _adoptionStatusService = adoptionStatusService;
            
        }

        #endregion

        #region methods
        [HttpGet("GetAdoptionStatusById")]
        public async Task<AdoptionStatus> GetAdoptionStatusById(int Id)
        {
            return _adoptionStatusService.GetById(Id);
        }
        [HttpGet]
        public async Task<List<AdoptionStatus>> GetAllAdoption()
        {
            return _adoptionStatusService.Getall();
        }
        [HttpPost]
        public async Task<IUtilityResult> AddAdoption(AdoptionStatusDto adoptionStatus)
        {
            return _adoptionStatusService.Add(adoptionStatus);
        }
        [HttpPut]
        public async Task<IUtilityResult> updateAdoption(AdoptionStatusDto adoptionStatus)
        {
            return _adoptionStatusService.Update(adoptionStatus);
        }
        [HttpDelete]
        public async Task<IUtilityResult> deleteAdoption(int adoptionStatus)
        {
            return _adoptionStatusService.Delete(adoptionStatus);
        }

        #endregion
    }
}

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
    public class PetOwnerController : ControllerBase
    {
        #region Fields
        private readonly IPetOwnerService _petOwnerService;
        #endregion

        #region ctor
        public PetOwnerController(IPetOwnerService petOwnerService)
        {
            _petOwnerService = petOwnerService;
        }
        #endregion
        #region methods
        [HttpGet("GetPetOwnerById")]
        public async Task<PetOwner> GetPetOwnerById(int Id)
        {
            return _petOwnerService.GetById(Id);
        }
        [HttpGet]
        public async Task<List<PetOwner>> GetAllPetOwner()
        {
            return _petOwnerService.Getall();
        }
    
 
        #endregion
    }
}

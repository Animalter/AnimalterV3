using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AnimalterV3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        #region Fields
        private readonly IAnimalService _animalService;
        #endregion

        #region ctor
        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }
        #endregion
        #region methods
        [HttpGet("GetAnimalById")]
        public async Task<AnimalDto> GetAnimalById(int Id)
        {
            return _animalService.GetById(Id);
        }
    
        [HttpGet]
        public async Task<List<AnimalDto>> GetAllAnimal()
        {
            return _animalService.Getall();
        }  
        [HttpGet("GetMyAllAnimal")]
        public async Task<List<AnimalDto>> GetMyAllAnimal(int  UserId)
        {
            return _animalService.GetMyAllAnimal(UserId);
        }
        //[HttpGet("filter")]
        //public async Task<List<AnimalDto>> filter(string? genus, string? type, int? ageYear, int? ageMouth)
        //{
        //    return _animalService.Filter(genus,type,ageYear,ageMouth);
        //}

        [HttpPost]
        public async Task<IUtilityResult> AddAnimal(AnimalDto animal)
        {
            return _animalService.Add(animal);
        }
        [HttpPut]
        public async Task<IUtilityResult> updateAnimal(AnimalDto animal)
        {
            return _animalService.Update(animal);
        }
        [HttpPut("UpdateState")]
        public async  Task<IUtilityResult> UpdateState(AnimalDto animal)
        {
            return _animalService.UpdateState(animal);
        }
        //[HttpPut("updateuser")]
        //public async Task<IUtilityResult> updateUser(int AnimalId, string AdoptionState, int userId)
        //{
        //    return _animalService.updateUser(AnimalId, AdoptionState, userId);
        //}
        [HttpDelete]
        public async Task<IUtilityResult> deleteAnimal(int animal)
        {
            return _animalService.Delete(animal);
        }
        [HttpGet("GetFilteredAnimals")]
        public async Task<List<Animal>> GetFilteredAnimals(/* string animalName,*/ int? genusId,int? typeId,int? ageYear,int? ageMouth)
        {
            return _animalService.GetFilteredAnimals(/*animalName,*/ genusId, typeId, ageYear, ageMouth);
        }
        [HttpGet("GetFilteredAnimals1")]
        public async Task<List<AnimalDto>> GetFilteredAnimals1(string? genuss, string? type, int? ageYear, int? ageMouth)
        {
            return _animalService.GetFilteredAnimals1(genuss, type, ageYear, ageMouth);
        }


        //[HttpGet]
        //[Route("filter")]
        //public async Task<ActionResult<IEnumerable<Animal>>> FilterAnimals([FromQuery] AnimalDto filter)
        //{
        //    try
        //    {
        //        var result = await _animalService.FilterAnimals(filter);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Internal server error: {ex.Message}");
        //    }
        //}

        #endregion


    }
}

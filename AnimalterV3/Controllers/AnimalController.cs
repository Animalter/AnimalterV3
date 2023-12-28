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
        public async Task<Animal> GetAnimalById(int Id)
        {
            return _animalService.GetById(Id);
        }
        [HttpGet]
        public async Task<List<Animal>> GetAllAnimal()
        {
            return _animalService.Getall();
        }
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
        [HttpDelete]
        public async Task<IUtilityResult> deleteAnimal(int animal)
        {
            return _animalService.Delete(animal);
        }
        [HttpGet("GetFilteredAnimals")]
        public async Task<List<Animal>> GetFilteredAnimals( string animalName, int? genusId,int? typeId,int? ageYear,int? ageMouth)
        {
            return _animalService.GetFilteredAnimals(animalName, genusId, typeId, ageYear, ageMouth);
        }


        #endregion


    }
}

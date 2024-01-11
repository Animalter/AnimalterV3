using AnimalterV3.Busssines.Service;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;

namespace AnimalterV3.Busssines.Abstract
{
    public interface IAnimalService
    {
        AnimalDto GetById(int id);
        List<AnimalDto> Getall();
        IUtilityResult Add(AnimalDto animal);
        IUtilityResult Update(AnimalDto animal);
        IUtilityResult UpdateState(AnimalDto animal);
        //AnimalDto updateUser(int AnimalId, string AdoptionState, int userId);
        IUtilityResult Delete(int AnimalId);
        List<AnimalDto> GetMyAllAnimal(int  UserId);
        //Task<IEnumerable<Animal>> FilterAnimals(AnimalDto filter);
        //List<AnimalDto> Filter(string? genus, string? type, int? ageYear, int? ageMouth);
        List<Animal> GetFilteredAnimals(/*string animalName,*/ int? genusId, int? typeeId, int? ageyear, int? agemounth);
        List<AnimalDto> GetFilteredAnimals1(string? Genuss, string? Typeee, int? ageYear, int? ageMouth);

    }
}

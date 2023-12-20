using AnimalterV3.Busssines.Service;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;

namespace AnimalterV3.Busssines.Abstract
{
    public interface IAnimalService
    {
            List<Animal> Getall();
            IUtilityResult Add(AnimalDto animal);
            IUtilityResult Update(AnimalDto animal);
            IUtilityResult Delete(AnimalDto animal);
    }
}

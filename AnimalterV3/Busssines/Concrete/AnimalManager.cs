using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Busssines.Service;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Entity.Concrete.EntityFramework;
using AnimalterV3.Utilities.Abstract;
using AnimalterV3.Utilities.Concrete;

namespace AnimalterV3.Busssines.Concrete
{
    public class AnimalManager: IAnimalService
    {
        private IAnimalDal _animalDal;
        public AnimalManager(IAnimalDal animalDal)
        {
            _animalDal = animalDal;
        }
        public IUtilityResult Add(AnimalDto animalDto)
        {
            Animal animal = new Animal();
            animal.GenusId=animalDto.GenusId;
            animal.AnimalName = animalDto.AnimalName;
            animal.AnimalAgeYear = animalDto.AnimalAgeYear;
            animal.AnimalAgeMouth = animalDto.AnimalAgeYear;
            animal.AnimaiImageUrl = animalDto.AnimaiImageUrl;
            animal.AnimalAbout = animalDto.AnimalAbout;
            animal.AnimalGender = animalDto.AnimalGender;
            _animalDal.Add(animal);
            return new SuccessReasult();


        }
        public List<Animal> Getall()
        {
            return _animalDal.GetAll();
        }
        public IUtilityResult Update(AnimalDto animalDto)
        {
            var animal = new Animal();
            animal.GenusId = animalDto.GenusId;
            animal.AnimalId= animalDto.AnimalId;
            animal.AnimalName = animalDto.AnimalName;
            animal.AnimalAgeYear = animalDto.AnimalAgeYear;
            animal.AnimalAgeMouth = animalDto.AnimalAgeYear;
            animal.AnimaiImageUrl = animalDto.AnimaiImageUrl;
            animal.AnimalAbout = animalDto.AnimalAbout;
            animal.AnimalGender = animalDto.AnimalGender;
            _animalDal.Update(animal);
            return new SuccessReasult();
        }
        public IUtilityResult Delete(AnimalDto animalDto)
        {
            var animal = new Animal();
            animal.AnimalId=animalDto.AnimalId;
            animal.AnimalName = animalDto.AnimalName;
            animal.AnimalAgeYear = animalDto.AnimalAgeYear;
            animal.AnimalAgeMouth = animalDto.AnimalAgeYear;
            animal.AnimaiImageUrl = animalDto.AnimaiImageUrl;
            animal.AnimalAbout = animalDto.AnimalAbout;
            animal.AnimalGender = animalDto.AnimalGender;
            _animalDal.Delete(animal);
            return new SuccessReasult();
        }

        public Animal GetById(int id)
        {
            return _animalDal.GetAll(x => x.AnimalId == id) != null ? _animalDal.GetAll(x => x.AnimalId == id).FirstOrDefault() : new Animal(); ;
        }
    }
}

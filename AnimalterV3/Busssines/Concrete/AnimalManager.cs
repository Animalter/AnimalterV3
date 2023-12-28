using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Busssines.Service;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Entity.Concrete.EntityFramework;
using AnimalterV3.Utilities.Abstract;
using AnimalterV3.Utilities.Concrete;
using System.Linq.Expressions;


namespace AnimalterV3.Busssines.Concrete
{
    public static class PredicateBuilder
    {
        public static Expression<Func<T, bool>> True<T>() { return f => true; }
        public static Expression<Func<T, bool>> False<T>() { return f => false; }

        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> expr1, Expression<Func<T, bool>> expr2)
        {
            var invokedExpr = Expression.Invoke(expr2, expr1.Parameters);
            return Expression.Lambda<Func<T, bool>>(Expression.Or(expr1.Body, invokedExpr), expr1.Parameters);
        }

        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> expr1, Expression<Func<T, bool>> expr2)
        {
            var invokedExpr = Expression.Invoke(expr2, expr1.Parameters);
            return Expression.Lambda<Func<T, bool>>(Expression.And(expr1.Body, invokedExpr), expr1.Parameters);
        }
    }

    public class AnimalManager : IAnimalService
    {
        private IAnimalDal _animalDal;
        public AnimalManager(IAnimalDal animalDal)
        {
            _animalDal = animalDal;
        }
        public IUtilityResult Add(AnimalDto animalDto)
        {
            Animal animal = new Animal();
            animal.TypeId = animalDto.TypeId;
            animal.GenusId = animalDto.GenusId;
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
            animal.TypeId = animalDto.TypeId;
            animal.GenusId = animalDto.GenusId;
            animal.AnimalId = animalDto.AnimalId;
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
            animal.TypeId = animalDto.TypeId;
            animal.AnimalId = animalDto.AnimalId;
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


        public List<Animal> GetFilteredAnimals( string animalName, int? genusId,   int? typeId, int? ageYear ,int? ageMouth)
        {
            var filter = PredicateBuilder.True<Animal>();

            
            if (genusId.HasValue)
            {
                filter = filter.And(x => x.GenusId == genusId.Value);
            }

            if (typeId.HasValue)
            {
                filter = filter.And(x => x.TypeId == typeId.Value);
            }

            
            if (!string.IsNullOrEmpty(animalName))
            {
                filter = filter.And(x => x.AnimalName.Contains(animalName));
            }

            
            if (ageYear.HasValue)
            {
                filter = filter.And(x => x.AnimalAgeYear == ageYear.Value);
            }

            if (ageMouth.HasValue)
            {
                filter = filter.And(x => x.AnimalAgeMouth == ageMouth.Value);
            }

            return _animalDal.GetAll(filter);
        }
    }
}

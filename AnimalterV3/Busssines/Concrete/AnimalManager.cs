using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Busssines.Service;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Entity.Concrete.Context;
using AnimalterV3.Entity.Concrete.EntityFramework;
using AnimalterV3.Utilities.Abstract;
using AnimalterV3.Utilities.Concrete;
using Microsoft.EntityFrameworkCore;
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
        private IAdoptionStatusDal _adoptionStatusDal;
        private IUserDal _userDal;
        private IGenusDal _genusDal;
        private ITypeeDal _typeeDal;
        //private readonly AnimalContext _context;
        public AnimalManager(IAnimalDal animalDal, IAdoptionStatusDal adoptionStatusDal, IUserDal userDal, IGenusDal genusDal, ITypeeDal typeeDal/*AnimalContext context*/)
        {
            _animalDal = animalDal;
            _adoptionStatusDal = adoptionStatusDal;
            _userDal = userDal;
            _genusDal = genusDal;
            _typeeDal = typeeDal;
            //_context = context;

        }
        public IUtilityResult Add(AnimalDto animalDto)
        {
            Animal animal = new Animal();

            animal.TypeId = animalDto.TypeeId;

            animal.GenusId = animalDto.GenusId;
            animal.AdoptionState = animalDto.AdoptionState;
            animal.AnimalName = animalDto.AnimalName;
            animal.AnimalAgeYear = animalDto.AnimalAgeYear;
            animal.AnimalAgeMouth = animalDto.AnimalAgeYear;
            animal.AnimaiImageUrl = animalDto.AnimaiImageUrl;
            animal.AnimalAbout = animalDto.AnimalAbout;
            animal.AnimalGender = animalDto.AnimalGender;
            _animalDal.Add(animal);
            return new SuccessReasult();


        }
        public List<AnimalDto> Getall()
        {
            var result = (from a in _animalDal.GetAll()
                          join t in _typeeDal.GetAll() on a.TypeId equals t.TypeeId
                          join g in _genusDal.GetAll() on a.GenusId equals g.GenusId
                          select new AnimalDto
                          {
                              AnimalId = a.AnimalId,
                              AdoptionState = a.AdoptionState,
                              AnimalName = a.AnimalName,
                              AnimalAgeYear = a.AnimalAgeYear,
                              AnimalAgeMouth = a.AnimalAgeYear,
                              AnimaiImageUrl = a.AnimaiImageUrl,
                              AnimalAbout = a.AnimalAbout,
                              AnimalGender = a.AnimalGender,
                              GenusId = g.GenusId,
                              Genuss = g.Genuss,
                              TypeeId = a.TypeId,
                              Typeee = t.Typeee



                          }).ToList();
            return result;
        }
        public List<AnimalDto> GetMyAllAnimal(int UserId)
        {
            var result = (from u in _userDal.GetAll(x => x.UserId == UserId)
                          join a in _animalDal.GetAll() on u.UserId equals a.UserId
                          join t in _typeeDal.GetAll() on a.TypeId equals t.TypeeId
                          join g in _genusDal.GetAll() on a.GenusId equals g.GenusId
                          select new AnimalDto
                          {
                              AnimalId = a.AnimalId,
                              AdoptionState = a.AdoptionState,
                              AnimalName = a.AnimalName,
                              AnimalAgeYear = a.AnimalAgeYear,
                              AnimalAgeMouth = a.AnimalAgeYear,
                              AnimaiImageUrl = a.AnimaiImageUrl,
                              AnimalAbout = a.AnimalAbout,
                              AnimalGender = a.AnimalGender,
                              GenusId = a.GenusId,
                              Genuss = g.Genuss,
                              TypeeId = a.TypeId,
                              Typeee = t.Typeee



                          }).ToList();
            return result;
        }
        //public List<AnimalDto> Getall()
        //{
        //    var result = (from a in _animalDal.GetAll()
        //                  join ad in _adoptionStatusDal.GetAll() on a.AnimalId equals ad.AnimalId
        //                  select new AnimalDto
        //                  {
        //                      AnimalId = a.AnimalId,
        //                      AdoptionStatusId = ad.AdoptionId,
        //                      AnimalName = a.AnimalName,
        //                      AnimalAgeYear = a.AnimalAgeYear,
        //                      AnimalAgeMouth = a.AnimalAgeYear,
        //                      AnimaiImageUrl = a.AnimaiImageUrl,
        //                      AnimalAbout = a.AnimalAbout,
        //                      AnimalGender = a.AnimalGender,
        //                      GenusId = a.GenusId,
        //                      TypeeId = a.TypeId

        //                  }).ToList();
        //    return result;

        //}
        public IUtilityResult Update(AnimalDto animalDto)
        {
            var animal = new Animal();
            animal.AdoptionState = animalDto.AdoptionState;
            animal.TypeId = animalDto.TypeeId;
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
        public IUtilityResult UpdateState(AnimalDto animalDto)
        {
            var animal = new Animal();
            animal.UserId = animalDto.UserId;
            animal.AdoptionState = animalDto.AdoptionState;
            animal.TypeId = animalDto.TypeeId;
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

            //return _animalDal.GetAll(x => x.AnimalId == id) != null ? _animalDal.GetAll(x => x.AnimalId == id).FirstOrDefault() : new Animal(); ;
        }
        public IUtilityResult updateUser(int AnimalId, string AdoptionState, int userId)
        {
            var result = (from a in _animalDal.GetAll(x => x.AnimalId == AnimalId)
                          join t in _typeeDal.GetAll() on a.TypeId equals t.TypeeId
                          join g in _genusDal.GetAll() on a.GenusId equals g.GenusId
                          select new AnimalDto
                          {
                              AnimalId = a.AnimalId,
                              UserId = a.UserId,
                              AdoptionState = a.AdoptionState,
                              AnimalName = a.AnimalName,
                              AnimalAgeYear = a.AnimalAgeYear,
                              AnimalAgeMouth = a.AnimalAgeYear,
                              AnimaiImageUrl = a.AnimaiImageUrl,
                              AnimalAbout = a.AnimalAbout,
                              AnimalGender = a.AnimalGender,
                              GenusId = g.GenusId,
                              Genuss = g.Genuss,
                              TypeeId = a.TypeId,
                              Typeee = t.Typeee

                          });
            return new SuccessReasult();


            //return _animalDal.GetAll(x => x.AnimalId == id) != null ? _animalDal.GetAll(x => x.AnimalId == id).FirstOrDefault() : new Animal(); ;
        }
        //public IUtilityResult Delete(AnimalDto animalDto)
        //{
        //    var animal = new Animal();
        //    animal.TypeId = animalDto.TypeeId;
        //    animal.AnimalId = animalDto.AnimalId;
        //    animal.AnimalName = animalDto.AnimalName;
        //    animal.AnimalAgeYear = animalDto.AnimalAgeYear;
        //    animal.AnimalAgeMouth = animalDto.AnimalAgeYear;
        //    animal.AnimaiImageUrl = animalDto.AnimaiImageUrl;
        //    animal.AnimalAbout = animalDto.AnimalAbout;
        //    animal.AnimalGender = animalDto.AnimalGender;
        //    _animalDal.Delete(animal);
        //    return new SuccessReasult();
        //}
        public IUtilityResult Delete(int AnimalId)
        {
            Animal animal = _animalDal.GetAll(x => x.AnimalId == AnimalId).FirstOrDefault();
            if (animal == null)
            {
                return new ErrorResult("Hayvan Bulunamadı");
            }
            _animalDal.Delete(animal);
            return new SuccessReasult();
        }
        public AnimalDto GetById(int id)
        {
            var result = (from a in _animalDal.GetAll(x => x.AnimalId == id)
                          join t in _typeeDal.GetAll() on a.TypeId equals t.TypeeId
                          join g in _genusDal.GetAll() on a.GenusId equals g.GenusId
                          select new AnimalDto
                          {
                              AnimalId = a.AnimalId,
                              AdoptionState = a.AdoptionState,
                              AnimalName = a.AnimalName,
                              AnimalAgeYear = a.AnimalAgeYear,
                              AnimalAgeMouth = a.AnimalAgeYear,
                              AnimaiImageUrl = a.AnimaiImageUrl,
                              AnimalAbout = a.AnimalAbout,
                              AnimalGender = a.AnimalGender,
                              GenusId = g.GenusId,
                              Genuss = g.Genuss,
                              TypeeId = a.TypeId,
                              Typeee = t.Typeee

                          }).FirstOrDefault();
            return result;

            //return _animalDal.GetAll(x => x.AnimalId == id) != null ? _animalDal.GetAll(x => x.AnimalId == id).FirstOrDefault() : new Animal(); ;
        }
        public List<Animal> GetFilteredAnimals(/*string animalName,*/ int? genusId, int? typeId, int? ageYear, int? ageMouth)
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


            //if (!string.IsNullOrEmpty(animalName))
            //{
            //    filter = filter.And(x => x.AnimalName.Contains(animalName));
            //}


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
        public List<AnimalDto> GetFilteredAnimals1(string? Genuss, string? Typeee, int? ageYear, int? ageMouth)
        {
            //var filter = PredicateBuilder.True<AnimalDto>();

            //if (!string.IsNullOrEmpty(Typeee))
            //{
            //    filter = filter.And(x => x.Typeee == Typeee);
            //}

            //if (!string.IsNullOrEmpty(Genuss))
            //{
            //    filter = filter.And(x => x.Genuss == Genuss);
            //}
            //if (ageYear.HasValue)
            //{
            //    filter = filter.And(x => x.AnimalAgeYear == ageYear.Value);
            //}

            //if (ageMouth.HasValue)
            //{
            //    filter = filter.And(x => x.AnimalAgeMouth == ageMouth.Value);
            //}

            var result = (from a in _animalDal.GetAll()
                          join t in _typeeDal.GetAll() on a.TypeId equals t.TypeeId
                          join g in _genusDal.GetAll() on a.GenusId equals g.GenusId
                          select new AnimalDto
                          {
                              AnimalId = a.AnimalId,
                              AdoptionState = a.AdoptionState,
                              AnimalName = a.AnimalName,
                              AnimalAgeYear = a.AnimalAgeYear,
                              AnimalAgeMouth = a.AnimalAgeYear,
                              AnimaiImageUrl = a.AnimaiImageUrl,
                              AnimalAbout = a.AnimalAbout,
                              AnimalGender = a.AnimalGender,
                              GenusId = g.GenusId,
                              Genuss = g.Genuss,
                              TypeeId = a.TypeId,
                              Typeee = t.Typeee
                          }).ToList();


            if (!string.IsNullOrEmpty(Typeee))
            {
                result = result.Where(x => x.Typeee.Trim().ToLower() == Typeee.Trim().ToLower()).ToList();
            }
            if (!string.IsNullOrEmpty(Genuss))
            {
                result = result.Where(x => x.Genuss.Trim().ToLower() == Genuss.Trim().ToLower()).ToList();
            }
            if (ageYear.HasValue)
            {
                result = result.Where(x => x.AnimalAgeYear == ageYear).ToList();
            }
            if (ageMouth.HasValue)
            {
                result = result.Where(x => x.AnimalAgeMouth == ageMouth).ToList();
            }
            return result;

            // return _animalDal.GetAll(filter);
        }

        //public List<AnimalDto> Filter(string? genus, string? type, int? ageYear, int? ageMouth)
        //{
        //var query = _context.Animals.AsQueryable();
        //if (!string.IsNullOrEmpty(genus))
        //{
        //}
        //else
        //{
        //    var result = (from a in _animalDal.GetAll()
        //                  join t in _typeeDal.GetAll() on a.TypeId equals t.TypeeId
        //                  join g in _genusDal.GetAll() on a.GenusId equals g.GenusId
        //                  select new AnimalDto
        //                  {
        //                      AnimalId = a.AnimalId,
        //                      AdoptionState = a.AdoptionState,
        //                      AnimalName = a.AnimalName,
        //                      AnimalAgeYear = a.AnimalAgeYear,
        //                      AnimalAgeMouth = a.AnimalAgeYear,
        //                      AnimaiImageUrl = a.AnimaiImageUrl,
        //                      AnimalAbout = a.AnimalAbout,
        //                      AnimalGender = a.AnimalGender,
        //                      GenusId = g.GenusId,
        //                      Genuss = g.Genuss,
        //                      TypeeId = a.TypeId,
        //                      Typeee = t.Typeee
        //                  }).ToList();
        //    return result;











        //public async Task<IEnumerable<Animal>> FilterAnimals(AnimalDto filter)
        //{
        //    var query = _context.Animals.AsQueryable();

        //if (filter.TypeeId.HasValue)
        //    query = query.Where(a => a.TypeId == filter.TypeeId);

        //if (!string.IsNullOrEmpty(filter.Typeee))
        //    query = query.Where(a => a.Typeee.Typeee == filter.Typeee);

        //if (filter.GenusId.HasValue)
        //    query = query.Where(a => a.GenusId == filter.GenusId);

        //if (!string.IsNullOrEmpty(filter.Genuss))
        //    query = query.Where(a => a.Genus.Genuss == filter.Genuss);

        //if (filter.AnimalAgeYear.HasValue)
        //    query = query.Where(a => a.AnimalAgeYear == filter.AnimalAgeYear);

        //if (filter.AnimalAgeMouth.HasValue)
        //    query = query.Where(a => a.AnimalAgeMouth == filter.AnimalAgeMouth);

        //    return await query.ToListAsync();
        //}

    }
}

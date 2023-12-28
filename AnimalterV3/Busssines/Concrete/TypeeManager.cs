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
    public class TypeeManager : ITypeeService
    {
        private ITypeeDal _typeeDal;
        public TypeeManager(ITypeeDal typeeDal)
        {
            _typeeDal = typeeDal;

        }
        public IUtilityResult Add(TypeeDto typeeDto)
        {
            Typee typee = new Typee();

            typee.Typeee = typeeDto.Typeee;
            _typeeDal.Add(typee);
            return new SuccessReasult();

        }
        public List<Typee> Getall()
        {
            return _typeeDal.GetAll();
        }
        public IUtilityResult Update(TypeeDto typeeDto)
        {
            var typee = new Typee();
            typee.TypeeId = typeeDto.TypeeId;
            typee.Typeee = typeeDto.Typeee;
            _typeeDal.Update(typee);
            return new SuccessReasult();
        }
        public IUtilityResult Delete(TypeeDto typeeDto)
        {
            var typee = new Typee();
            typee.TypeeId = typeeDto.TypeeId;
            _typeeDal.Delete(typee);
            return new SuccessReasult();
        }
        public Typee GetById(int id)
        {
            return _typeeDal.GetAll(x => x.TypeeId == id) != null ? _typeeDal.GetAll(x => x.TypeeId == id).FirstOrDefault() : new Typee();
        }
    }
}

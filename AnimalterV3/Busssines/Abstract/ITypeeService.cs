using AnimalterV3.Busssines.Service;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;

namespace AnimalterV3.Busssines.Abstract
{
    public interface ITypeeService 
    {
        Typee GetById(int id);
        List<Typee> Getall();
        IUtilityResult Add(TypeeDto typee);
        IUtilityResult Update(TypeeDto typee);
        IUtilityResult Delete(int  TypeeId);
    }
}

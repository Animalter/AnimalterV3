using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;

namespace AnimalterV3.Busssines.Service
{
    public interface IServiceRepository<T>
    {
        IDataResult<List<T>> Getall();
        IDataResult<T> GetById(int id);
        IUtilityResult Update(T t);
        IUtilityResult Delete(int id);
        IUtilityResult Add(T t);



    }
}

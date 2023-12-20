using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;

namespace AnimalterV3.Busssines.Concrete
{
    public class AdminManager : IAdminService
    {
        public IUtilityResult Add(Admin admin)
        {
            throw new NotImplementedException();
        }

        public IUtilityResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Admin>> Getall()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Admin> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IUtilityResult Update(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}

using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
using AnimalterV3.Entity.Concrete.Context;
using AnimalterV3.Entity.Entites;

namespace AnimalterV3.Entity.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepository<Admin, AnimalContext>,IAdminDal
    {
    }
 
}

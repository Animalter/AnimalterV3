using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;

namespace AnimalterV3.Busssines.Abstract
{
    public interface IRoleService
    {
        RoleTbl GetById(int id);
        List<RoleTbl> GetAll();
        IUtilityResult Add(RoleDto role);
        IUtilityResult Update(RoleDto role);
        IUtilityResult Delete(int RoleId);
    }
}

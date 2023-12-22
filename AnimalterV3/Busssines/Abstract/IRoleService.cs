using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;

namespace AnimalterV3.Busssines.Abstract
{
    public interface IRoleService
    {
        List<RoleTbl> GetAll();
        IUtilityResult Add(RoleDto role);
        IUtilityResult Update(RoleDto role);
        IUtilityResult Delete(UserDto role);
    }
}

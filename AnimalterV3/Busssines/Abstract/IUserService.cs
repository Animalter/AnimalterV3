using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;


namespace AnimalterV3.Busssines.Abstract
{
    public interface IUserService
    {
        UserTbl GetById(int id);
        List<UserTbl> Getall();
        IUtilityResult Add(UserDto user);
        IUtilityResult Update(UserDto user);
        IUtilityResult Delete(UserDto user);
    }
}

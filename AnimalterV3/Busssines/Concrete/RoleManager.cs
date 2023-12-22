using AnimalterV3.Dto;
using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;

namespace AnimalterV3.Busssines.Concrete
{
    public class RoleManager
    {
        private IRoleDal _roleDal;
        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }
        //public IUtilityResult Add(AnimalDto animalDto)
        //{
        //    RoleTbl roleTbl = new RoleTbl();
        //    roleTbl.RoleName=RoleDto.


        //}
       
}

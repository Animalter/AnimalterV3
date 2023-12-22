using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Entity.Concrete.EntityFramework;
using AnimalterV3.Utilities.Abstract;
using AnimalterV3.Utilities.Concrete;

namespace AnimalterV3.Busssines.Concrete
{
    public class RoleManager:IRoleService
    {
        private IRoleDal _roleDal;
        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;  
        }

        public IUtilityResult Add(RoleDto role)
        {
            RoleTbl roleTbl = new RoleTbl();
            role.RoleName = role.RoleName;
            _roleDal.Add(roleTbl);
            return new SuccessReasult();

        }

        public IUtilityResult Delete(RoleDto role)
        {
            var roleTbl = new RoleTbl();
            role.RoleName = role.RoleName;
            _roleDal.Delete(roleTbl);
            return new SuccessReasult();
        }

        public List<RoleTbl> GetAll()
        {
           return _roleDal.GetAll();
        }

        public IUtilityResult Update(RoleDto role)
        {
            var roleTbl = new RoleTbl();
            role.RoleName = role.RoleName;
            _roleDal.Update(roleTbl);
            return new SuccessReasult();
        }
        
    }


}

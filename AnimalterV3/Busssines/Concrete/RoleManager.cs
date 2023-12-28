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
            roleTbl.RoleName = role.RoleName;
            _roleDal.Add(roleTbl);
            return new SuccessReasult();

        }

        //public IUtilityResult Delete(RoleDto role)
        //{

        //    var roleTbl = new RoleTbl();

        //    roleTbl.RoleId= role.RoleId;
        //    roleTbl.RoleName = role.RoleName;
        //    _roleDal.Delete(roleTbl);
        //    return new SuccessReasult();
        //}
        public IUtilityResult Delete(int RoleId)
        {
            RoleTbl role = _roleDal.GetAll(x => x.RoleId == RoleId).FirstOrDefault();
            if (role == null)
            {
                return new ErrorResult("rol Bulunamadı");
            }
            _roleDal.Delete(role);
            return new SuccessReasult();
        }

        public List<RoleTbl> GetAll()
        {
           return _roleDal.GetAll();
        }

        public RoleTbl GetById(int id)
        {
            return _roleDal.GetAll(x => x.RoleId == id) != null ? _roleDal.GetAll(x => x.RoleId == id).FirstOrDefault() : new RoleTbl();
        }

        public IUtilityResult Update(RoleDto role)
        {
            var roleTbl = new RoleTbl();
            roleTbl.RoleId= role.RoleId;
            roleTbl.RoleName = role.RoleName;
            _roleDal.Update(roleTbl);
            return new SuccessReasult();
        }
        
    }


}

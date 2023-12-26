using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Entity.Concrete.EntityFramework;
using AnimalterV3.Utilities.Abstract;
using AnimalterV3.Utilities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace AnimalterV3.Busssines.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        private IRoleDal _roleDal;
        private IUserRoleDal _userRoleDal;
        public UserManager(IUserDal userDal, IRoleDal roleDal, IUserRoleDal userRoleDal)
        {
            _userDal = userDal;
            _roleDal = roleDal;
            _userRoleDal = userRoleDal;
        }

        public IUtilityResult Add(UserDto user)
        {
            UserTbl userTbl = new UserTbl();
            userTbl.RoleId = user.RoleId;
            userTbl.UserName = user.UserName;
            userTbl.UserPassword = user.UserPassword;
            userTbl.PhoneNumber = user.PhoneNumber;
            userTbl.Mail = user.Mail;
            _userDal.Add(userTbl);
            return new SuccessReasult();
        }

        public IUtilityResult Delete(UserDto user)
        {
            UserTbl userTbl = new UserTbl();
            userTbl.RoleId = user.RoleId;
            userTbl.UserId = user.UserId;
            userTbl.UserName = user.UserName;
            userTbl.UserPassword = user.UserPassword;
            userTbl.PhoneNumber = user.PhoneNumber;
            userTbl.Mail = user.Mail;

            _userDal.Delete(userTbl);
            return new SuccessReasult();
        }

        public List<UserTbl> Getall()
        {
            return _userDal.GetAll();
        }
        public UserTbl GetById(int id)
        {
            return _userDal.GetAll(x => x.UserId == id) != null ? _userDal.GetAll(x => x.UserId == id).FirstOrDefault() : new UserTbl();
        }

        public IUtilityResult Update(UserDto user)
        {
            UserTbl userTbl = new UserTbl();
            userTbl.RoleId = user.RoleId;
            userTbl.UserId = user.UserId;
            userTbl.UserName = user.UserName;
            userTbl.UserPassword = user.UserPassword;
            userTbl.PhoneNumber = user.PhoneNumber;
            userTbl.Mail = user.Mail;
            _userDal.Update(userTbl);
            return new SuccessReasult();
        }


        public AccountDto Login(string UserName, string Password)
        {
            var Login = (from u in _userDal.GetAll().Where(x => (x.UserName == UserName.Trim() || x.Mail == UserName) && x.UserPassword.Trim() == Password.Trim())
                         join ur in _userRoleDal.GetAll() on u.UserId equals ur.UserId into gj
                         from x in gj.DefaultIfEmpty()
                         join r in _roleDal.GetAll() on x.RoleId equals r.RoleId into bjk
                         from y in bjk.DefaultIfEmpty()
                         select new AccountDto
                         {
                             RoleId = y.RoleId,
                             UserName = u.UserName,
                             UserId = u.UserId,
                             RoleName = y.RoleName,
                             UserEmail = u.Mail
                         }).FirstOrDefault();
            return Login;
        }

    }
}

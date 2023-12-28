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

        public IUtilityResult Delete(int UserId)
        {
            UserTbl userTbl = _userDal.GetAll(x => x.UserId == UserId).FirstOrDefault();
            if (userTbl == null)
            {
                return new ErrorResult("User Bulunamadı");
            }
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
            userTbl.UserRoles = userTbl.UserRoles;
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
                         join r in _roleDal.GetAll() on u.RoleId equals r.RoleId into bjk
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
        public IUtilityResult Register(UserDto user)
        {

            var existingUser = _userDal.GetAll(u => u.UserName == user.UserName || u.Mail == user.Mail).FirstOrDefault();
            if (existingUser != null)
            {
                return new ErrorResult("Kullanıcı adı veya e-posta adresi zaten kullanılıyor.");
            }


            var newUser = new UserTbl
            {
                RoleId = user.RoleId,
                UserName = user.UserName,
                UserPassword = user.UserPassword,
                PhoneNumber = user.PhoneNumber,
                Mail = user.Mail

            };
            _userDal.Add(newUser);
            return new SuccessReasult("Kayıt işlemi başarılı.");
        }

        public IUtilityResult RegisterCustomer(UserDto user)
        {

            var existingUser = _userDal.GetAll(u => u.UserName == user.UserName || u.Mail == user.Mail).FirstOrDefault();
            if (existingUser != null)
            {
                return new ErrorResult("Kullanıcı adı veya e-posta adresi zaten kullanılıyor.");
            }


            var newUser = new UserTbl
            {

                UserName = user.UserName,
                UserPassword = user.UserPassword,
                PhoneNumber = user.PhoneNumber,
                Mail = user.Mail
                // Diğer özellikler
            };

            _userDal.Add(newUser);
            return new SuccessReasult("Kayıt işlemi başarılı.");
        }


    }
}

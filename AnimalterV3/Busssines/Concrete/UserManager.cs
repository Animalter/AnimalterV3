using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Entity.Concrete.EntityFramework;
using AnimalterV3.Utilities.Abstract;
using AnimalterV3.Utilities.Concrete;
using System.Linq.Expressions;

namespace AnimalterV3.Busssines.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IUtilityResult Add(UserDto user)
        {
            UserTbl userTbl = new UserTbl();
            userTbl.UserName= user.UserName;
            userTbl.UserPassword= user.UserPassword;
            userTbl.PhoneNumber= user.PhoneNumber;
            userTbl.Mail= user.Mail;
            _userDal.Add(userTbl);
            return new SuccessReasult();
        }

        public IUtilityResult Delete(UserDto user)
        {
            UserTbl userTbl = new UserTbl();

            userTbl.UserId= user.UserId;
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

            userTbl.UserId= user.UserId;
            userTbl.UserName = user.UserName;
            userTbl.UserPassword = user.UserPassword;
            userTbl.PhoneNumber = user.PhoneNumber;
            userTbl.Mail = user.Mail;
            _userDal.Update(userTbl);
            return new SuccessReasult();
        }
    }
}

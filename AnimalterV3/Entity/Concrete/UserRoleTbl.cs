using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using AnimalterV3.Entity.Concrete.EntityFramework;
using AnimalterV3.Entity.Abstract.Entites;

namespace AnimalterV3.Entity.Concrete
{
    public class UserRoleTbl : IEntity
    {
        [Key]
        public int UserRoleID { get; set; }

        // Bir kullanıcının birden fazla rolü olabilir
        public int UserId { get; set; }
        public UserTbl User { get; set; }

        public int RoleId { get; set; }
        public RoleTbl Role { get; set; }


    }
}

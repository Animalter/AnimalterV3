using AnimalterV3.Entity.Abstract.Entites;
using System.ComponentModel.DataAnnotations;

namespace AnimalterV3.Entity.Concrete
{
    public class UserTbl : IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        // Bir kullanıcının birden fazla rolü olabilir
        public virtual ICollection<UserRoleTbl> UserRoles { get; set; }
    }
}

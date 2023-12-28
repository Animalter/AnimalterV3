using AnimalterV3.Entity.Abstract.Entites;
using System.ComponentModel.DataAnnotations;

namespace AnimalterV3.Entity.Concrete
{
    public class UserTbl : IEntity
    {
        [Key]
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string? Mail { get; set; }
        public string? PhoneNumber { get; set; }

        public virtual ICollection<UserRoleTbl> UserRoles { get; set; }

        public ICollection<AdoptionStatus> AdoptionStatusess { get; set; }
    }
}

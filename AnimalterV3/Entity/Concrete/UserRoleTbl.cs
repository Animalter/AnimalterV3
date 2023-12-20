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

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public virtual UserTbl UserTbl { get; set; }
        public virtual RoleTbl RoleTbl { get; set; }
    }
}

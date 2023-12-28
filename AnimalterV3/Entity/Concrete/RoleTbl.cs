using AnimalterV3.Entity.Abstract.Entites;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AnimalterV3.Entity.Concrete
{
    public class RoleTbl :IEntity
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        [JsonIgnore]
        public virtual ICollection<UserRoleTbl> UserRoles { get; set; }


    }
}

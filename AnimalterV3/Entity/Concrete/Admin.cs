using AnimalterV3.Entity.Abstract.Entites;
using System.ComponentModel.DataAnnotations;

namespace AnimalterV3.Entity.Concrete
{
    public class Admin :IEntity
    {
        [Key]
        public int AdminId { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(50)]
        public string? Password { get; set; }


        [StringLength(50)]
        public string? Mail { get; set; }

        [StringLength(50)]
        public int? PhoneNumber { get; set; }
    }
}

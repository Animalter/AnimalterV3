using AnimalterV3.Entity.Abstract.Entites;
using System.ComponentModel.DataAnnotations;

namespace AnimalterV3.Entity.Concrete
{
    public class PetOwner:IEntity
    {
        [Key ]
        public int PetownerId { get; set; }
        public int AdoptionStatusId { get; set; }
        public int CustomerId { get; set; }
        public int AnimalId { get; set; }
        public DateTime? AdoptionDate { get; set; }
    }
}

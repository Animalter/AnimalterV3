using AnimalterV3.Entity.Abstract.Entites;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalterV3.Entity.Concrete
{
    public class AdoptionStatus : IEntity
    {
        [Key]
        public int AdoptionId { get; set; }
        public int AnimalId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? AdoptionDate { get; set; }

        [ForeignKey("AnimalId")]
        public Animal Animal { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

    }
}

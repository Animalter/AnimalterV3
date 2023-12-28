using AnimalterV3.Entity.Abstract.Entites;
using System.ComponentModel.DataAnnotations;

namespace AnimalterV3.Entity.Concrete
{
    public class Customer : IEntity
    {
        [Key]
        public int CustomerId { get; set; }

        [StringLength(50)]
        public string Customername { get; set; }

        
        public string CustomerPassword { get; set; }

        [StringLength(50)]
        public string CustomerMail { get; set; }

        
        public int? CustomerPhoneNumber { get; set; }



        //public ICollection<AdoptionStatus> AdoptionStatuses { get; set; }
    }
}

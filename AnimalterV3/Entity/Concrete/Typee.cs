using AnimalterV3.Entity.Abstract.Entites;
using System.ComponentModel.DataAnnotations;

namespace AnimalterV3.Entity.Concrete
{
    public class Typee : IEntity
    {
        [Key]
        public int TypeeId { get; set; }

        [StringLength(50)]
        public string Typeee { get; set; }

        public ICollection<Genus> GenusList { get; set; }
    }
}

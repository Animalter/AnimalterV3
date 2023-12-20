using AnimalterV3.Entity.Abstract.Entites;
using System.ComponentModel.DataAnnotations;

namespace AnimalterV3.Entity.Concrete
{
    public class Genus : IEntity

    {
        [Key]
        public int GenusId { get; set; }

        [StringLength(50)]
        public string Genuss { get; set; }

       



        public ICollection<Animal> Animals { get; set; }

    }
}

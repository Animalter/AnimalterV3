using AnimalterV3.Entity.Abstract.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalterV3.Entity.Concrete
{
    public class Animal : IEntity
    {
        [Key]
        public int AnimalId { get; set; }

        [StringLength(50)]
        public string AnimalName { get; set; }

        
        public int AnimalAgeYear { get; set; }

        
        public int AnimalAgeMouth { get; set; }

    

        [StringLength(50)]
        public string AnimalAbout { get; set; }

        [StringLength(100)]
        public string AnimaiImageUrl { get; set; }

        [StringLength(50)]
        public string AnimalGender { get; set; }




        public int GenusId { get; set; }
        [ForeignKey("GenusId")]
        public Genus Genus { get; set; }

        public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public Typee Typeee { get; set; }



        public ICollection<AdoptionStatus> AdoptionStatuses { get; set; }
    }
}

using AnimalterV3.Entity.Abstract.Entites;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalterV3.Entity.Concrete
{
    public class Image: IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public byte[] Data { get; set; }
    }
}

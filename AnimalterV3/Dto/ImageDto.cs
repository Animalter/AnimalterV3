using System.ComponentModel.DataAnnotations;

namespace AnimalterV3.Dto
{
    public class ImageDto
    {
        
        public int Id { get; set; }

       
        public string FileName { get; set; }

       
        public byte[] Data { get; set; }
    }
}

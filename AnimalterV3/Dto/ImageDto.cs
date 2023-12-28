using System.ComponentModel.DataAnnotations;

namespace AnimalterV3.Dto
{
    public class ImageDto
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] Data { get; set; }
        public IFormFile File { get; set; }
        public int AnimalId { get; set; }
    }
}

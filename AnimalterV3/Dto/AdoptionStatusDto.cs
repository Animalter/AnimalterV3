namespace AnimalterV3.Dto
{
    public class AdoptionStatusDto
    {
        public int AdoptionStatusId { get; set; }
        public int UserId { get; set; }
        public int AnimalId { get; set; }
        public DateTime? AdoptionDate { get; set; }
    }
}

namespace AnimalterV3.Dto
{
    public class PetOwnerDto
    {
        public int PetownerId { get; set; }
        public int AdoptionStatusId { get; set; }
        public int CustomerId { get; set; }
        public int AnimalId { get; set; }
        public DateTime? AdoptionDate { get; set; }
    }
}

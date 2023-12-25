namespace AnimalterV3.Dto
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string? Mail { get; set; }
        public int? PhoneNumber { get; set; }

        public List<string> Roles { get; set; }
    }
}

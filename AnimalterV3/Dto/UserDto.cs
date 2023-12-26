namespace AnimalterV3.Dto
{
    public class UserDto
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string? Mail { get; set; }
        public string? PhoneNumber { get; set; }

       
    }
}

namespace AutomapperDemo.API.DTO
{
    public class UserCreateDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTimeOffset DateOfBirth { get; set; }
        public string Password { get; set; } = string.Empty;
    }
}

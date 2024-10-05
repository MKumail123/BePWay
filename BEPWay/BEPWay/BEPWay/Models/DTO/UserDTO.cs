namespace BEPWay.Models.DTO
{
    public class UserDTO
    {
        public Guid Id { get; set; }    
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string CNIC { get; set; }
        public string DateOfBirth { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string? Role { get; set; }
    }
}

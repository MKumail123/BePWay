using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BEPWay.Models.Domain
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string CNIC { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserRole UserRole { get; set; }

    }
}

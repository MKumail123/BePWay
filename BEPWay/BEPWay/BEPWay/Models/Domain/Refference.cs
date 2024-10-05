namespace BEPWay.Models.Domain
{
    public class Refference : BaseModel
    {
        public Guid RefferalUserId { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}

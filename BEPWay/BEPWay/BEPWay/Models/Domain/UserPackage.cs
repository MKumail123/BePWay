namespace BEPWay.Models.Domain
{
    public class UserPackage : BaseModel
    {
        public Guid UserId { get; set; }
        public string ImagePath { get; set; }
        public Guid PackageId { get; set; }
        public Package Package { get; set; }
        public User User { get; set; }
        public string TransactionId { get; set; }
        public int ActivationPoints { get; set; }
    }
}

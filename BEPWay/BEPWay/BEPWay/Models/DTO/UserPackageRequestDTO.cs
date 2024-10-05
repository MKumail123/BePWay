namespace BEPWay.Models.DTO
{
    public class UserPackageRequestDTO
    {
        public Guid UserPackageId { get; set; }
        public Guid UserId { get; set; }
        public Guid PackageId { get; set; }
        public string TransactionId { get; set; }
        public IFormFile File { get; set; }
        public string FilePath { get; set; }
        public string UserName { get; set; }
        public int ActivationPoints { get; set; }
        public bool Status { get; set; }
    }
}

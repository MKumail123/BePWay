namespace BEPWay.Models.DTO
{
    public class UserPackageResponseDTO
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid PackageId { get; set; }
        public string PackageName { get; set; }
        public string UserName { get; set; }
        public string ImageUrl { get; set; }
        public double PackagePoints { get; set; }
        public string TransactionId { get; set; }
        public bool Status { get; set; }
    }
}

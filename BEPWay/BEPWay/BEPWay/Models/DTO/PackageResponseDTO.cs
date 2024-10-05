namespace BEPWay.Models.DTO
{
    public class PackageResponseDTO
    {
        public Guid PackageId { get; set; }
        public string Name { get; set; }
        public double Points { get; set; }
        public int Amount { get; set; }
        public double Value { get; set; }
    }
}

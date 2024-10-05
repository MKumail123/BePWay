namespace BEPWay.Models.Domain
{
    public class Commission : BaseModel
    {
        public Guid UserPackageId { get; set; }
        public float Precentage { get; set; }
        public Guid LevelId { get; set; }
        public Level Level { get; set; }
        public UserPackage UserPackage { get; set; }

    }
}

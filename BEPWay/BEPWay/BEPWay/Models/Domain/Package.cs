namespace BEPWay.Models.Domain
{
    public class Package : BaseModel
    {
        public string Name { get; set; }
        public double Points { get; set; }
        public int Amount { get; set; }
        public double Value { get; set; }
    }
}

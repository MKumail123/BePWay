namespace BEPWay.Models.Domain
{
    public class Role : BaseModel
    {
        public string Name { get; set; }
        public UserRole UserRole { get; set; }
    }
}

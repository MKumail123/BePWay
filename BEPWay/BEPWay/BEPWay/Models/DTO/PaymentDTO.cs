namespace BEPWay.Models.DTO
{
    public class PaymentDTO
    {
        public Guid UserId { get; set; }
        public int Payment {  get; set; }
        public IFormFile File { get; set; }
    }
}

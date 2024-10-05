namespace BEPWay.Models.DTO
{
    public class FileUploadDTO
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public IFormFile File { get; set; }
    }
}

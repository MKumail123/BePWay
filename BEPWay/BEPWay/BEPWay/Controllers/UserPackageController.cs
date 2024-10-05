using BEPWay.Constant;
using BEPWay.Interfaces;
using BEPWay.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BEPWay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPackageController : ControllerBase
    {
        private readonly IUserPackageRepository repository;
        private readonly FileUpload fileUpload;

        public UserPackageController(IUserPackageRepository repository, FileUpload fileUpload)
        {
            this.repository = repository;
            this.fileUpload = fileUpload;
        }

        [HttpGet]
        public async Task<IActionResult> GetInActiveUsers()
        {
            return new JsonResult(new {success = true, response = repository.GetInActiveUsers()});
        }

        [HttpPut]
        public async Task<IActionResult> Activate([FromBody] UserPackageRequestDTO request)
        {
            return new JsonResult(new { success = true, response = repository.Activate(request) });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] UserPackageRequestDTO request)
        {
            var fileUploadDTO = new FileUploadDTO()
            {
                Id = request.UserId,
                File = request.File,
            };
            var filePath = await fileUpload.Upload(fileUploadDTO);
            request.FilePath = filePath;
            return new JsonResult(new {success = true, response = repository.Create(request)});
        }
    }
}

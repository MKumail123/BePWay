using BEPWay.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace BEPWay.Constant
{
    public class FileUpload
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUpload(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }


        public async Task<string> Upload(FileUploadDTO model)
        {
            if (model.File == null || model.File.Length == 0)
            {
                return null;
            }

            var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, $"images/{model.UserId}/{model.Id}");
            Directory.CreateDirectory(uploadsFolder); // Ensure the directory exists

            var filePath = Path.Combine(uploadsFolder, model.File.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await model.File.CopyToAsync(stream);
            }

            return $"/images/{model.Id}/{model.File.FileName}";
        }
    }
}

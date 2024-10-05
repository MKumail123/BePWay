using BEPWay.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BEPWay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private readonly IPackageRepository packageRepo;
        public PackageController(IPackageRepository _packageRepo) 
        {
            packageRepo = _packageRepo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return new JsonResult(new { success = true, response = packageRepo.GetAll()});
        }

        [HttpGet]
        [Route("{Id:Guid}")]
        public IActionResult Get(Guid Id)
        {

            return new JsonResult(new { success = true, response = packageRepo.GetById(Id) });
        }
    }
}

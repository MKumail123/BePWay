using BEPWay.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BEPWay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankRepository repo;

        public BankController(IBankRepository repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return new JsonResult(new {success  = true, response = repo.GetAll()});
        }

        [HttpGet]
        [Route("{Id:Guid}")]
        public IActionResult Get(Guid Id)
        {
            return new JsonResult(new { success = true, response = repo.GetById(Id) });
        }
    }
}

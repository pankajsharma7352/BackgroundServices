using BackGroundService.Model.Models;
using BackGroundService.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackGroundService.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BgServiceController : ControllerBase
    {
        private readonly BgrdServices bgrdServices;

        public BgServiceController(BgrdServices bgrdServices)
        {
            this.bgrdServices = bgrdServices;
        }

        [HttpPost("InsertData")]
        public string InsertIntoTemp(TempDTO tempDTO)
        {
            return bgrdServices.InsertInToTemp(tempDTO);
        }
    }
}

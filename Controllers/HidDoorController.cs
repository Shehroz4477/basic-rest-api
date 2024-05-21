using basic_rest_api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace basic_rest_api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class HidDoorController : ControllerBase
{
    public HidDoorController()
    {
        //TODO
    }
    [HttpGet("GetConfig")]
    public ActionResult Get([FromKeyedServices("hidDoorConfigService")] IDoorConfigService hidDoorConfigService)
    {
        return Content(hidDoorConfigService.GetDoorConfig());
    }
}

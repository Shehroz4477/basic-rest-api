using basic_rest_api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace basic_rest_api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AxisDoorController : ControllerBase
{
    public AxisDoorController()
    {
        //TODO
    }
    [HttpGet("GetConfig")]
    public ActionResult Get([FromKeyedServices("axisDoorConfigService")] IDoorConfigService axisDoorConfigService)
    {
        return Content(axisDoorConfigService.GetDoorConfig());
    }
}

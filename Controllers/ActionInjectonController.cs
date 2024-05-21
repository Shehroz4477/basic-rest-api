using basic_rest_api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace basic_rest_api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ActionInjectonController : ControllerBase
{
    private readonly IScopedService _scopedService;
    public ActionInjectonController(IScopedService scopedService)
    {
        _scopedService = scopedService;
    }
    [HttpGet]
    // public ActionResult Get([FromServices] IScopedService scopedService)
    // {
    //     var scopedServiceMessage = scopedService.SayHello();
    //     var transientServiceMessage = _transientService.SayHello();
    //     return Content($"{scopedServiceMessage}{Environment.NewLine}{transientServiceMessage}{Environment.NewLine}"); 
    // }
    public ActionResult Get([FromServices] ITransientService transientService)
    {
        var transientServiceMessage = transientService.SayHello();
        var scopedServiceMessage = _scopedService.SayHello();
        return Content($"{scopedServiceMessage}{Environment.NewLine}{transientServiceMessage}{Environment.NewLine}"); 
    }
}
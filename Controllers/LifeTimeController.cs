using basic_rest_api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace basic_rest_api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LifeTimeController : ControllerBase
{
    private readonly IScopedService _scopedService;
    private readonly ITransientService _transientService;
    private readonly ISingletonService _singletonService;
    public LifeTimeController(IScopedService scopedService, ITransientService transientService, ISingletonService singletonService)
    {
        _scopedService = scopedService;
        _transientService = transientService;
        _singletonService = singletonService;
    }
    [HttpGet]
    public ActionResult Get()
    {
        var scopedServiceMessage = _scopedService.SayHello();
        var transientServiceMessage = _transientService.SayHello();
        var singletonServiceMessage = _singletonService.SayHello();
        return Content($"{scopedServiceMessage}{Environment.NewLine}{transientServiceMessage}{Environment.NewLine}{singletonServiceMessage}{Environment.NewLine}"); 
    }
    [HttpGet("GetLifeTime")]
    public ActionResult GetLifeTime()
    {
        var scopedServiceMessage = _scopedService.SayHello();
        var transientServiceMessage = _transientService.SayHello();
        var singletonServiceMessage = _singletonService.SayHello();
        return Content($"{scopedServiceMessage}{Environment.NewLine}{transientServiceMessage}{Environment.NewLine}{singletonServiceMessage}{Environment.NewLine}"); 
    }
}

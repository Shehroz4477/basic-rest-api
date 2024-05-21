using basic_rest_api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace basic_rest_api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ActionInjectonController : ControllerBase
{
    private readonly ITransientService _transientService;
    public ActionInjectonController(ITransientService transientService)
    {
        _transientService = transientService;
    }
    [HttpGet]
    public ActionResult Get([FromServices] IScopedService scopedService)
    {
        var scopedServiceMessage = scopedService.SayHello();
        var transientServiceMessage = _transientService.SayHello();
        return Content($"{scopedServiceMessage}{Environment.NewLine}{transientServiceMessage}{Environment.NewLine}"); 
    }
}
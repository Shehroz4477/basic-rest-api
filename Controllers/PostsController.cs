using basic_rest_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace basic_rest_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostsController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Post>> GetPost()
    {
        return new List<Post>
        {
            new() { Id = 1, UserId = 1, Title = "Post1", Body = "The first post." },
            new() { Id = 2, UserId = 1, Title = "Post2", Body = "The second post." },
            new() { Id = 3, UserId = 1, Title = "Post3", Body = "The third post." }
        };
    }
}

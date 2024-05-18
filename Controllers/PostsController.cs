
using basic_rest_api.Models;
using basic_rest_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace basic_rest_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostsController : ControllerBase
{
    private readonly PostService _postService;
    public PostsController()
    {
        // Note that we use the new() constructor to create an instance of the service. 
        // That means the controller is coupled with the PostsService class. 
        // We will see how to decouple the controller and the service in the DI concept.
        _postService = new PostService();
    }
    //  [HttpGet("{id}")] attribute to indicate the URL of the operation. 
    //  The URL will be mapped to /api/posts/{id}.
    [HttpGet("{id}")]
    public async Task<ActionResult<Post>> GetPost(int id)
    {
        var post = await _postService.GetPost(id);
        if(post == null)
        {
            return NotFound();
        }
        return Ok(post);
    }
}

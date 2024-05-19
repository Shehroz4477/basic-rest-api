
using basic_rest_api.Interfaces;
using basic_rest_api.Models;
using basic_rest_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace basic_rest_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostsController : ControllerBase
{
    private readonly IPostService _postService;
    public PostsController(IPostService postService)
    {
        // Note that we use the new() constructor to create an instance of the service. 
        // That means the controller is coupled with the PostsService class. 
        // We will see how to decouple the controller and the service in the DI concept.
        _postService = postService;
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
    [HttpPost]
    public async Task<ActionResult<Post>> CreatePost(Post post)
    {
        await _postService.CreatePost(post);
        // the built-in CreatedAtAction, which returns a response message with the specified action name, 
        // route values, and post. For this case, it will call the GetPost() action to return the newly 
        // created post.
        return CreatedAtAction(nameof(GetPost), new {id = post.Id}, post);
    }
    [HttpPut("{id}")]
    public async Task<ActionResult<Post?>> UpdatePost(int id, Post post)
    {
        if(id != post.Id)
        {
            return BadRequest();
        }
        var updatePost =  await _postService.UpdatePost(id, post);
        if(updatePost == null)
        {
            return NotFound();
        }
        return Ok(post);
    }
    [HttpGet]
    public async Task<ActionResult<List<Post>>> GetPosts()
    {
        return Ok(await _postService.GetAllPosts());
    }
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeletePost(int id)
    {
        var post = await _postService.DeletePost(id);
        if(post != null)
        {
            return NoContent();
        }
        return NotFound();
    }
}

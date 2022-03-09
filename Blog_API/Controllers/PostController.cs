using Blog_API.Models;
using Blog_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog_API.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly PostService _postService;

        public PostController(IConfiguration configuration)
        {
            _postService = new PostService(configuration);
        }

        [HttpGet()]
        [HttpHead]
        public ActionResult<IEnumerable<PostModel>> GetPosts([FromQuery] PostModel model)
        {
            var postsResult = _postService.GetAll();
            return Ok(postsResult.Result);
        }
    }
}

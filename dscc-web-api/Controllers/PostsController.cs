using dscc_web_api.Models;
using dscc_web_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace dscc_web_api.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository _postRepository;

        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public IActionResult GetPosts()
        {
            var posts = _postRepository.GetPosts();
            return Ok(posts);
        }

        [HttpGet("{id}", Name = "GetPost")]
        public IActionResult GetPost(int id)
        {
            var post = _postRepository.GetPostById(id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        [HttpPost]
        public IActionResult CreatePost([FromBody] Post post)
        {
            if (post == null)
            {
                return BadRequest();
            }
            _postRepository.InsertPost(post);
            return CreatedAtRoute("GetPost", new { id = post.PostId }, post);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePost(int id, [FromBody] Post post)
        {
            if (post == null || id != post.PostId)
            {
                return BadRequest();
            }
            var existingPost = _postRepository.GetPostById(id);
            if (existingPost == null)
            {
                return NotFound();
            }
            _postRepository.UpdatePost(post);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePost(int id)
        {
            var post = _postRepository.GetPostById(id);
            if (post == null)
            {
                return NotFound();
            }
            _postRepository.DeletePost(id);
            return NoContent();
        }
    }
}

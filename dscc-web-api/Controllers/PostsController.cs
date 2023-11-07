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
        public IActionResult CreatePost([FromBody] PostDto postDto)
        {
            if (postDto == null)
            {
                return BadRequest();
            }

            var post = new Post
            {
                Title = postDto.Title,
                Content = postDto.Content,
                PublicationDate = postDto.PublicationDate,
                LastUpdated = postDto.LastUpdated,
                AuthorId = postDto.AuthorId
            };

            _postRepository.InsertPost(post);
            return CreatedAtRoute("GetPost", new { id = post.PostId }, post);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePost(int id, [FromBody] PostDto postDto)
        {
            if (postDto == null)
            {
                return BadRequest();
            }

            var existingPost = _postRepository.GetPostById(id);
            if (existingPost == null)
            {
                return NotFound();
            }

            // Update properties except for PostId
            existingPost.Title = postDto.Title;
            existingPost.Content = postDto.Content;
            existingPost.PublicationDate = postDto.PublicationDate;
            existingPost.LastUpdated = postDto.LastUpdated;
            existingPost.AuthorId = postDto.AuthorId;

            _postRepository.UpdatePost(existingPost);
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

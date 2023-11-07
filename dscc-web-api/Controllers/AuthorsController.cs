using dscc_web_api.Models;
using dscc_web_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace dscc_web_api.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorsController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _authorRepository.GetAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}", Name = "GetAuthor")]
        public IActionResult GetAuthor(int id)
        {
            var author = _authorRepository.GetAuthorById(id);
            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }

        [HttpPost]
        public IActionResult CreateAuthor([FromBody] AuthorDto authorDto)
        {
            if (authorDto == null)
            {
                return BadRequest();
            }

            var author = new Author
            {
                FirstName = authorDto.FirstName,
                LastName = authorDto.LastName,
                Email = authorDto.Email,
                Biography = authorDto.Biography
            };

            _authorRepository.InsertAuthor(author);
            return CreatedAtRoute("GetAuthor", new { id = author.AuthorId }, author);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAuthor(int id, [FromBody] AuthorDto authorDto)
        {
            if (authorDto == null)
            {
                return BadRequest();
            }

            var existingAuthor = _authorRepository.GetAuthorById(id);
            if (existingAuthor == null)
            {
                return NotFound();
            }

            // Update properties except for AuthorId and Posts
            existingAuthor.FirstName = authorDto.FirstName;
            existingAuthor.LastName = authorDto.LastName;
            existingAuthor.Email = authorDto.Email;
            existingAuthor.Biography = authorDto.Biography;

            _authorRepository.UpdateAuthor(existingAuthor);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            var author = _authorRepository.GetAuthorById(id);
            if (author == null)
            {
                return NotFound();
            }
            _authorRepository.DeleteAuthor(id);
            return NoContent();
        }
    }
}

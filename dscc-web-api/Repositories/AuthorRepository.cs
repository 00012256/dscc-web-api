using dscc_web_api.DbContexts;
using dscc_web_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dscc_web_api.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly BlogDbContext _context;

        public AuthorRepository(BlogDbContext context)
        {
            _context = context;
        }

        public void InsertAuthor(Author author)
        {
            if (author == null)
            {
                throw new ArgumentNullException(nameof(author));
            }

            _context.Authors.Add(author);
            Save();
        }

        public void UpdateAuthor(Author author)
        {
            if (author == null)
            {
                throw new ArgumentNullException(nameof(author));
            }

            _context.Authors.Update(author);
            Save();
        }

        public void DeleteAuthor(int authorId)
        {
            var author = _context.Authors.Find(authorId);
            if (author != null)
            {
                _context.Authors.Remove(author);
                Save();
            }
        }

        public Author? GetAuthorById(int authorId)
        {
            var author = _context.Authors.Find(authorId);

            if (author != null)
            {
                _context.Entry(author).Collection(a => a.Posts).Load();
            }

            return author;
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _context.Authors
                .Include(a => a.Posts)
                .ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

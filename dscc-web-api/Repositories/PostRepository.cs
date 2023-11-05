using dscc_web_api.DbContexts;
using dscc_web_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dscc_web_api.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogDbContext _context;

        public PostRepository(BlogDbContext context)
        {
            _context = context;
        }

        public void InsertPost(Post post)
        {
            if (post == null)
            {
                throw new ArgumentNullException(nameof(post));
            }

            _context.Posts.Add(post);
            Save();
        }

        public void UpdatePost(Post post)
        {
            if (post == null)
            {
                throw new ArgumentNullException(nameof(post));
            }

            _context.Posts.Update(post);
            Save();
        }

        public void DeletePost(int postId)
        {
            var post = _context.Posts.Find(postId);
            if (post != null)
            {
                _context.Posts.Remove(post);
                Save();
            }
        }

        public Post GetPostById(int postId)
        {
            var post = _context.Posts.Find(postId);
            _context.Entry(post).Reference(a => a.Author).Load();
            return post;
        }

        public IEnumerable<Post> GetPosts()
        {
            return _context.Posts
                .Include(p => p.Author)
                .ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

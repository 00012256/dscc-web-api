using dscc_web_api.Models;

namespace dscc_web_api.Repositories
{
    public interface IPostRepository
    {
        void InsertPost(Post post);
        void UpdatePost(Post post);
        void DeletePost(int postId);
        Post GetPostById(int Id);
        IEnumerable<Post> GetPosts();
    }
}

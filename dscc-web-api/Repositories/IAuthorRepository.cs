using dscc_web_api.Models;

namespace dscc_web_api.Repositories
{
    public interface IAuthorRepository
    {
        void InsertAuthor(Author author);
        void UpdateAuthor(Author author);
        void DeleteAuthor(int authorId);
        Author? GetAuthorById(int Id);
        IEnumerable<Author> GetAuthors();
    }
}

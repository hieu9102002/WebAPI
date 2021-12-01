using WebAPI.Models;

namespace WebAPI.Services.Interfaces
{
    public interface IBookService
    {
        public Task<List<Book>> GetAll();
        public Task<Book?> Get(int id);
        public void Add(Book picture);
        public void Delete(int id);
        public void Update(Book picture);
    }
}

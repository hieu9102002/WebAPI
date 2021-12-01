using WebAPI.Models;

namespace WebAPI.Services.Interfaces
{
    public interface IPictureService
    {
        public Task<List<Picture>> GetAll();
        public Task<Picture?> Get(int id);
        public void Add(Picture picture);
        public void Delete(int id);
        public void Update(Picture picture);
    }
}

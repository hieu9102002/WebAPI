using WebAPI.Models;

namespace WebAPI.Services.Interfaces
{
    public interface ISeriesService
    {
        public Task<List<Series>> GetAll();
        public Task<Series?> Get(int id);
        public Task Add(Series series);
        public Task Delete(int id);
        public Task Update(Series series);
    }
}

using WebAPI.Models;
using WebAPI.Services.Interfaces;
using WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Services
{
    public class SeriesService : ISeriesService
    {
        private readonly BlogDBContext _dbContext;
        public SeriesService(BlogDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task Add(Series series)
        {
            //Series seriesToAdd = new Series(); 
            //seriesToAdd.Name = series.Name;
            //seriesToAdd.Description = series.Description;
            //seriesToAdd.Rating = series.Rating;
            _dbContext.Series.Add(series);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            _dbContext.Series.Remove(await Get(id));
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Series?> Get(int id)
        {
            return await _dbContext.Series.FindAsync(id);
        }

        public async Task<List<Series>> GetAll()
        {
            return await _dbContext.Series.ToListAsync();
        }

        public async Task Update(Series series)
        {
            _dbContext.Series.Update(series);
            await _dbContext.SaveChangesAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.Services.Interfaces;
using WebAPI.Models.ViewModels;
using System.Data;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private readonly ISeriesService _service;

        public SeriesController(ISeriesService service)
        {
            _service = service;
        }

        // GET: api/Series
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Series>>> GetSeries()
        {
            return await _service.GetAll();
        }

        // GET: api/Series/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Series>> GetSeries(int id)
        {
            var series = await _service.Get(id);

            if (series == null)
            {
                return NotFound();
            }

            return series;
        }

        // PUT: api/Series/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeries(int id, SeriesInsertViewModel series)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newSeries = new Series();
                    newSeries.Id = id;
                    newSeries.Name = series.Name;
                    newSeries.Rating = series.Rating;
                    newSeries.Description = series.Description;
                    await _service.Update(newSeries);
                    return NoContent();
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes.");
            }

            return BadRequest();
        }

        // POST: api/Series
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Series>> PostSeries(SeriesInsertViewModel series)
        {
            if (ModelState.IsValid)
            {
                var newSeries = new Series();
                newSeries.Name = series.Name;
                newSeries.Rating = series.Rating;
                newSeries.Description = series.Description;

                await _service.Add(newSeries);
                return CreatedAtAction("GetSeries", new { id = series.Id }, series);
            }
            return BadRequest();
        }

        // DELETE: api/Series/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeries(int id)
        {
            var series = await _service.Get(id);
            if (series == null)
            {
                return NotFound();
            }

            await _service.Delete(id);

            return NoContent();
        }
    }
}

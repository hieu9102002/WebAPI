using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int SeriesId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FinishDate { get; set; }

        public int? Rating { get; set; }
        public string? Description { get; set; }

        public virtual Series? Series { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}

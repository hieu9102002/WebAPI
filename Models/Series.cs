using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace WebAPI.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Rating { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}

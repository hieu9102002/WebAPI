using System.ComponentModel.DataAnnotations;


namespace WebAPI.Models
{
    public class Picture
    {
        public int Id { get; set; }
        [DataType(DataType.ImageUrl)]
        [Required]
        public string Link { get; set; }
        public int BookId { get; set; }

        public virtual Book Book { get; set; }

    }
}

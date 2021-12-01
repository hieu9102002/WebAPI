using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.ViewModels
{
    public class SeriesInsertViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? Rating { get; set; }
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
    }
}

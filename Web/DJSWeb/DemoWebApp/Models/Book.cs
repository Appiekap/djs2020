using System;
using System.ComponentModel.DataAnnotations;

namespace DemoWebApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Awesome title of the book")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Written by")]
        [Required]
        public string Author { get; set; }

        [Display(Name = "Publish Date")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
    }
}
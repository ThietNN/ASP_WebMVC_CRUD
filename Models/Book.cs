using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_CRUD.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Category Category { get; set; }

        [DisplayName("Published Date")]
        [Required]
        public DateTime PublishedDate { get; set; } = DateTime.Now;
    }
}

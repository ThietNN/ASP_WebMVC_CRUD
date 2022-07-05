using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_CRUD.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [DisplayName("Display Order")]
        [Range(1,10,ErrorMessage ="Display Order can only be a number between 1 and 10")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}

using System.ComponentModel.DataAnnotations;

namespace MvcCRUD.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public int displayOrder { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;


    }
}

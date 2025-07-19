using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo.Models
{
    public class Author
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [MaxLength(255)]
        [Required]
        public string Email { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<Article> Articles { get; set; } = new List<Article>();
        // Navigation property to the Comments entity
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}

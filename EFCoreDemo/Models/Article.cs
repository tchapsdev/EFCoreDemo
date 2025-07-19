using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo.Models
{
    public class Article
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Title { get; set; } = string.Empty;

        [MaxLength(1500)]
        [Required]
        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!; // Navigation property to the Category entity

        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!; // Navigation property to the Author entity

        public List<Comment> Comments { get; set; } = new List<Comment>(); // Navigation property to the Comment entity

    }
}

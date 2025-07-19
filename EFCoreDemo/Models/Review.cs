using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.Models
{
    [Table("ReviewTable")]
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ReviewKey")]
        public int ReviewKey { get; set; }

        public int? ArticleId { get; set; }

        public Article? Article { get; set; } = null!; // Navigation property to the Article entity

        public int? AuthorId { get; set; }

        public Author? Author { get; set; } = null!; // Navigation property to the Author entity

        public int Rating { get; set; } // Rating out of 5

        [MaxLength(500)]
        public string Comment { get; set; } = string.Empty; // Optional comment about the article

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Timestamp of when the review was created
    }
}

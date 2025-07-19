using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(500)]
        [Required]
        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int ArticleId { get; set; }
        public Article Article { get; set; } = null!; // Navigation property to the Article entity

        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!; // Navigation property to the Author entity
    }
}

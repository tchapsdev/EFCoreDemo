using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<Article> Articles { get; set; } = new List<Article>();
        // Navigation property to the Comments entity
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}

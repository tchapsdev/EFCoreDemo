namespace EFCoreDemo.Models
{
    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!; // Navigation property to the Category entity

        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!; // Navigation property to the Author entity

        public List<Comment> Comments { get; set; } = new List<Comment>(); // Navigation property to the Comment entity

    }
}

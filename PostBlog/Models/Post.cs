using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PostBlog.Models
{

    [Table("Postlar")]
    public class Post
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public DateTime CreatedTime { get; set; }
        [Required]
        public string ImageFileName { get; set; }
    }
}

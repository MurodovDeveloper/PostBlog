using System.ComponentModel.DataAnnotations;

namespace PostBlog.ViewModels
{
    public class BlogCreateViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public IFormFile ImageFile { get; set;}
    }
}

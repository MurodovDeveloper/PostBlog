using PostBlog.Models;

namespace PostBlog.Services
{
    public interface IPostService
    {
        public List<Post> GetAllPosts();

        public Post GetById(Guid id);
        public Post AddPost(Post newPost);
        public Post UpdatePost(Post post);
        public void DeletePost(Guid id);
        public string SaveImage(IFormFile newFile);

    }
}

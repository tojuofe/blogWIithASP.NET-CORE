using Microsoft.AspNetCore.Http;

namespace WebBlog.ViewModels
{
  public class BlogViewModel
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public IFormFile ImageFile { get; set; }
  }
}
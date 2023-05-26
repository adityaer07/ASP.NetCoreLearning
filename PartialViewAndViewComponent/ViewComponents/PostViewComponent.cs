using Microsoft.AspNetCore.Mvc;
using PartialViewAndViewComponent.Models;
using System.Text.Json;

namespace PartialViewAndViewComponent.ViewComponents
{
    public class PostViewComponent : ViewComponent
    {
        private readonly HttpClient _httpclient;
        
        public PostViewComponent(HttpClient httpclient)
        {
            _httpclient = httpclient;
        }
        public async Task<IViewComponentResult> InvokeAsync(int postId)
        {
            var response = await _httpclient.GetAsync("https://jsonplaceholder.typicode.com/posts/" + postId + "/comments");

            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadAsStringAsync();

            var post = JsonSerializer.Deserialize<List<PostViewComponentModel>>(data);

            return View(post);
        }
    }
}

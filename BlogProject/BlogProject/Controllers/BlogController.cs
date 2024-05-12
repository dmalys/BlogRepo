using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetLatestBlogPost()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBlogPost(string blogPost)
        {


            return Ok();
        }



    }
}

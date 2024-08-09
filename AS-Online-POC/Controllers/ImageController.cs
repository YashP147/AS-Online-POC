using System.Web.Http;

namespace WebApp.Controllers
{
    public class ImageController : ApiController
    {
        [HttpGet]
        [Route("api/image")]
        public string Get()
        {
            return "value";
        }

        [HttpGet]
        [Route("api/image/hello")]
        public string Hello()
        {
            return "hello";
        }
    }
}
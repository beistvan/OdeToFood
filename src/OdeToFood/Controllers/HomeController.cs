using Microsoft.AspNet.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ContentResult Index()
        {            
            return Content("Hello, from a controller!");
        }
    }
}

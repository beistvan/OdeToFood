using Microsoft.AspNet.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var model = new Reastaurant { Id = 1, Name = "Sabatino's"};
            return View();
        }
    }
}

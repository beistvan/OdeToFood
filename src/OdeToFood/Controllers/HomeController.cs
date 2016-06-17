﻿using Microsoft.AspNet.Mvc;
using OdeToFood.ViewModels;
using OdeToFood.Services;
using OdeToFood.Entities;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private IRestaurantData _restaurantData;

        public HomeController(
            IRestaurantData restaurantData,
            IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }
        public ViewResult Index()
        {
            var model = new HomePageViewModel();
            model.Restaurants =_restaurantData.GetAll();
            model.CurrentGreeting = _greeter.GetGreeting();

            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Create(RestaurantEditViewModel model)
        {
            var restaurant = new Restaurant();

            restaurant.Name = model.Name;
            restaurant.Cuisine = model.Cuisine;

            _restaurantData.Add(restaurant);

            return View("Details", restaurant);
        }
        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if(model == null)
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}

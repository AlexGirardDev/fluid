using System.Collections.Generic;
using Fluid.MvcSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fluid.MvcSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<Person>();
            model.Add(new Person { Firstname = "Bill", Lastname = "Gates" });
            model.Add(new Person { Firstname = "Steve", Lastname = "Balmer" });
            model.Add(new Person {Firstname = new string(Enumerable.Range(0, 5_000).Select(_ => 'a').ToArray()), Lastname = "Gates"});
            ViewData["Title"] = "This is a title";

            return View(model);
        }    
    }    
}

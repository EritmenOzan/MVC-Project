using Microsoft.AspNetCore.Mvc;
using OzanAkademi.Models;


namespace OzanAkademi.Controllers
{
    public class CourseController :Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
         public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
         public IActionResult Apply([FromForm] Candidate model)
        {
            if(ModelState.IsValid)
            {
             Repository.Add(model);
            return View("Feedback",model);
            }
           return View();
        }
    }

}
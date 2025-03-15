
using KursKayıtSıstemı.Models;
using Microsoft.AspNetCore.Mvc;

namespace KursKayıtSıstemı.Controllers
{
    public class CourseController: Controller
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
     
        public IActionResult Apply([FromForm] Candidate model)
        {
            
            
            Repository.Add(model);
            return View("feedback", model);
        }
  
    }
    
}
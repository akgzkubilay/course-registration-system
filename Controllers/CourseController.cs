
using Microsoft.AspNetCore.Mvc;

namespace KursKayıtSıstemı.Controllers
{
    public class CourseController: Controller
    { 
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }
  
    }
    
}
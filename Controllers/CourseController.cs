using coreuygulama.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreuygulama.Controllers
{
    public class CourseController : Controller
    {
        

        public IActionResult Index()
        {/* buna gittiğinde index açılır course dosyasında ki index buradan oluşturulan bir html */
            ViewBag.Selamlama = "Nas";
            return View();
        }
        [HttpGet]
        public IActionResult Apply()
        { /*buna gittiğinde ise apply açılır */
            return View();
        }
        [HttpPost]
        public IActionResult Apply(Student s)
        {/* burası bir get metodu aslında yani ad soyad olan verileri getirme yeri */
            //buna gittiğinde ise apply açılır

            if (ModelState.IsValid)
            {
                Repository.AddStudent(s);
                return View("Thanks", s);
            }
            else
            {
                return View();
            }
            
        }
        public IActionResult List()
        {
            var student = Repository.Students;
            return View(student);
        }
    }
}
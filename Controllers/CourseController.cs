using Microsoft.AspNetCore.Mvc;

namespace studmanagementsystemv1._3.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult CourseForm()
        {
            return View();
        }
    }
}

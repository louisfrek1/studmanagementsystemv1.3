using Microsoft.AspNetCore.Mvc;

namespace studmanagementsystemv1._3.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult InstructorForm()
        {
            return View();
        }
    }
}

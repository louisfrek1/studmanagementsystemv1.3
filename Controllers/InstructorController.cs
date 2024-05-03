using Microsoft.AspNetCore.Mvc;

namespace studmanagementsystemv13.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult InstructorForm()
        {
            return View();
        }
    }
}

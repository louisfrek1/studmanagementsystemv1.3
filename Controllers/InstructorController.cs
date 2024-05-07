using Microsoft.AspNetCore.Mvc;
using studmanagementsystemv13.Models;
using studmanagementsystemv13.Models;

namespace studmanagementsystemv13.Controllers
{
    public class InstructorController : Controller
    {
        private readonly InstructorContext _instructorContext;

        public InstructorController(InstructorContext instructorContext)
        {
            _instructorContext = instructorContext;
        }

        public IActionResult InstructorForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InstructorForm(Instructor instructor)
        {
            bool isSuccess = _instructorContext.InsertInstructor(instructor);

            if (ModelState.IsValid)
            {
                if (isSuccess)
                {
                    TempData["SuccessMessage"] = "NAKA SAVE RA JUDDDDDDD!!";
                }
                else
                {
                    TempData["ErrorMessage"] = "GI ATAY WALAAAAA";
                }
            }

            return View();
        }
    }
}

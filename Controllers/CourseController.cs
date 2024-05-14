using Microsoft.AspNetCore.Mvc;
using studmanagementsystemv13.Models;
using studmanagementsystemv13.Models;

namespace studmanagementsystemv13.Controllers
{
    public class CourseController : Controller
    {
        private readonly CourseContext _courseContext;

        public CourseController(CourseContext courseContext)
        {
            _courseContext = courseContext;
        }
        public IActionResult CourseForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CourseForm(Course course)
        {
            bool isSuccess = _courseContext.InsertCourse(course);

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

        public IActionResult CourseTable()
        {
            return View();

        }
    }

}

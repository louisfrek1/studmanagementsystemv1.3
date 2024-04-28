using Microsoft.AspNetCore.Mvc;
using studmanagementsystemv1._3.Models;

namespace studmanagementsystemv1._3.Controllers
{
    public class EnrollmentController : Controller
    {
        public readonly StudentContext _studentContext;

        //constructor

        public EnrollmentController(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }
        public IActionResult EnrollmentForm11()
        {
            return View();
        }

        public IActionResult EnrollmentForm11(Students students)
        {
            bool isSuccess = _studentContext.InsertStudent(students);

            if (isSuccess)
            {
                ViewBag.IsSuccess = true;
                ViewBag.Message = "NAKA SAVE RA JUDDDDDDD!!";
            }
            else
            {
                ViewBag.Message = "GI ATAY WALAAAAA";
            }

            return View(students);
        }
    }
}

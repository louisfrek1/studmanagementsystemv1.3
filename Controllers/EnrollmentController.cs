using Microsoft.AspNetCore.Mvc;
using studmanagementsystemv13.Models;

public class EnrollmentController : Controller
{
    private readonly StudentContext _studentContext;

    public EnrollmentController(StudentContext studentContext)
    {
        _studentContext = studentContext;
    }

    public IActionResult EnrollmentForm11()
    {
        return View();
    }

    [HttpPost]
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

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

    public IActionResult EnrollmentForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult EnrollmentForm11(Students students)
    {
        bool isSuccess = _studentContext.InsertStudent(students);

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

    [HttpPost]
    public IActionResult EnrollmentForm(Students students)
    {
        bool isSuccess = _studentContext.InsertStudentni(students);

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

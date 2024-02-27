using Egzamin2023TestJakubWasylik.Models;
using Microsoft.AspNetCore.Mvc;

namespace Egzamin2023TestJakubWasylik.Controllers
{
    public class GradeController : Controller
    {
        private static List<Grade> grades = new List<Grade>();

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult IndexOceny()
        {
            return View(grades);
        }

        public IActionResult AddGrade()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddGrade(Grade grade)
        {
            if (grades.Exists(g => g.NumerStudenta == grade.NumerStudenta && g.Przedmiot == grade.Przedmiot))
            {
                return BadRequest("Student już posiada ocenę z tego przedmiotu!!!");
            }

            grade.Data = DateTime.Now;
            grades.Add(grade);
            return RedirectToAction("IndexOceny");
        }

        public IActionResult Student(int numerStudenta)
        {
            var studentGrades = grades.FindAll(g => g.NumerStudenta == numerStudenta);
            return View(studentGrades);
        }
    }
}

using crud_app1.Data;
using crud_app1.Models;
using Microsoft.AspNetCore.Mvc;

namespace crud_app1.Controllers
{
    public class DepartmentController : Controller
    {
        ApplicationDbContext Context = new ApplicationDbContext();
        // to read data we use index action 
        public IActionResult Index()
        {
            var departments = Context.Departments.ToList();
            return View("Index", departments);
        }

        public IActionResult Details(int id)
        {
            var departments = Context.Departments.Find(id);

            return View("Details", departments);
        }
        public IActionResult Create()
        {
            return View("Create");
        }

        public IActionResult Store(Department departments)
        {

            Context.Departments.Add(departments);
            Context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {

            var department = Context.Departments.Find(id);
            Context.Departments.Remove(department);
            Context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}

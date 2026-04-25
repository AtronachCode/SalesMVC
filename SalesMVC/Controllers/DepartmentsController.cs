using Microsoft.AspNetCore.Mvc;
using SalesMVC.Models;

namespace SalesMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> department = new List<Department>();
            department.Add(new Department{ IdDepartmet = 1 , Name = "Eletronicos"});
            department.Add(new Department { IdDepartmet = 2, Name = "Roupas" });
            department.Add(new Department { IdDepartmet = 3, Name = "Lanches" });

            return View(department);
        }
    }
}

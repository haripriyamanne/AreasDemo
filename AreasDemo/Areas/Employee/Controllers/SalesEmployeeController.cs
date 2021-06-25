using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreasDemo.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class SalesEmployeeController : Controller
    {
        [HttpGet]

        public IActionResult GetEmployeeListByLocation(int locationID)
        {
            Models.Employee[] employees = new Models.Employee[] {
                new Models.Employee
                {
                    ID = 1,
                    Name = "Hari",
                    Designation="Manager",
                    LocationID=1
                },
                new Models.Employee
                {
                    ID = 2,
                    Name = "Priya",
                    Designation="Developer",
                    LocationID=1
                },
                new Models.Employee
                {
                    ID = 3,
                    Name = "Latha",
                    Designation="CEO",
                    LocationID=2
                },
                 new Models.Employee
                {
                    ID = 4,
                    Name = "Janu",
                    Designation="CEO",
                    LocationID=3
                },
            };

            Models.Employee[] empList =
                employees.Where(item => item.LocationID == locationID).ToArray();

            return View(empList);
        }
    }
}

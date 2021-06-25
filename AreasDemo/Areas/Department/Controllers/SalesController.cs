using AreasDemo.Areas.Department.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreasDemo.Areas.Department.Controllers
{
        [Area("Department")]
        public class SalesController : Controller
        {
            public IActionResult Index()
            {
                Location[] salesLocation = new Location[] {
                new Location
                {
                    ID = 1,
                    Address = "A Road",
                    City = "India"
                },
                new Location
                {
                    ID = 2,
                    Address = "B Road",
                    City = "London"
                },
                new Location
                {
                    ID = 3,
                    Address = "C Road",
                    City = "New York"
                },
            };
                return View(salesLocation);
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Training_Project__List_of_expenses_and_List_of_debt_obligations_.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details([FromQuery] int id,[FromQuery] string name)
        {
            return View($"Hello, id = {id} and name = {name}");
        }
    }
}
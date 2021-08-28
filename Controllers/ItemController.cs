using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Training_Project__List_of_expenses_and_List_of_debt_obligations_.Domain;
using Training_Project__List_of_expenses_and_List_of_debt_obligations_.Models;

namespace Training_Project__List_of_expenses_and_List_of_debt_obligations_.Controllers
{
    public class ItemController : Controller
    {
        private readonly AppDbContext _context;

        public ItemController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objList = _context.ItemsTable;
            return View(objList);
        }
    }
}
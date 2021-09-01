using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Training_Project__List_of_expenses_and_List_of_debt_obligations_.Domain;
using Training_Project__List_of_expenses_and_List_of_debt_obligations_.Models;

namespace Training_Project__List_of_expenses_and_List_of_debt_obligations_.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly AppDbContext _context;

        public ExpenseController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Expense> objList = _context.Expenses;

            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Expense obj)
        {
            if(ModelState.IsValid)
            {
                await _context.Expenses.AddAsync(obj);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
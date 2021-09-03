using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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


        //Get Delete
        public async Task<IActionResult> Delete(int? id)
        {
            var obj = await _context.Expenses.FindAsync(id);
            if (obj == null || id == 0 || id == null)
                return NotFound();

            return View(obj);
        }

        //Post Delete
        [HttpPost]
        public async Task<IActionResult> DeletePost(int? id)
        {
            var obj =  await _context.Expenses.FindAsync(id);
            if (obj == null)
                return NotFound();

            _context.Expenses.Remove(obj);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        //Get Update
        public async Task<IActionResult> Update(int? id)
        {
            var obj = await _context.Expenses.FindAsync(id);
            if (obj == null || id == null)
                return NotFound();

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Expense obj)
        {
            if (ModelState.IsValid)
            {
                _context.Expenses.Update(obj);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
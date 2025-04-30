using ExpenseTrackerAPI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using ExpenseTrackerAPI.Services;

namespace ExpenseTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpensesController : Controller
    {
        [HttpGet]
        public IActionResult GetAllExpenses()
        {
            var expenses = ExpensesService.GetAllExpenses();
            return Ok(expenses);
        }

        [HttpGet("{id}")]
        public IActionResult GetExpensesById(int id)
        {
            var expense = ExpensesService.GetById(id);
            if (expense == null)
            {
                return NotFound(new { message = $"Expense with ID {id} not found." });
            }
            return Ok(expense);
        }

        [HttpPost]
        public IActionResult AddExpense(ExpenseDto expense)
        {
            var addedExpense = ExpensesService.Add(expense);            
            return Ok(new { Message = "Expense added successfully!", Expense = expense });
        }
    }


}

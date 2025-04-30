using ExpenseTrackerAPI.Models.DTOs;

namespace ExpenseTrackerAPI.Services
{
    public static class ExpensesService
    {
        private static readonly List<ExpenseDto> _expenses = Expenses.MyExpenses;

        public static List<ExpenseDto> GetAllExpenses() 
        {
            return _expenses;
        }

        public static ExpenseDto? GetById(int id)
        {
            return _expenses.FirstOrDefault(x => x.Id == id);
        }

        public static ExpenseDto Add(ExpenseDto expense)
        {
            expense.Id = _expenses.Any() ? _expenses.Max(x => x.Id) + 1 : 1;
            _expenses.Add(expense);
            return expense;
        }
    }
}

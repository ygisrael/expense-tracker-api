namespace ExpenseTrackerAPI.Models.DTOs
{
    public class ExpenseDto
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string? Category { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
    }

    public static class Expenses
    {
        public static List<ExpenseDto> MyExpenses =>
            [
                new() { Id = 1, Amount = 50, Category = "Food", Date = DateTime.Now, Description = "Lunch" },
                new() { Id = 2, Amount = 100, Category = "Transport", Date = DateTime.Now, Description = "Bus pass" },
            ];
    }
}

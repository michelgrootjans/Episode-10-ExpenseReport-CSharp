using ExpenseReport.ConsoleApp.Expenses;

namespace ExpenseReport.ConsoleApp.Reports
{
    public class ExpenseReportNamer : IExpenseNamer
    {
        public string GetName(Expense expense)
        {
            if (expense is DinnerExpense)
                return "Dinner";
            if (expense is BreakfastExpense)
                return "Breakfast";
            if (expense is CarRentalExpense)
                return "Car Rental";
            return "TILT";
        }
    }
}
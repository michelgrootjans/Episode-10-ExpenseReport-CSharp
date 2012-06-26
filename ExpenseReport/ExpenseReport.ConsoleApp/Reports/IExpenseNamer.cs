using ExpenseReport.ConsoleApp.Expenses;

namespace ExpenseReport.ConsoleApp.Reports
{
    public interface IExpenseNamer
    {
        string GetName(Expense expense);
    }
}
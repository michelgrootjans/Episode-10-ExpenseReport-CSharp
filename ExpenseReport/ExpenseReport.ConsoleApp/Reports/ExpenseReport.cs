using System.Collections.Generic;
using ExpenseReport.ConsoleApp.Expenses;

namespace ExpenseReport.ConsoleApp.Reports
{
    public class ExpenseReport
    {
        private readonly List<Expense> expenses = new List<Expense>();
        private int total;
        private int mealExpenses;

        public ExpenseReport()
        {
            total = 0;
            mealExpenses = 0;
        }

        public void TotalUpExpenses()
        {
            foreach (var expense in expenses)
                AddToTotals(expense);
        }

        private void AddToTotals(Expense expense)
        {
            if (expense.IsMeal())
                mealExpenses += expense.GetAmount();
            total += expense.GetAmount();
        }

        public int GetMealExpenses()
        {
            return mealExpenses;
        }

        public int GetTotal()
        {
            return total;
        }

        public void AddExpense(Expense expense)
        {
            expenses.Add(expense);
        }

        public List<Expense> GetExpenses()
        {
            return expenses;
        }
    }
}
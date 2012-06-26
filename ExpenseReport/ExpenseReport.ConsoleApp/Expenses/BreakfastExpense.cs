namespace ExpenseReport.ConsoleApp.Expenses
{
    public class BreakfastExpense : Expense
    {
        public BreakfastExpense(int amount) : base(amount)
        {
        }

        public override bool IsOverage()
        {
            return GetAmount() > 1000;
        }

        public override bool IsMeal()
        {
            return true;
        }
    }
}
namespace ExpenseReport.ConsoleApp.Expenses
{
    public class DinnerExpense : Expense
    {
        public DinnerExpense(int amount) : base(amount)
        {
        }

        public override bool IsOverage()
        {
            return GetAmount() > 5000;
        }

        public override bool IsMeal()
        {
            return true;
        }
    }
}
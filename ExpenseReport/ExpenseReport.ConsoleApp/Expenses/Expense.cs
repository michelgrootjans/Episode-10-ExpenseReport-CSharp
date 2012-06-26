namespace ExpenseReport.ConsoleApp.Expenses
{
    public abstract class Expense
    {
        private readonly int amount;

        protected Expense(int amount)
        {
            this.amount = amount;
        }

        public int GetAmount()
        {
            return amount;
        }

        public abstract bool IsOverage();

        public abstract bool IsMeal();
    }
}
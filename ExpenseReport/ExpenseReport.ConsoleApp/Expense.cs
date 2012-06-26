namespace ExpenseReport.ConsoleApp
{
    public enum ExpenseType
    {
        Dinner,
        Breakfast,
        CarRental
    } ;
    
    public class Expense
    {
        public ExpenseType type;
        public int amount;

        public Expense(ExpenseType type, int amount)
        {
            this.type = type;
            this.amount = amount;
        }
    }
}
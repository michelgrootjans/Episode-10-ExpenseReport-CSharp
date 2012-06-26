using ExpenseReport.ConsoleApp.Expenses;
using ExpenseReport.ConsoleApp.Printers;

namespace ExpenseReport.ConsoleApp.Reports
{
    public class ExpenseReporter
    {
        private IReportPrinter printer;
        private readonly ExpenseReport report;
        private readonly IExpenseNamer namer = new ExpenseReportNamer();

        public ExpenseReporter(ExpenseReport report)
        {
            this.report = report;
        }

        public void PrintReport(IReportPrinter printer)
        {
            this.printer = printer;
            report.TotalUpExpenses();
            PrintExpensesAndTotals();
        }

        private void PrintExpensesAndTotals()
        {
            PrintHeader();
            PrintExpenses();
            PrintTotals();
        }

        private void PrintHeader()
        {
            printer.Print("Expenses " + GetDate() + "\n");
        }

        private void PrintExpenses()
        {
            foreach (var expense in report.GetExpenses())
                PrintExpense(expense);
        }

        private void PrintExpense(Expense expense)
        {
            printer.Print(string.Format("{0}\t{1}\t{2}\n",
                                        expense.IsOverage() ? "X" : " ",
                                        namer.GetName(expense),
                                        PenniesToDollars(expense.GetAmount())));
        }

        private void PrintTotals()
        {
            printer.Print(string.Format("\nMeal expenses {0}",
                                        PenniesToDollars(report.GetMealExpenses())));
            printer.Print(string.Format("\nTotal {0}",
                                        PenniesToDollars(report.GetTotal())));
        }

        private double PenniesToDollars(int pennies)
        {
            return pennies/100.0;
        }

        private string GetDate()
        {
            return "9/12/2002";
        }
    }
}
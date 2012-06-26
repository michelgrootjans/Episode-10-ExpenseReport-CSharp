using ExpenseReport.ConsoleApp.Expenses;
using ExpenseReport.ConsoleApp.Printers;
using ExpenseReport.ConsoleApp.Reports;

namespace ExpenseReport.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            var report = new Reports.ExpenseReport();
            report.AddExpense(new BreakfastExpense(545));
            report.AddExpense(new DinnerExpense(674));
            report.AddExpense(new CarRentalExpense(46374));

            var reporter = new ExpenseReporter(report);
            reporter.PrintReport(new ConsoleReportPrinter());
        }
    }
}
﻿namespace ExpenseReport.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            var report = new ExpenseReport();
            report.AddExpense(new Expense(ExpenseType.Breakfast, 525));
            report.AddExpense(new Expense(ExpenseType.Breakfast, 400));
            report.AddExpense(new Expense(ExpenseType.Breakfast, 500));
            report.AddExpense(new Expense(ExpenseType.Breakfast, 1050));
            report.AddExpense(new Expense(ExpenseType.CarRental, 5600));
            report.AddExpense(new Expense(ExpenseType.Dinner, 4800));
            report.AddExpense(new Expense(ExpenseType.Dinner, 5400));

            report.PrintReport(new ConsoleReportPrinter());
        }
    }
}
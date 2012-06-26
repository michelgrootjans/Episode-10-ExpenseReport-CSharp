using System;
using System.Collections.Generic;

namespace ExpenseReport.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            var report = new ExpenseReport();
            report.AddExpense(new Expense(ExpenseType.Breakfast, 525));
            report.AddExpense(new Expense(ExpenseType.Breakfast, 400));
            report.AddExpense(new Expense(ExpenseType.Breakfast, 500));
            report.AddExpense(new Expense(ExpenseType.CarRental, 5600));
            report.AddExpense(new Expense(ExpenseType.Dinner, 1400));

            report.PrintReport(new ConsoleReportPrinter());
        }
    }

    internal class ConsoleReportPrinter : IReportPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

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

    public interface IReportPrinter
    {
        void Print(string text);
    }

    public class ExpenseReport
    {
        private readonly List<Expense> expenses = new List<Expense>();

        public void PrintReport(IReportPrinter printer)
        {
            var total = 0;
            var mealExpenses = 0;

            printer.Print("Expenses " + GetDate() + "\n");

            foreach (var expense in expenses)
            {
                if (expense.type == ExpenseType.Breakfast || expense.type == ExpenseType.Dinner)
                    mealExpenses += expense.amount;

                var name = "TILT";
                switch (expense.type)
                {
                    case ExpenseType.Dinner:
                        name = "Dinner";
                        break;
                    case ExpenseType.Breakfast:
                        name = "Breakfast";
                        break;
                    case ExpenseType.CarRental:
                        name = "Car Rental";
                        break;
                }
                printer.Print(String.Format("{0}\t{1}\t${2}\n",
                                            ((expense.type == ExpenseType.Dinner && expense.amount > 5000)
                                             || (expense.type == ExpenseType.Breakfast && expense.amount > 1000))
                                                ? "X"
                                                : " ",
                                            name, expense.amount/100.0));

                total += expense.amount;
            }

            printer.Print(String.Format("\nMeal expenses {0}", mealExpenses/100.0));
            printer.Print(String.Format("\nTotal {0}", total/100.0));
        }

        public void AddExpense(Expense expense)
        {
            expenses.Add(expense);
        }

        private String GetDate()
        {
            return "9/12/2002";
        }
    }
}
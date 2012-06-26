using System;

namespace ExpenseReport.ConsoleApp
{
    internal class ConsoleReportPrinter : IReportPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
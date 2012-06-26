using System;

namespace ExpenseReport.ConsoleApp.Printers
{
    internal class ConsoleReportPrinter : IReportPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
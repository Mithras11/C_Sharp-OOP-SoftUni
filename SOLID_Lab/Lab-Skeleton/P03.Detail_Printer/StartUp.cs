namespace P03.DetailPrinter
{
    using System;
    using System.Collections.Generic;
    using Models;


    public class StartUp
    {
        static void Main()
        {
            var employee = new Employee("Employee");
            var manager = new Manager("Manager", new[] { "Doc 1", "Doc 2", "Doc 3" });
            var detailsPrinter = new DetailsPrinter(new List<Employee>(new[] { employee, manager }));
            Console.WriteLine(detailsPrinter.PrintDetails());
        }
    }
}

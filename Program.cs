using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company NSS = new Company("NSS", DateTime.Parse("01/01/2010"));
            // Create three employees
            Employee Steve = new Employee("Steve", "Brownlee", "Head Coach", DateTime.Parse("01/01/2010"));
            Employee Scott = new Employee("Scott", "Silver", "Junior Instructor", DateTime.Parse("10/01/2020"));
            Employee Hannah = new Employee("Hannah", "Hall", "Lead Instructor", DateTime.Parse("01/01/2020"));
            // Assign the employees to the company
            NSS.employees.Add(Steve);
            NSS.employees.Add(Scott);
            NSS.employees.Add(Hannah);

            NSS.ListEmployees();
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}

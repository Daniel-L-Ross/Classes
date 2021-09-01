using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }
        
        public List<Employee> employees = new List<Employee>();

        public Company (string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }

        public void ListEmployees()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($@"{employee.First} {employee.First} works for {Name} as {employee.Title} since {employee.StartDate}.");
            } 
        }
        
    }
}

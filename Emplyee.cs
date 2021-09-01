using System;

namespace Classes
{
    public class Employee
    {
        public string Last;
        public string First;
        public string Title;
        public DateTime StartDate;

        public Employee(string firstName, string lastName, string title, DateTime startDate)
        {
            Last = lastName;
            First = firstName;
            Title = title;
            StartDate = startDate;

        }
        public string Name { get; }
        public DateTime CreatedOn { get; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary {
            get => _salary;
            protected set => _salary = value;
        }
        private double _salary { get; set; }

        public Employee()
        {

        }
        public Employee(string name, string position, double salary)
        {
            Name = name;
            Position = position;
            if(salary >= 0)
            {
                _salary = salary;
            }
        }
        public virtual void CalSalary()
        {
            _salary = _salary * 0.1 + _salary;
        }
    }
}

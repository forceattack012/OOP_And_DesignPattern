using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class SeniorEmployee : Employee
    {
        public SeniorEmployee()
        {
        }

        public SeniorEmployee(string name, string position, double salary) : base(name, position, salary)
        {
        }
        public override void CalSalary()
        {
            Salary = Salary * 0.3 + Salary;
        }
    }
}

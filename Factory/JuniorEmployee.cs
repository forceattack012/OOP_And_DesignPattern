using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class JuniorEmployee : Employee
    {
        public JuniorEmployee()
        {
        }

        public JuniorEmployee(string name, string position, double salary) : base(name,position,salary)
        {

        }
    }
}

using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryEmployee factoryEmployee = new FactoryEmployee();
            var SeniorEmployee = factoryEmployee.GetEmployee("Senior");
            SeniorEmployee = new SeniorEmployee("A","Senior",100);
            SeniorEmployee.CalSalary();

            var JuniorEmployee = factoryEmployee.GetEmployee("Junior");
            JuniorEmployee = new JuniorEmployee("B", "Junior", 100);
            JuniorEmployee.CalSalary();
            Console.WriteLine($"Name : { SeniorEmployee.Name}, Position : { SeniorEmployee.Position}, Salary : { SeniorEmployee.Salary}");
            Console.WriteLine($"Name : { JuniorEmployee.Name}, Position : { JuniorEmployee.Position}, Salary : { JuniorEmployee.Salary}");
        }
    }
    class FactoryEmployee
    {
        public Employee GetEmployee(string position)
        {
            if (position == "Senior")
            {
                return new SeniorEmployee();
            }
            else
            {
                return new JuniorEmployee();
            }
        }
    }
}

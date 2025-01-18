using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_06_G01.Interface
{
    // Heirarchy // Overriding
    // Sealed
    // stop heirrarchy from gradchild (stop inherit from grandchild)
    internal class Parent
    {
        public virtual void Print()
        {
            Console.WriteLine("Parent");
        }
        private int salary;

        // virtual property
        public virtual int Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }
    }
    internal class Child : Parent
    {
        // sealed method
        public sealed override void Print()
        {
            Console.WriteLine("Child");
        }

        // sealed property
        public sealed override int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value + 2000; }
        }

        // Method to display the salary
        public void DisplaySalary()
        {
            Console.WriteLine($"The salary is: {Salary}");
        }
    }

}

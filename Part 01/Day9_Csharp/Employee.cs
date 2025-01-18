using Day9_Csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day_06_G01
{
    public struct Employee
    {
        //attributes 
        private int EmpID;
        private string EmpName;
        private decimal empsalary;

        //apply Encapsulation
        // getter name 
        public string GetName()
        {
            return EmpName;
        }
        // setter >>> Get only , validation
        public void SetName(string value)
        {
            EmpName = value.Length <= 20 ? value : value.Substring(0, 20);
        }

        //apply Encapsulation //Property : full
        public decimal Salary
        {
            get { return empsalary; }
            set { empsalary = value < 4000 ? 4000 : value; }
        }
        // more readable : Automatic property : attribute implicit
        //Compiler generate backing field >> hidden private attr
        // private int age;
        // IL >> backing field >> self
        public int Age { get; set; } // can't access attributes : validation

        // New Department property
        public Department Department { get; set; }

        //Constructor
        public Employee(int _id, string _Name, decimal _salary, int _Age, Department department)
        {
            EmpID = _id;
            EmpName = _Name;
            empsalary = _salary;
            Age = _Age;
            Department = department;
        }

        //Method
        public override string ToString()
        {
            return $"Emp Id is {EmpID}, Name is {EmpName}, Salary is {empsalary}, Age is {Age}, Department is {Department}";
        }

        // readonly Prop >>> Access bonus >> Column in Database
        public decimal Bonus
        {
            get { return empsalary * 0.1M; }
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return EmpID == other.EmpID && EmpName == other.EmpName && Department.Equals(other.Department);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(EmpID, EmpName, Department);
        }
    }
}


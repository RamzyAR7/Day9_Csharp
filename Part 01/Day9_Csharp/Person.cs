using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Csharp
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Department { get; set; } // Added Department property

        public void PrintDetails()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Gender: {Gender}, Department: {Department}");
        }
    }
}

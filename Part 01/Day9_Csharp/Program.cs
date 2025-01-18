using day_06_G01;
using day_06_G01.Interface;
using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Day9_Csharp
{
    #region Enums
    public enum Weekdays
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum Grades : short
    {
        A = 0,
        B = 1,
        C = 252,
        D = 253,
        E = 254,
        F = -1
    }
    enum Gender : byte
    {
        Male = 1,
        Female
    }
    enum GenderInt
    {
        Male = 1,
        Female
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem1
            // Create an enum called Weekdays with values Monday = 1, Tuesday, Wednesday,
            // Thursday, Friday.Write a program to print the name and value of each day.

            //foreach (var day in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine($"name = {day}, value = {(int)day}");
            //}
            #endregion

            #region Problem2
            // Modify the Grades enum from the demo to use short as its underlying type and set F to -
            // 1.Write code to print all grade values and their names.

            //foreach (var grade in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"name = {grade}, value = {(short)grade}");
            //}

            #endregion

            #region Problem3
            // Add a Department property to the Person class. Instantiate two Person objects and assign
            // different departments. Print their details.
            //Person person1 = new Person { Id = 1, Name = "Alice", Gender = Gender.Female, Department = "HR" };
            //Person person2 = new Person { Id = 2, Name = "Bob", Gender = Gender.Male, Department = "IT" };

            //person1.PrintDetails();
            //person2.PrintDetails();


            #endregion

            #region Problem4
            //// Extend the Child class to include a method DisplaySalary that uses the sealed Salary
            ////property.Instantiate the class and demonstrate the use of this method.
            //// Create an instance of Child
            //Child child = new Child();

            //// Set the Salary
            //child.Salary = 5000;

            //// Call the DisplaySalary method
            //child.DisplaySalary();

            //// Demonstrate the sealed Print method
            //child.Print();

            #endregion

            #region Problem5
            // Write a static method in the Utility class to calculate the perimeter of a rectangle. Call it
            // without creating an instance of the class.
            //double length = 5.0;
            //double width = 3.0;
            //double perimeter = Utility.CalcRectanglePerimeter(length, width);
            //Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
            #endregion

            #region Problem6
            // Modify the ComplexNumber class to add operator overloading for the multiplication (*)
            //operator. Demonstrate it with two complex numbers. 

            //ComplexNumber complex1 = new ComplexNumber()
            //{
            //    Real = 2,
            //    Imag = 4
            //};
            //ComplexNumber complex2 = new ComplexNumber()
            //{ 
            //    Real = 4,
            //    Imag = 6
            //};

            //ComplexNumber complex3 = complex1 * complex2;

            //Console.WriteLine(complex1);
            //Console.WriteLine(complex2);
            //Console.WriteLine("--------------------");
            //Console.WriteLine(complex3);

            #endregion

            #region Problem7
            // Modify the Gender enum to use byte as its underlying type. Write a program to
            // demonstrate its memory usage compared to the default int.
            //Gender genderByte = Gender.Male;
            //GenderInt genderInt = GenderInt.Male;

            //Console.WriteLine($"Size of Gender (byte): {sizeof(Gender)} bytes");
            //Console.WriteLine($"Size of GenderInt (int): {sizeof(GenderInt)} bytes");

            #endregion

            #region Problem8
            // Create a static method in the Utility class to convert temperatures between Celsius and
            // Fahrenheit.Write code to demonstrate its usage. 

            //double celsius = 25.0;
            //double fahrenheit = Utility.CelsiusToFahrenheit(celsius);
            //Console.WriteLine($"{celsius}°C is {fahrenheit}°F");

            //fahrenheit = 77.0;
            //celsius = Utility.FahrenheitToCelsius(fahrenheit);
            //Console.WriteLine($"{fahrenheit}°F is {celsius}°C");

            #endregion

            #region Problem9
            // Write a program that tries to parse a string to a Grades enum value. Use Enum.TryParse
            // to handle invalid inputs gracefully.

            //Console.Write("Enter a grade (A, B, C, D, E, F): ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Grades grade))
            //{
            //    Console.WriteLine($"Parsed grade: {grade}, Value: {(short)grade}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid grade entered.");
            //}

            #endregion

            #region Problem10
            // Enhance the Employee class to include Equals method. Demonstrate the correct usage of Equals
            //when searching for an employee object in an array using Helper2<Employee>.SearchArray
            //Employee[] employees = new Employee[]
            //{
            //    new Employee(1, "Alice", 5000, 30),
            //    new Employee(2, "Bob", 6000, 35),
            //    new Employee(3, "Charlie", 7000, 40)
            //};

            //Employee targetEmployee = new Employee(2, "Bob", 6000, 35);

            //int index = Helper2<Employee>.SearchArray(employees, targetEmployee);

            //if (index != -1)
            //{
            //    Console.WriteLine($"Employee found at index {index}: {employees[index].GetName()}");
            //}
            //else
            //{
            //    Console.WriteLine("Employee not found.");
            //}

            #endregion

            #region Problem11

            // Write a generic method Max in the Helper class that takes two arguments and returns the
            // greater value. Demonstrate the usage of this method with integers, doubles, and strings. 

            //int intMax = Helper.Max(3, 5);
            //double doubleMax = Helper.Max(3.5, 2.1);
            //string stringMax = Helper.Max("apple", "banana");

            //Console.WriteLine($"Max of 3 and 5: {intMax}");
            //Console.WriteLine($"Max of 3.5 and 2.1: {doubleMax}");
            //Console.WriteLine($"Max of 'apple' and 'banana': {stringMax}");

            #endregion

            #region Problem12
            // Add a new method ReplaceArray in the Helper2<T> class that replaces all occurrences of a
            // specified value in an array with another value.Demonstrate with both integer and string arrays. 

            //int[] intArray = { 1, 2, 3, 2, 4, 2 };
            //string[] stringArray = { "apple", "banana", "apple", "cherry" };

            //Helper2<int>.ReplaceArray(intArray, 2, 5);
            //Helper2<string>.ReplaceArray(stringArray, "apple", "orange");

            //Console.WriteLine("Modified integer array: " + string.Join(", ", intArray));
            //Console.WriteLine("Modified string array: " + string.Join(", ", stringArray));

            #endregion

            #region Problem13
            // Write a non-generic Swap method for a custom struct Rectangle with properties Length and
            // Width.Create instances of Rectangle and demonstrate swapping their values.

            //void Swap(ref Rectangle rect1, ref Rectangle rect2)
            //{
            //    Rectangle temp = rect1;
            //    rect1 = rect2;
            //    rect2 = temp;
            //}

            //Rectangle rect1 = new Rectangle(5, 10);
            //Rectangle rect2 = new Rectangle(15, 20);

            //Console.WriteLine($"Before Swap: rect1 = {rect1}, rect2 = {rect2}");

            //Swap(ref rect1, ref rect2);

            //Console.WriteLine($"After Swap: rect1 = {rect1}, rect2 = {rect2}");

            #endregion

            #region Problem14
            // Create a Department class and use it to add a Department property to the Employee class.
            // Demonstrate searching an array of employees by department using the SearchArray method

            //Department hr = new Department(1, "HR");
            //Department it = new Department(2, "IT");

            //Employee[] employees = new Employee[]
            //{
            //    new Employee(1, "Alice", 5000, 30, hr),
            //    new Employee(2, "Bob", 6000, 35, it),
            //    new Employee(3, "Charlie", 7000, 40, hr)
            //};

            //Department targetDepartment = new Department(1, "HR");

            //int index = Helper2<Employee>.SearchArrayByDepartment(employees, targetDepartment);

            //if (index != -1)
            //{
            //    Console.WriteLine($"Employee found at index {index}: {employees[index].GetName()}");
            //}
            //else
            //{
            //    Console.WriteLine("Employee not found.");
            //}

            #endregion

            #region Problem15
            // Create a custom struct Circle with properties Radius and Color. Compare its instances using both == and Equals. Demonstrate the difference in behavior when the same operations are
            //performed on instances of a Circle class. 

            //CircleStruct circleStruct1 = new CircleStruct(5, "Red");
            //CircleStruct circleStruct2 = new CircleStruct(5, "Red");
            //CircleStruct circleStruct3 = new CircleStruct(7, "Blue");

            //CircleClass circleClass1 = new CircleClass(5, "Red");
            //CircleClass circleClass2 = new CircleClass(5, "Red");
            //CircleClass circleClass3 = new CircleClass(7, "Blue");

            //Console.WriteLine($"circleStruct1 == circleStruct2: {circleStruct1 == circleStruct2}");
            //Console.WriteLine($"circleStruct1.Equals(circleStruct2): {circleStruct1.Equals(circleStruct2)}");
            //Console.WriteLine($"circleStruct1 == circleStruct3: {circleStruct1 == circleStruct3}");
            //Console.WriteLine($"circleStruct1.Equals(circleStruct3): {circleStruct1.Equals(circleStruct3)}");

            //Console.WriteLine($"circleClass1 == circleClass2: {circleClass1 == circleClass2}");
            //Console.WriteLine($"circleClass1.Equals(circleClass2): {circleClass1.Equals(circleClass2)}");
            //Console.WriteLine($"circleClass1 == circleClass3: {circleClass1 == circleClass3}");
            //Console.WriteLine($"circleClass1.Equals(circleClass3): {circleClass1.Equals(circleClass3)}");


            #endregion
        }
    }
}

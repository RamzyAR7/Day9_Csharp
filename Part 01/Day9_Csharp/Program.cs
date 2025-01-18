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

            //============================================================================================

            /**
             * Why is it recommended to explicitly assign values to enum members in some cases? 

             *  1.	Clarity and Readability: Assigning explicit values can make the code more readable and understandable, especially when the values have specific meanings or are used in external systems.
             *  2.	Control Over Values: It provides control over the underlying values of the enum members, which can be important when the values need to match specific requirements, such as protocol definitions, database values, or other external systems.
             *  3.	Backward Compatibility: Explicit values help maintain backward compatibility. If the enum is modified in the future, explicitly assigned values ensure that existing values remain unchanged, preventing potential issues with data consistency.
             *  4.	Avoiding Unintended Changes: Without explicit values, adding or reordering enum members can change the underlying values, leading to unintended consequences. Explicit values prevent this by fixing the values regardless of the order. 
             */

            #endregion

            #region Problem2
            // Modify the Grades enum from the demo to use short as its underlying type and set F to -
            // 1.Write code to print all grade values and their names.

            //foreach (var grade in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"name = {grade}, value = {(short)grade}");
            //}

            //============================================================================================

            //What happens if you assign a value to an enum member that exceeds the underlying
            //type's range?

            /**
             * If you assign a value to an enum member that exceeds the underlying type's range, you will get a compile-time error. 
             * The compiler will not allow you to assign a value that is outside the range of the underlying type, as it would result in a loss of data or an invalid value.
             */

            #endregion

            #region Problem3
            // Add a Department property to the Person class. Instantiate two Person objects and assign
            // different departments. Print their details.
            //Person person1 = new Person { Id = 1, Name = "Alice", Gender = Gender.Female, Department = "HR" };
            //Person person2 = new Person { Id = 2, Name = "Bob", Gender = Gender.Male, Department = "IT" };

            //person1.PrintDetails();
            //person2.PrintDetails();

            //============================================================================================

            //What is the purpose of the virtual keyword when used with properties?

            /**
             * The virtual keyword when used with properties allows derived classes to override the property implementation. 
             * It enables polymorphism and dynamic binding, allowing the base class to define a default implementation that can be overridden by subclasses. 
             * This is useful for creating extensible and customizable class hierarchies where subclasses can provide their own implementation of the property.
             */


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

            //============================================================================================

            //Why can’t you override a sealed property or method? 

            /**
             * You can't override a sealed property or method because the sealed keyword prevents further overriding in derived classes. 
             * When a property or method is marked as sealed in a base class, it indicates that the implementation is final and cannot be changed or extended in subclasses. 
             * This is a deliberate design decision to prevent unintended modifications to critical parts of the class hierarchy and ensure that the behavior remains consistent and predictable.
             */

            #endregion

            #region Problem5
            // Write a static method in the Utility class to calculate the perimeter of a rectangle. Call it
            // without creating an instance of the class.
            //double length = 5.0;
            //double width = 3.0;
            //double perimeter = Utility.CalcRectanglePerimeter(length, width);
            //Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");

            //============================================================================================

            //What is the key difference between static and object members? 

            /**
             * The key difference between static and object members is that static members belong to the class itself, while object members belong to individual instances of the class. 
             * Static members are shared across all instances of the class and can be accessed without creating an instance of the class. 
             * Object members, on the other hand, are specific to each instance of the class and require an instance to access or modify them. 
             * Static members are typically used for utility methods, constants, or shared data that is common to all instances of the class, while object members represent the state and behavior of individual objects.
             */

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

            //============================================================================================
            //Can you overload all operators in C#? Explain why or why not. 

            /**
             * No, you cannot overload all operators in C#. 
             * C# allows operator overloading for a specific set of operators, including arithmetic, comparison, logical, and bitwise operators. 
             * The operators that can be overloaded are limited to those that have predefined meanings for the built-in types. 
             * For example, you can overload the + operator for adding two numbers or concatenating strings, but you cannot overload the && operator for short-circuiting logical AND. 
             * The operators that cannot be overloaded include the assignment operator (=), the conditional operator (?:), the member access operator (.), and the scope resolution operator (::). 
             * This restriction is in place to maintain consistency and prevent misuse of operator overloading, ensuring that the behavior of overloaded operators remains intuitive and predictable.
             */
            #endregion

            #region Problem7
            // Modify the Gender enum to use byte as its underlying type. Write a program to
            // demonstrate its memory usage compared to the default int.
            //Gender genderByte = Gender.Male;
            //GenderInt genderInt = GenderInt.Male;

            //Console.WriteLine($"Size of Gender (byte): {sizeof(Gender)} bytes");
            //Console.WriteLine($"Size of GenderInt (int): {sizeof(GenderInt)} bytes");

            //============================================================================================

            //When should you consider changing the underlying type of an enum? 

            /**
             * You should consider changing the underlying type of an enum when you need to optimize memory usage, improve performance, or ensure compatibility with external systems. 
             * Some common scenarios where changing the underlying type may be beneficial include:
             * 1. Memory Efficiency: If the enum values have a limited range and can be represented with a smaller data type, using a smaller underlying type like byte or short can reduce memory usage and improve performance.
             * 2. Interoperability: When working with external systems or APIs that expect specific data types, using the appropriate underlying type can ensure compatibility and prevent data conversion issues.
             * 3. Performance: In performance-critical applications, using a smaller underlying type can reduce memory access times and improve cache efficiency, leading to better performance.
             * 4. Data Size Constraints: If the enum values need to be stored in a database or transmitted over a network with size constraints, using a smaller underlying type can help minimize data size and optimize storage or bandwidth usage.
             * Changing the underlying type should be done carefully to avoid unintended consequences, such as data loss, overflow, or compatibility issues with existing code. It is important to consider the trade-offs between memory usage, performance, and compatibility when choosing the underlying type for an enum.
             */

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

            //============================================================================================

            //Why can't a static class have instance constructors?

            /**
             * A static class cannot have instance constructors because it is designed to be used without creating instances. 
             * The purpose of a static class is to provide utility methods, constants, or shared data that can be accessed directly through the class name without the need for object instantiation. 
             * Since static classes are not meant to be instantiated, they do not have instance constructors to initialize object state or perform instance-specific operations. 
             * The absence of instance constructors ensures that the class remains static and cannot be instantiated, enforcing the intended usage pattern of static members.
             */

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

            //============================================================================================

            //What are the advantages of using Enum.TryParse over direct parsing with int.Parse?

            /**
             * Enum.TryParse is a safer and more robust way to parse enum values compared to direct parsing with int.Parse. 
             * Some advantages of using Enum.TryParse include:
             * 1. Error Handling: Enum.TryParse handles invalid input gracefully by returning a boolean result indicating success or failure, without throwing exceptions. 
             * This allows you to handle invalid input scenarios without disrupting the flow of the program or causing runtime errors.
             * 2. Case Insensitivity: Enum.TryParse supports case-insensitive parsing, making it easier to handle input that may vary in case or formatting. 
             * This can improve the user experience and reduce the likelihood of errors due to inconsistent input.
             * 3. Enum Validation: Enum.TryParse validates the input against the enum values, ensuring that only valid enum members are accepted. 
             * This helps prevent unexpected behavior or security vulnerabilities that may arise from accepting arbitrary input.
             * 4. Default Value: Enum.TryParse provides an optional default value parameter that allows you to specify a fallback value if the parsing fails. 
             * This can simplify error handling and provide a consistent result in case of invalid input.
             * Overall, Enum.TryParse is a more robust and user-friendly approach to parsing enum values, offering better error handling, case insensitivity, enum validation, and default value support compared to direct parsing with int.Parse.
             */

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
            //====================================================================================================

            //What is the difference between overriding Equals and == for object comparison in C# struct and class ? 

            
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

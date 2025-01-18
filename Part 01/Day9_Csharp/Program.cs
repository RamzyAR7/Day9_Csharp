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

            /**
             * The difference between overriding Equals and == for object comparison in C# struct and class is as follows:
             * 1. Equals Method:
             * - The Equals method is used to compare the values of two objects for equality. It is typically overridden in classes and structs to provide custom equality comparison logic.
             * - When overriding Equals in a class, you can define the equality criteria based on specific properties or fields of the object.
             * - The default implementation of Equals in the Object class performs reference equality comparison, which may not be suitable for custom types.
             * - The Equals method is used for value equality comparison and is commonly used in scenarios where the object's state determines equality.
             * 2. == Operator:
             * - The == operator is used to compare object references for equality. It compares the memory addresses of the objects to determine if they refer to the same instance.
             * - The == operator is not automatically overridden in classes or structs and uses reference equality by default.
             * - For classes, the == operator compares the references of the objects, not their values. To perform value equality comparison, you need to override the == operator or use the Equals method.
             * - For structs, the == operator is automatically overloaded to perform value equality comparison based on the struct's fields or properties.
             * In summary, the key difference is that the Equals method is used for value equality comparison, while the == operator is used for reference equality comparison by default. 
             * For classes, you need to override the == operator or use the Equals method to perform value equality comparison. For structs, the == operator is automatically overloaded to provide value equality comparison.
             */
            ///====================================================================================================
            //Why is overriding ToString beneficial when working with custom classes? 

            /**
             * Overriding ToString is beneficial when working with custom classes because it allows you to define a meaningful string representation of the object. 
             * By providing a custom implementation of ToString, you can control how the object is displayed when converted to a string, making it easier to debug, log, or display the object's state. 
             * Some benefits of overriding ToString include:
             * 1. Readability: A custom ToString implementation can provide a human-readable representation of the object, making it easier to understand and work with in code.
             * 2. Debugging: When debugging or logging, the default ToString output may not be informative. Overriding ToString allows you to include relevant information about the object's state, properties, or fields.
             * 3. Consistency: By defining a consistent format for ToString across your classes, you can ensure that objects are displayed consistently in logs, error messages, or user interfaces.
             * 4. Customization: You can tailor the ToString output to suit your specific needs, such as including only relevant information, formatting data, or hiding sensitive details.
             * 5. Interoperability: ToString is commonly used in string interpolation, logging frameworks, and other parts of the .NET ecosystem. Overriding ToString ensures that your objects are displayed correctly in these contexts.
             * Overall, overriding ToString provides a convenient way to control how your objects are represented as strings, improving readability, debugging, and consistency in your code.
             */

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

            //============================================================================================

            //Can generics be constrained to specific types in C#? Provide an example. 

            /**
             * Yes, generics can be constrained to specific types in C# using type constraints. 
             * Type constraints allow you to restrict the types that can be used with a generic type parameter, ensuring that the generic type meets certain criteria. 
             * There are several types of constraints that can be applied to generics, including:
             * 1. Class Constraint: Specifies that the type argument must be a reference type.
             * 2. Struct Constraint: Specifies that the type argument must be a value type.
             * 3. Constructor Constraint: Specifies that the type argument must have a public parameterless constructor.
             * 4. Interface Constraint: Specifies that the type argument must implement a specific interface.
             * 5. Base Class Constraint: Specifies that the type argument must be derived from a specific base class.
             * Here is an example of a generic method with a class constraint:
             * public class Helper<T> where T : class
             * {
             *     public static void Print(T value)
             *     {
             *         Console.WriteLine(value);
             *     }
             * }
             * In this example, the Helper class has a type parameter T that is constrained to be a reference type (class). 
             * This means that the Print method can only be used with reference types, such as classes or interfaces, and not with value types like int or double.
             * By applying type constraints, you can ensure that the generic type parameter meets specific requirements, making your code more type-safe and preventing errors at compile time.
             */

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

            //============================================================================================

            //What are the key differences between generic methods and generic classes? 


            /**
             * The key differences between generic methods and generic classes are as follows:
             * 1. Scope: Generic methods are methods that can work with any data type, while generic classes are classes that can work with any data type.
             * 2. Flexibility: Generic methods allow you to define methods that can work with different data types without specifying the type in advance. 
             * This provides flexibility and reusability, as the method can be used with various types.
             * 3. Reusability: Generic classes allow you to define classes that can work with different data types without specifying the type in advance. 
             * This promotes code reuse and reduces duplication by creating a single class that can handle multiple types.
             * 4. Type Inference: Generic methods can infer the type argument based on the input parameters, making it easier to use them without specifying the type explicitly. 
             * Generic classes require you to specify the type argument when creating an instance of the class.
             * 5. Constraints: Generic methods and generic classes can have type constraints to restrict the types that can be used with the generic type parameter. 
             * Constraints can be applied to generic methods and classes to ensure that the type argument meets specific criteria.
             * In summary, generic methods are methods that can work with any data type, providing flexibility and reusability, while generic classes are classes that can work with any data type, promoting code reuse and reducing duplication. 
             * Both generic methods and generic classes support type inference and constraints to ensure type safety and flexibility in working with generic types.
             */

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

            //============================================================================================

            //Why might using a generic swap method be preferable to implementing custom methods for
            //each type?

            /**
             * Using a generic swap method is preferable to implementing custom methods for each type because it provides several benefits, including:
             * 1. Reusability: A generic swap method can be used with any data type, allowing you to swap values of different types without writing separate methods for each type. 
             * This promotes code reuse and reduces duplication by providing a single method that works with multiple types.
             * 2. Type Safety: A generic swap method ensures type safety by enforcing type constraints on the generic type parameter. 
             * This prevents type mismatches and errors at compile time, ensuring that the method can only be used with compatible types.
             * 3. Flexibility: A generic swap method can be used with user-defined types, built-in types, and generic types, providing flexibility in working with different data structures and classes. 
             * This makes the method more versatile and adaptable to various scenarios.
             * 4. Readability: A generic swap method simplifies the code by providing a single, clear, and concise implementation for swapping values of any type. 
             * This improves code readability and maintainability by reducing the number of methods and variations needed for different types.
             * 5. Consistency: A generic swap method ensures consistent behavior and implementation across different types, making the code more predictable and easier to understand. 
             * This helps maintain a uniform coding style and reduces the likelihood of errors or inconsistencies in the codebase.
             * Overall, using a generic swap method offers advantages in terms of reusability, type safety, flexibility, readability, and consistency, making it a preferred approach for swapping values of different types.
             */


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

            ///============================================================================================
            ///
            // How can overriding Equals for the Department class improve the accuracy of searches? 

            /**
             * Overriding Equals for the Department class can improve the accuracy of searches by providing a custom equality comparison logic that considers the department's properties. 
             * By overriding Equals, you can define how two Department objects should be compared for equality based on specific criteria, such as the department ID or name. 
             * This allows you to perform more precise and meaningful comparisons when searching for objects in a collection or array.
             * When searching for objects by department, the default implementation of Equals in the Object class performs reference equality comparison, which may not be suitable for custom types like Department. 
             * By overriding Equals in the Department class, you can compare department objects based on their properties, ensuring that the search operation is accurate and returns the expected results.
             * Customizing the equality comparison logic in Equals allows you to define the criteria for equality based on the object's state, properties, or fields. 
             * This can help prevent false positives or incorrect search results that may occur when using the default reference equality comparison.
             * Overall, overriding Equals for the Department class improves the accuracy of searches by providing a custom equality comparison that considers the department's properties, leading to more reliable and precise search operations.
             */

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

            // ============================================================================================

            // Why is == not implemented by default for structs?

            /**
             * The == operator is not implemented by default for structs because structs are value types, and the default behavior of the == operator is reference equality comparison, which is not meaningful for value types. 
             * When comparing two structs using the == operator, the default behavior is to compare the memory addresses of the struct instances, which does not provide a meaningful comparison of their values. 
             * To perform value equality comparison for structs, you need to override the == operator and the Equals method to define custom equality comparison logic based on the struct's properties or fields.
             * By overriding the == operator and the Equals method, you can compare the values of the struct instances rather than their memory addresses, ensuring that the comparison is based on the struct's state. 
             * This allows you to perform accurate and meaningful comparisons of struct instances, making the == operator more useful and consistent with the behavior of reference types like classes.
             * In summary, the == operator is not implemented by default for structs because value types require custom equality comparison logic to compare their values effectively, which can be achieved by overriding the == operator and the Equals method.
             */
            #endregion
        }
    }
}

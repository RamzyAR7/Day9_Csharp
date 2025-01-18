using System;

namespace Day9_Csharp_Part02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem01(generic method to reverse an array)
            //// Test with an array of integers
            //int[] intArray = { 1, 2, 3, 4, 5 };
            //int[] reversedIntArray = Generics.ReverseArray(intArray);
            //Console.WriteLine("Reversed Integer Array: " + string.Join(", ", reversedIntArray));

            //// Test with an array of strings
            //string[] stringArray = { "Ahmed", "Bassem", "Ramzy" };
            //string[] reversedStringArray = Generics.ReverseArray(stringArray);
            //Console.WriteLine("Reversed String Array: " + string.Join(", ", reversedStringArray));

            //// Test with an array of custom objects
            //Person[] peopleArray = {
            //new Person("Ahmed", 22),
            //new Person("Sara", 24),
            //new Person("Youssef", 19)
            //};
            //Person[] reversedPeopleArray = Generics.ReverseArray(peopleArray);
            //Console.WriteLine("Reversed People Array:");
            //foreach (var person in reversedPeopleArray)
            //{
            //    Console.WriteLine(person);

            #endregion

            #region Problem02 (Generic Class for a Stack)
            // Testing the generic stack with integers
            /* GenericStack<int> intStack = new GenericStack<int>();
             intStack.Push(10);
             intStack.Push(20);
             intStack.Push(30);
             Console.WriteLine("Top of int stack: " + intStack.Peek()); // Output: 30
             Console.WriteLine("Popped from int stack: " + intStack.Pop()); // Output: 30

             // Testing the generic stack with strings
             GenericStack<string> stringStack = new GenericStack<string>();
             stringStack.Push("Ahmed");
             stringStack.Push("Bassem");
             Console.WriteLine("Top of string stack: " + stringStack.Peek()); // Output: Bassem
             Console.WriteLine("Popped from string stack: " + stringStack.Pop()); // Output: Bassem*/
            #endregion

            #region problem03 (Generic Method for Swapping Elements)
            //// Test with integers
            //int[] intArray = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Original int array: " + string.Join(", ", intArray));
            //Generics.SwapElements(intArray, 1, 3);
            //Console.WriteLine("After swapping: " + string.Join(", ", intArray)); // Output: 1, 4, 3, 2, 5

            //// Test with strings
            //string[] stringArray = { "Ahmed", "Bassem", "Ramzy" };
            //Console.WriteLine("Original string array: " + string.Join(", ", stringArray));
            //Generics.SwapElements(stringArray, 0, 2);
            //Console.WriteLine("After swapping: " + string.Join(", ", stringArray)); // Output: Ramzy, Bassem, Ahmed
            #endregion

            #region Problem04 (Generic Method for Finding Maximum Element)
            // Test with integers
            int[] intArray = { 10, 20, 30, 5, 15 };
            Console.WriteLine("Maximum in int array: " + Generics.FindMaximum(intArray)); // Output: 30

            // Test with strings
            string[] stringArray = { "Ahmed", "Bassem", "Ramzy", "Zaki" };
            Console.WriteLine("Maximum in string array: " + Generics.FindMaximum(stringArray)); // Output: Zaki

            // Test with doubles
            double[] doubleArray = { 3.5, 7.2, 1.8, 9.6 };
            Console.WriteLine("Maximum in double array: " + Generics.FindMaximum(doubleArray)); // Output: 9.6
            #endregion
        }
    }
}


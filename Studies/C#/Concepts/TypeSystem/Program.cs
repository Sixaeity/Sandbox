using System;
using System.Linq;
using System.Collections.Generic;

namespace Concepts.TypeSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }

        /*
        public void DifferentTypes()
        {
            // There are different types, therefore we cannot sum 'a' and 'b' variables.
            int a = 0;
            bool b = false;
            // string = a + b;
        }
        */

        /*
        public void Declaration()
        {
            // We can declare built-in and custom types.
            int[] source = { 0, 1, 2, 3, 4, 5 };
            var query = from item in source where item <= 3 select item;
        }
        */

        /*
        public void ValueTypes()
        {
            // Built-in numeric types are structs, therefore they can have methods and fields.
            int maxValue = int.MaxValue;

        }
        */

        /*
        enum Values
        {
            // Enum defines a set of of named constants. 
            AValue = 0,
            BValue = 1,
        }
        */

        /*
        public void DeclarationOfReferenceType()
        {
            // Reference types have "null" value before they assignation by new operator or equalation another type. 
            Example example = new Example();
            Example example1 = example;
        }
        */

        /*
        public void Generics()
        {
            // Types can have parameters.
            List<string> names = new List<string> {"Anna", "Bill"};
        }
        */

        /*
        public void CompileAndRuntime()
        {
            // Types can be the same as defined in source code, but sometimes are not.
            int a = 0;
            object b = 0; 
        }
        */
    }

    /*
    public class Example
    {

    }
    */
}
using System;

namespace MyProject01.ValuesAndReferencesTypes {

    class Program {

        public static void App() {

            int num1 = 10;
            int num2 = num1;

            num1 = 20;

            // Value types are passed by copy of value
            Console.WriteLine($"{num1} {num2}");

            var array1 = new int[2];
            array1[0] = 10;

            var array2 = array1;

            Console.WriteLine($"{array1[0]} {array2[0]}");
            
            array1[0] = 20;

            // Reference types are passed by reference and share the same reference
            Console.WriteLine($"{array1[0]} {array2[0]}");
        }
    }
}
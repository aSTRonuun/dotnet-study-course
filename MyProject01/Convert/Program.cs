using System;

namespace MyProject01.Convert1 {

    class Program {

        public static void App() {

            string integerStr = "100";

            int integerInt = Convert.ToInt32(integerStr);

            Console.WriteLine($"{integerInt}");

        }
    }
}
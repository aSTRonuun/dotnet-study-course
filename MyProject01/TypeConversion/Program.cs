using System;

namespace MyProject01.TypeConversion {

    class Program {

        public static void App() {

            int integer = 100;
            float real = 25.5f;

            // real = integer; - Implicit conversion
            // integer = (int)real; - Explicit conversion
            string RealValue = real.ToString();
            integer = Convert.ToInt32(real);
            

            Console.WriteLine($"{RealValue}");
            Console.WriteLine($"{integer}");
            

        }
    }
}
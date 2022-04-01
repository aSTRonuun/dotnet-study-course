using System;
using System.Globalization;

namespace NumbersCoins {

    class Program02 {

        public static void App() {
            
            // decimal is a type number very recomended
            decimal value = 10586.25m;

            // Formated coin according to a culture informated
            // C - Formated Coin Pattern
            // N - Formated Number
            Console.WriteLine(value.ToString(
                "N",
                CultureInfo.CreateSpecificCulture("pt-BR")));
            
            
            
        }
    }
}
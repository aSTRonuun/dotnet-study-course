using System;

namespace NumbersCoins {

    class Program04 {

        public static void App() {
            
            decimal value = 10.25m;

            // Round() - Arrendondar na média
            Console.WriteLine(Math.Round(value));
            
            // Ceiling() - Arrendondar para cima
            Console.WriteLine(Math.Ceiling(value));

            // Floor() - Arrendoda para baixo
            Console.WriteLine(Math.Floor(value));
            
        }
    }
}
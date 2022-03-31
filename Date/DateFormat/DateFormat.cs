using System;

namespace Date{

    class Program01 {

        public static void App() {
            
            Console.Clear();
            
            var data = new DateTime(); // Data padrao - 01/01/0001 00:00:00

            var dateActual = DateTime.Now; // Data e hora atual

            var dateCostumizada = new DateTime(2020, 10, 12, 8, 23, 14);

            Console.WriteLine(dateActual.Year);
            Console.WriteLine(dateActual.Month);
            Console.WriteLine(dateActual.Day);
            Console.WriteLine(dateActual.Hour);
            Console.WriteLine(dateActual.Minute);
            Console.WriteLine(dateActual.Second);

            Console.WriteLine((int) dateActual.DayOfWeek);
            Console.WriteLine((int) dateActual.DayOfYear);
            

            Console.WriteLine();
            
            Console.WriteLine(dateCostumizada); // 
            
        }
    }
}
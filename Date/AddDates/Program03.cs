using System;

namespace Date{

    class Program03 {

        public static void App() {
            
            var date = DateTime.Now;

            Console.WriteLine(date);
            Console.WriteLine(date.AddDays(-12));

            Console.WriteLine(date.AddMonths(1));

            Console.WriteLine(date.AddYears(5));
            
            
            
            
        }
    }
}
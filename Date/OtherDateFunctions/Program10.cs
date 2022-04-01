using System;

namespace Date{

    class Program10 {

        public static void App() {
            
            // DaysInMomth(year, month) - Return the quantity of days in the month
            Console.WriteLine(DateTime.DaysInMonth(2020, 2));

            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

            // IsDaylightSavingTime() - Return true if the date is in DayLightSavingTime, false otherwise 
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
            
            

        }

        // IsWeekend(day) - Return True if the day is weekend, false otherwise
        static bool IsWeekend(DayOfWeek today) {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }


    }
}
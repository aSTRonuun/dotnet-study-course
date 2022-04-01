using System;

namespace Date{

    class Program07 {

        public static void App() {
            
            // Utc.Now retorna o horarios global
            var utcDate = DateTime.UtcNow; 

            Console.WriteLine(utcDate); 

            // Now retorna o horario de acordo com o sistema
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(utcDate.ToLocalTime());
            
            // Algoritmo para transformar o horario de acordo com algum Timezone
            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);
            
            var australiaHour = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            Console.WriteLine(australiaHour);

            // List of Timezones available
            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach(var timezone in timezones) {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine($"-------------");  
            }
            
            
        }
    }
}
using System;

namespace Date{

    class Program08 {

        public static void App() {
            
            
            // TimeSpan é usada para calculos de horas com bastante precisao
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanoSegundos);

            var timeSpanHoraMinutoSegundos = new TimeSpan(8, 49, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundos);

            var timeSpanDiaHoraMinutoSegundos = new TimeSpan(5, 8, 49, 8);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundos);

            var timeSpanDiaHoraMinutoSegundosMilissegundo = new TimeSpan(5, 8, 49, 8, 100);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundosMilissegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundos - timeSpanDiaHoraMinutoSegundos);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundos.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundos.Add(new TimeSpan(12,0,0)));
            
            
            
            
            
            
        }
    }
}
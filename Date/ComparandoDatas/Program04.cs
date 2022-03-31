using System;

namespace Date{

    class Program04 {

        public static void App() {
            
            var date = DateTime.Now;

            // Comparacao nunca vai da verdadeia pois ele compara toda a estrutura inclise
            // os milesimos de segundo 
            // if(date == DateTime.Now) {
            //     Console.WriteLine("É igual");
            // } - Errado

            if(date.Date == DateTime.Now.Date) {
                Console.WriteLine("É igual");
            }
            
            Console.WriteLine(date);
            
            
            
        }
    }
}
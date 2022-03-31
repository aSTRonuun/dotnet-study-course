using System;

namespace Date{

    class Program02 {

        public static void App() {
            
            var date = DateTime.Now;

            // d -> (short date) 31/03/2022
            var formated = String.Format("{0:d}", date); 

            // D -> (long date) quinta-feira, 31 de março de 2022
            formated = String.Format("{0:D}", date); 
            
            // g -> (short date and hour) 31/03/2022 13:37
            formated = String.Format("{0:g}", date);

            //f -> (long date and hour) quinta-feira, 31 de março de 2022 13:33
            formated = String.Format("{0:f}", date);



            Console.WriteLine(formated);
            
        }
    }
}
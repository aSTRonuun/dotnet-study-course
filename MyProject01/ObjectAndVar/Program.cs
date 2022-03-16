using System;

namespace MyProject01.ObjectAndVar {

    class Program {

        public static void App() {

            var age = 25;
            
            /*
            age = "Vinte Cinco": - Erro: Nao é possivel converter string para int
            */

            // Nao é uma boa pratica
            object age2 = 22;
            age2 = "Vinte Dois";

            Console.WriteLine($"{age}, {age2}");
            
        }
    }
}
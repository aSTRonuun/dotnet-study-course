using System;

namespace CompareStrings {

    class Program3 {

        public static void App() {
        
            string text = "Testing";

            // CompareTo ->  returna um numero 0 se a string passada for igual, 1 se for diferent
            Console.WriteLine(text.CompareTo("Testing"));

            // Contains -> retorna true se a string passada for estiver contido dentro da string, e false se nao tiver
            Console.WriteLine(text.Contains("test", StringComparison.OrdinalIgnoreCase));
            
            
        }
    }
}


using System;

namespace StarEndString {

    class Program4 {

        public static void App() {
        
            string text = "This text is a test";

            // StartsWith() -> retorna true se a string passada for igual o começo da string original
            Console.WriteLine(text.StartsWith("This"));
            Console.WriteLine(text.StartsWith("this", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(text.StartsWith("texto"));

            Console.WriteLine(text.EndsWith("test"));
            Console.WriteLine(text.EndsWith("Test", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(text.EndsWith("texto"));
            
        }
    }
}


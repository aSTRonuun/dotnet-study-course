using System;

namespace Equals {

    class Program5 {

        public static void App() {
        
            string text = "This text is a test";
            
            // Equals -> retorna true se a string passada for exatamente igual a string original, ou false caso contrário
            Console.WriteLine(text.Equals("This text is a test"));
            Console.WriteLine(text.Equals("this text is a test"));
            Console.WriteLine(text.Equals("this text is a test", StringComparison.InvariantCultureIgnoreCase));
            
        }
    }
}


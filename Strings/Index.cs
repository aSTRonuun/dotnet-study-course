using System;

namespace Index {

    class Program6 {

        public static void App() {
        
            string text = "This text is a test";

            // IndexOf() -> retorna a primeira posicao que encontrar a substring na string original
            Console.WriteLine(text.IndexOf("is"));

            // LasIndexOf() -> retorna a ultimo posicao que encontrar a subtring na string original
            Console.WriteLine(text.LastIndexOf("s"));
            

            
            
            
        }
    }
}


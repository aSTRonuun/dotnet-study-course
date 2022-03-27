using System;

namespace MethoodosAdicionais {

    class Program7 {

        public static void App() {
        
            string text = "This text is a test";

            // ToLewer() -> convert toda a string para caracteres minusculos
            Console.WriteLine(text.ToLower());

            // ToUpper() -> convert all a string with caracters maisculos
            Console.WriteLine(text.ToUpper());

            // Insert() -> Insere uma substring na string original no indice passado
            Console.WriteLine(text.Insert(5, "HERE "));

            // Remove() -> Remove uma substring na string original comecando e terminando nos indices passados, respectivamente.
            Console.WriteLine(text.Remove(5, 5));

            // Lenght -> retorna a quantidade de caracteres em de uma string
            Console.WriteLine(text.Length);
           
           
           
           
            
            

            
            
            
        }
    }
}


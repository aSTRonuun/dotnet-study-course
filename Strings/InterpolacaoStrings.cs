using System;

namespace InterpolacaoStrings {

    class Program2 {

        public static void App() {
        
            double price = 10.5;

            // Option interpolation string with caractere -> +
            string text1 = "O preco do produto é " + price;
            Console.WriteLine(text1);
            

            // Option interpolation string with function -> string.Format()
            string text2 = string.Format("O proce do produto é {0}", price);
            Console.WriteLine(text1);


            // Option interpolation string with caractere -> $
            string text3 = $"O preco do produto eh {price}";
            Console.WriteLine(text1);
        }
    }
}


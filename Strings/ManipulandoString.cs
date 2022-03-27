using System;

namespace ManipulandoStrings {

    class Program8 {

        public static void App() {
        
            string text = "This text is a test";

            // Replace() -> substitui uma substring antiga, por uma substring nova na string original, passadas respectivamente
            Console.WriteLine(text.Replace("e", "x"));
            
            string[] division = text.Split(" ");
            Console.WriteLine(division[0]);
            Console.WriteLine(division[1]);
            Console.WriteLine(division[2]);
            Console.WriteLine(division[3]);

            string result = text.Substring(5, text.IndexOf("t"));
            Console.WriteLine(result);

            Console.WriteLine(text.Trim());
            
            
            
        }
    }
}


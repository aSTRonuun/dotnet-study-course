using System;

namespace MyProject01.MetodosAndFunction {

    class Program {

        public static void App() {
           printf("C# is very nice Language");
           string completeName = ReturnName("Vitor", "Alves", 21);

           Console.WriteLine($"{completeName}");
           
        }

        public static void printf(string str) {
            Console.WriteLine(str);
            
        }

        public static string ReturnName(string name, string lastname, int age = 0) {
            return name + " " + lastname + " has " + age + " years old";
        }
    }
}
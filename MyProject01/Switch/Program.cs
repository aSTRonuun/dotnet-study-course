using System;

namespace MyProject01.Switch {

    class Program {

        public static void App() {

            bool? value = null;

            switch(value) {

                case true: {
                    Console.WriteLine("True");
                    break;   
                }
                case false: {
                    Console.WriteLine("False");
                    break;   
                }
                default: {
                    Console.WriteLine("Null");
                    break;
                }
            }
        }
    }
}
using System;

namespace EditorHtml {


    public static class Menu {

        public static void Show() {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());


        }

        public static void DrawScreen() {

            Console.Write("+");
            for(int i=0; i<30; i++) {
                Console.Write("-");
            }
            System.Console.Write("+");
            Console.Write("\n");

            for(int lines = 0; lines < 10; lines++) {
                System.Console.Write("|");
                for(int i=1; i<=30; i++) {
                    System.Console.Write(" ");
                }
                System.Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for(int i=0; i<30; i++) {
                Console.Write("-");
            }
            System.Console.Write("+");
            Console.Write("\n");
        }


        public static void WriteOptions() {

            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("==============");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Abrir Arquivo");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.Write("Option > ");

            
            
            
            
            
            
        } 
        

    }
}
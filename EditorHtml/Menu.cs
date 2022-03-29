using System;

namespace EditorHtml {


    public static class Menu {

        public static void Show() {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();



        }

        public static async void DrawScreen() {

            Console.Write("+");
            for(int i=0; i<30; i++) {
                Console.Write("-");
            }
            System.Console.Write("+");
            Console.Write("\n");

            for(int lines = 0; lines < 10; lines++) {
                System.Console.Write("|");
                for(int i=0; i<=30; i++) {
                    System.Console.Write(" ");
                }
                System.Console.Write("|");
                Console.Write("\n");
            }
        }


    }
}
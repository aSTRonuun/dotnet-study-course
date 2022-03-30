using System;
using System.Text;

namespace EditorHtml {

    public static class Editor {

        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-------------");
            Start();
        }

        public static void Start() {
            var file = new StringBuilder();

            do {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("--------------");
            Console.WriteLine(" Deseja salvar o arquivo?");
        

            Console.WriteLine("1 - Salvar");
            Console.WriteLine("0 - Descartar Alterações");
            var option = short.Parse(Console.ReadLine());
            HandleSaveOption(option, file.ToString());
            
        }

        public static void HandleSaveOption(short option, string text) {

            switch(option) {
                case 1: Save(text); break;
                case 0: break;
                default: break;
            }
        }

        public static void Save(string text) {

            Console.WriteLine(" ");
            Console.WriteLine("which path do you want to save?");

            var path = Console.ReadLine();
            using(var file = new StreamWriter(path)) {
                file.Write(text);
            }

            Console.WriteLine($"Archive {path} save with sucess");
            Console.ReadLine();
            Menu.Show();
            
            
        }
    }
}
using System;

namespace Stopwatch {

    class Program {

        static void Main(string[] args) {

            Menu();
            
        }

        static void Menu() {

            Console.Clear();
            Console.WriteLine("S = Second => 10s = 10 seconds");
            Console.WriteLine("M = Minute => 1m = 1 minutes");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("What time you want count?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;
            if (type == 'm')
                multiplier = 60;
            
            if(time == 0) 
                System.Environment.Exit(0);
            
            PreStart(time * multiplier);
            
        }

        static void PreStart(int time) {

            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
            
        }

        static async void Start(int time) {
            int currentTime = 0;

            for(int i = time; i >= 0; i--) {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            // while(currentTime != time) {
            //     currentTime++;
            //     Console.Clear();
            //     Console.WriteLine(currentTime);
            //     Thread.Sleep(1000);
            // }

            Console.Clear();
            Console.WriteLine("Stopwatch has finished");
            Thread.Sleep(2000);
            Menu();
        }

        
    }
}
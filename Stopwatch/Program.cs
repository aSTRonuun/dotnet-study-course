using System;

namespace Stopwatch {

    class Program {

        static void Main(string[] args) {

            Start();
            
        }

        static void Start(int time) {
            int currentTime = 0;

            while(currentTime != time) {
                currentTime++;
                Console.Clear();
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch has finished");
            Thread.Sleep(2000);
            
        }

        
        
    }
}
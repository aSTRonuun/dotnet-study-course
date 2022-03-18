using System;

namespace Calculato {


    class Program {

        static void Main(string[] args) {
            Menu();
        }

        static void Menu() {

            Console.Clear();
            
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.WriteLine($"Sua opção: ");
            int operation = int.Parse(Console.ReadLine());

            switch(operation) {
                case 1:
                    Sum();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                case 0:
                    System.Environment.Exit(0); // Close program
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        static void Sum() {

            Console.Clear();

            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 + v2;


            Console.WriteLine("The result is: " + result);
            Console.ReadKey();
            Menu();
        }

        static void Subtraction() { 
            Console.Clear();

            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 - v2;


            Console.WriteLine("The result is: " + result);
            Console.ReadKey();
            Menu(); 
        }
    
        static void Division() {

            Console.Clear();
            
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            float result = v1 / v2;

            Console.WriteLine("The result is: " + result);
            Console.ReadKey();
            Menu();
        }

        static void Multiplication() {

            Console.Clear();
            
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 * v2;

            Console.WriteLine("The result is: " + result);
            Console.ReadKey();
            Menu();
        }
    }
}
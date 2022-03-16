using System;
using MyProject01.Struct;

namespace MyProject01 {
    class App {

        static void Main(string[] args) {

            var product = new Product(1, "Mouse Gamer", 199.99, Enuns.EProductType.Product);
            var eletricalManutention = new Product(2, "Eletrical Manutention", 499.99, Enuns.EProductType.Service);

            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.Id);
            Console.WriteLine(product.Type);

            Console.WriteLine(eletricalManutention.Name);
            Console.WriteLine(eletricalManutention.Price);
            Console.WriteLine(eletricalManutention.Id);
            Console.WriteLine(eletricalManutention.Type);
            
           
           
        }
    }
}
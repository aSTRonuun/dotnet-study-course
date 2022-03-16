using System;
using MyProject01.Enuns;

namespace MyProject01.Struct {

    struct Product {

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;


        public Product(int id, string name, double price, EProductType type) {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public double PriceInDolar(double dolar) {
            return Price * dolar;
        }
    }
}
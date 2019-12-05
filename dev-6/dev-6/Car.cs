using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_6
{
    class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public int Price { get; }

        public Car(string brand, string model, int price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }
    }
}

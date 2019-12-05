using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_6
{
    class CarsDataBase
    {
        private bool _notEmpty;
        public List<Car> CarsList { get; } = new List<Car>();

        public void AddCars(string brand, string model, int price, int count)
        {
            if (price >= 0 && count > 0)
            {
                CarsList.AddRange(new Car[count].Select(c => new Car(brand, model, price)));
                _notEmpty = true;
            }
            else
            {
                Console.WriteLine("WrongInput, try again. (hint : price should be >= 0 and count must be >0 )");
            }
        }

        public void DisplayTypesCount()
        {
            if (_notEmpty)
            {
                Console.WriteLine("Brand count is : " + CarsList.
                    Select(x => x.Model).
                    Distinct().
                    Count());
            }
            else
            {
                Console.WriteLine("Data Base is empty, try adding cars");
            }
        }

        public void DisplayAllCarsCount()
        {
            if (_notEmpty)
            {
                Console.WriteLine("Cars count is : " + CarsList.Count());
            }
            else
            {
                Console.WriteLine("Data Base is empty, try adding cars");
            }
        }

        public void DisplayAveragePrice()
        {
            if (_notEmpty)
            {
                Console.WriteLine("Average price is : " + CarsList.
                    Select(x => x.Price).
                    Average());
            }
            else
            {
                Console.WriteLine("Data Base is empty, try adding cars");
            }
        }

        public void DisplayAveragePrice(string brand)
        {
            if (_notEmpty)
            {
                Console.WriteLine($"Average price for {brand} is : " + CarsList.
                    Where(x => x.Brand.Equals(brand)).
                    Select(x => x.Price).
                    Average());
            }
            else
            {
                Console.WriteLine("Data Base is empty, try adding cars");
            }
        }
    }
}

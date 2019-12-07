using System;
using System.Collections.Generic;
using System.Linq;

namespace dev_6
{
    /// <summary>
    /// Class for cars Database
    /// </summary>
    class CarsDataBase
    {
        private bool _notEmpty;
        public List<Car> CarsList { get; } = new List<Car>();
        /// <summary>
        /// Adds cars to Cars List
        /// </summary>
        /// <param name="brand">Car's brand</param>
        /// <param name="model">Car's model</param>
        /// <param name="price">Car's price</param>
        /// <param name="count">Car's count</param>
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
        /// <summary>
        /// Displays info about brand count
        /// </summary>
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
        /// <summary>
        /// Displays info about all cars count
        /// </summary>
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
        /// <summary>
        /// Displays info about average price of all cars
        /// </summary>
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
        /// <summary>
        /// Displays info about average price of cars with concrete Brand
        /// </summary>
        /// <param name="brand">Car's brand</param>
        public void DisplayAveragePrice(string brand)
        {
            if (_notEmpty)
            {
                try
                {
                    Console.WriteLine($"Average price for {brand} is : " + CarsList.
                        Where(x => x.Brand.Equals(brand)).
                        Select(x => x.Price).
                        Average());
                }
                catch(Exception)
                {
                    Console.WriteLine("No cars with such brand!");
                }
            }
            else
            {
                Console.WriteLine("Data Base is empty, try adding cars");
            }
        }
    }
}

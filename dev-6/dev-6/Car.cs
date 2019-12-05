namespace dev_6
{
    /// <summary>
    /// Class for Car object
    /// </summary>
    class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public int Price { get; }
        /// <summary>
        /// Sets brand, model and price properties
        /// </summary>
        /// <param name="brand">Brand parameter</param>
        /// <param name="model">Model parameter</param>
        /// <param name="price">Price parameter</param>
        public Car(string brand, string model, int price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }
    }
}

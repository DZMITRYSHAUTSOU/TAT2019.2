namespace dev_6
{
    /// <summary>
    /// Command class for Count Types command
    /// </summary>
    class AveragePriceTypeCommand : ICommand
    {
        CarsDataBase carsDataBase;
        public string Brand { get; }
        /// <summary>
        /// Constructor that sets carsDataBase (Receiver)
        /// </summary>
        /// <param name="carsDataBase">Cars Database</param>
        /// <param name="brand">Brand name used by Database to search data</param>
        public AveragePriceTypeCommand(CarsDataBase carsDataBase, string brand)
        {
            this.carsDataBase = carsDataBase;
            Brand = brand;
        }
        /// <summary>
        /// Calls database method
        /// </summary>
        public void Execute()
        {
            carsDataBase.DisplayAveragePrice(Brand);
        }
    }
}

namespace dev_6
{
    /// <summary>
    /// Command class for Count Types command
    /// </summary>
    class CountAllCommand : ICommand
    {
        CarsDataBase carsDataBase;
        /// <summary>
        /// Constructor that sets carsDataBase (Receiver)
        /// </summary>
        /// <param name="carsDataBase">Cars Database</param>
        public CountAllCommand(CarsDataBase carsDataBase)
        {
            this.carsDataBase = carsDataBase;
        }
        /// <summary>
        /// Calls database method
        /// </summary>
        public void Execute()
        {
            carsDataBase.DisplayAllCarsCount();
        }
    }
}

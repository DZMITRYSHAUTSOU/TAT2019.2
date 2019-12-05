namespace dev_6
{
    /// <summary>
    /// Class for invoker
    /// </summary>
    class Invoker
    {
        ICommand command;
        /// <summary>
        /// Sets command field
        /// </summary>
        /// <param name="command">Current command of invoker</param>
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        /// <summary>
        /// Calls command's Execute method
        /// </summary>
        public void Run()
        {
            command?.Execute();
        }
    }
}

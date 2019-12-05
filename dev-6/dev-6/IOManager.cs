using System;

namespace dev_6
{
    /// <summary>
    /// Class for IOManager
    /// </summary>
    class IOManager
    {
        CarsDataBase carsDataBase = new CarsDataBase();
        CommandsEnum a;
        Invoker b = new Invoker();
        /// <summary>
        /// Method that begins I/O dialog with user using Console
        /// </summary>
        public void Dialog()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Input one command from following:\n (1) Add cars\n (2) Count types\n (3) Count all\n (4) Average price\n (5) Average price 'brand'\n (6) Exit");
                Enum.TryParse(Console.ReadLine(), out a);
                switch (a)
                {
                    case CommandsEnum.InputCars:
                        Console.WriteLine("Input car info \n brand, model, price, count");
                        try
                        {
                            carsDataBase.AddCars(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                            Console.WriteLine("Added successfully");
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Wrong input format, try again");
                        }
                        Console.ReadKey();
                        break;
                    case CommandsEnum.CountTypes:
                        b.SetCommand(new CountTypesCommand(carsDataBase));
                        b.Run();
                        Console.ReadKey();
                        break;
                    case CommandsEnum.AveragePrice:
                        b.SetCommand(new AveragePriceCommand(carsDataBase));
                        b.Run();
                        Console.ReadKey();
                        break;
                    case CommandsEnum.AveragePriceType:
                        Console.WriteLine("Input brand :");
                        b.SetCommand(new AveragePriceTypeCommand(carsDataBase, Console.ReadLine()));
                        b.Run();
                        Console.ReadKey();
                        break;
                    case CommandsEnum.CountAll:
                        b.SetCommand(new CountAllCommand(carsDataBase));
                        b.Run();
                        Console.ReadKey();
                        break;
                    case CommandsEnum.Exit:
                        return;
                }
            }
        }
    }
}

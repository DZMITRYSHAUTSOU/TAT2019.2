using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_6
{
    class AveragePriceTypeCommand : ICommand
    {
        CarsDataBase carsDataBase;
        public string Brand { get; }

        public AveragePriceTypeCommand(CarsDataBase carsDataBase, string brand)
        {
            this.carsDataBase = carsDataBase;
            Brand = brand;
        }

        public void Execute()
        {
            carsDataBase.DisplayAveragePrice(Brand);
        }
    }
}

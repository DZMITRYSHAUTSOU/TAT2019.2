using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_6
{
    class AveragePriceCommand : ICommand
    {
        CarsDataBase carsDataBase;

        public AveragePriceCommand(CarsDataBase carsDataBase)
        {
            this.carsDataBase = carsDataBase;
        }

        public void Execute()
        {
            carsDataBase.DisplayAveragePrice();
        }
    }
}

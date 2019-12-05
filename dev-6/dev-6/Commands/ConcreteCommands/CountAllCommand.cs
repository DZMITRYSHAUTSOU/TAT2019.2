using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_6
{
    class CountAllCommand : ICommand
    {
        CarsDataBase carsDataBase;

        public CountAllCommand(CarsDataBase carsDataBase)
        {
            this.carsDataBase = carsDataBase;
        }

        public void Execute()
        {
            carsDataBase.DisplayAllCarsCount();
        }
    }
}
